using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_sala_petshop
{
    public partial class Registrousuarios : Form
    {
        public string nivelAcesso { get; set; }

        public string nomeFuncionario { get; set; }


        public Registrousuarios()
        {
            InitializeComponent();
        }

        private void bt_busca_registro_Click(object sender, EventArgs e)
        {
            nivelAcesso = cb_nivel_acesso.Text;

            Connection cn = new Connection();

            cn.conn.Open();

            string selectQuery = @"SELECT id_usuario AS 'Número de Registro do Funcionário',nome_usuario AS 'Nome do Funcionário',
                                 nivel_acesso AS 'Nível de Acesso',sexo AS 'Gênero' FROM usuarios WHERE nivel_acesso = @nivel_acesso";

            SqlCommand cmd = new SqlCommand(selectQuery, cn.conn);

            cmd.Parameters.AddWithValue("@nivel_acesso", nivelAcesso);

            DataTable dt = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();

            // Carregando os dados do reader para o DataTable
            dt.Load(reader);
            reader.Close();
            dataGridViewRegisFunc.DataSource = dt;
            cn.conn.Close();
        }


        private void bt_limpar_regis_func_Click(object sender, EventArgs e)
        {
            dataGridViewRegisFunc.DataSource = "";
            cb_nivel_acesso.Text = "";
        }

        private void bt_excluir_regis_func_Click(object sender, EventArgs e)
        {

            if (dataGridViewRegisFunc.DataSource == null)
            {
                MessageBox.Show("Realize uma consulta e selecione um dado antes de excluir um registro!", "Consulta Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult resultado = MessageBox.Show("Confirma a exclusão do funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (resultado == DialogResult.Yes)
            {
                // Verifica se uma linha está selecionada
                if (dataGridViewRegisFunc.SelectedRows.Count > 0)
                {
                    try
                    {
                        Connection cn = new Connection();

                        cn.conn.Open();


                        int rowIndexFunc = dataGridViewRegisFunc.SelectedRows[0].Index;

                        // Obtém o ID do registro selecionado
                        int idFunc = Convert.ToInt32(dataGridViewRegisFunc.Rows[rowIndexFunc].Cells["Número de Registro do Funcionário"].Value);

                        dataGridViewRegisFunc.Rows.RemoveAt(rowIndexFunc);

                        string delRegisFunc = "delete from usuarios where id_usuario = @id_usuario";

                        SqlCommand cmdDel = new SqlCommand(delRegisFunc, cn.conn);

                        cmdDel.Parameters.AddWithValue("@id_usuario", idFunc);
                        cmdDel.ExecuteNonQuery();

                        MessageBox.Show("Registro Excluído!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        cn.conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir registro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Erro ao excluir registro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void bt_salvar_regis_func_Click(object sender, EventArgs e)
        {
            if (dataGridViewRegisFunc.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow row = dataGridViewRegisFunc.SelectedRows[0];

                // Obtém os valores das células da linha
                int id = Convert.ToInt32(row.Cells["Número de Registro do Funcionário"].Value);

                nomeFuncionario = row.Cells["Nome do Funcionário"].Value.ToString();
                nivelAcesso = row.Cells["Nível de Acesso"].Value.ToString();
                char genero = Convert.ToChar(row.Cells["Gênero"].Value);


                DialogResult resultado = MessageBox.Show("Tem certeza que deseja salvar as alterações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        Connection cn = new Connection();

                        cn.conn.Open();

                        string query = "UPDATE usuarios SET nome_usuario = @nome_usuario, " +
                            "nivel_acesso = @nivel_acesso, sexo = @sexo WHERE id_usuario = @id_usuario";

                        SqlCommand command = new SqlCommand(query, cn.conn);
                        command.Parameters.AddWithValue("@nome_usuario", nomeFuncionario);
                        command.Parameters.AddWithValue("@nivel_acesso", nivelAcesso);
                        command.Parameters.AddWithValue("@sexo", genero);
                        command.Parameters.AddWithValue("@id_usuario", id);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro foi atualizado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao atualizar registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma linha para atualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }

        private void bt_voltar_gerenciar_func_Click(object sender, EventArgs e)
        {
            panel_cadastro_func.Controls.Clear();
            Gerenciar gerenciar = new Gerenciar() { TopLevel = false, TopMost = true };
            gerenciar.FormBorderStyle = FormBorderStyle.None;
            panel_cadastro_func.Controls.Add(gerenciar);
            gerenciar.Show();
        }

        private void panel_cadastro_func_Paint(object sender, PaintEventArgs e)
        {

        }

        private void headerLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
