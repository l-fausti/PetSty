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
    public partial class Alterarsenha : Form
    {

        public string nomeFunc { get; set; }
        public string senhaAtual { get; set; }
        public string novaSenha { get; set; }
        public string confirmacaoSenha { get; set; }
        string senhaArmazenada { get; set; }


        public Alterarsenha()
        {
            InitializeComponent();
        }

        private void bt_atualizar_senha_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja salvar as alterações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    nomeFunc = tb_nome_up_senha.Text;
                    senhaAtual = tb_senha_atual.Text;
                    novaSenha = tb_nova_senha.Text;
                    confirmacaoSenha = tb_confirmacao_senha.Text;

                    Connection cn = new Connection();

                    cn.conn.Open();

                    string querySel = "Select senha_usuario from usuarios WHERE senha_usuario = @senha_usuario";

                    SqlCommand cmdSel = new SqlCommand(querySel, cn.conn);
                    cmdSel.Parameters.AddWithValue("@senha_usuario", senhaAtual);

                    senhaArmazenada = cmdSel.ExecuteScalar() as string;

                    if (senhaArmazenada != null)
                    {
                        if (novaSenha == confirmacaoSenha)
                        {
                            string queryUp = "UPDATE usuarios SET senha_usuario = @senha_usuario WHERE nome_usuario = @nome_usuario";


                            SqlCommand cmdUp = new SqlCommand(queryUp, cn.conn);
                            cmdUp.Parameters.AddWithValue("@senha_usuario", novaSenha);
                            cmdUp.Parameters.AddWithValue("@nome_usuario", nomeFunc);


                            int rowsAffected = (int)cmdUp.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Registro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tb_nome_up_senha.Clear();
                                tb_senha_atual.Clear();
                                tb_nova_senha.Clear();
                                tb_confirmacao_senha.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Nenhum registro foi atualizado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            cn.conn.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("A senha informada não corresponde com a sua senha atual!", "Validação de Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void bt_voltar_alterar_senha_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Home home = new Home() { TopLevel = false, TopMost = true };
            home.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(home);
            home.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Troca o tipo de exibição da senha
            tb_senha_atual.UseSystemPasswordChar = !tb_senha_atual.UseSystemPasswordChar;

            // Torna a PictureBox de olho fechado invisível e o olho aberto visível
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Troca o tipo de exibição da senha
            tb_senha_atual.UseSystemPasswordChar = !tb_senha_atual.UseSystemPasswordChar;

            // Torna a PictureBox de olho aberto invisível e o olho fechado visível
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Troca o tipo de exibição da senha
            tb_nova_senha.UseSystemPasswordChar = !tb_nova_senha.UseSystemPasswordChar;

            // Torna a PictureBox de olho fechado invisível e o olho aberto visível
            pictureBox5.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Troca o tipo de exibição da senha
            tb_nova_senha.UseSystemPasswordChar = !tb_nova_senha.UseSystemPasswordChar;

            // Torna a PictureBox de olho aberto invisível e o olho fechado visível
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // Troca o tipo de exibição da senha
            tb_confirmacao_senha.UseSystemPasswordChar = !tb_confirmacao_senha.UseSystemPasswordChar;

            // Torna a PictureBox de olho fechado invisível e o olho aberto visível
            pictureBox8.Visible = false;
            pictureBox9.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // Troca o tipo de exibição da senha
            tb_confirmacao_senha.UseSystemPasswordChar = !tb_confirmacao_senha.UseSystemPasswordChar;

            // Torna a PictureBox de olho aberto invisível e o olho fechado visível
            pictureBox9.Visible = false;
            pictureBox8.Visible = true;
        }
    }
}

