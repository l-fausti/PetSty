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
    public partial class Cadusuarios : Form
    {

        public string nomeFuncionario { get; set; }

        public string senhaFuncionario { get; set; }

        public string confirmarSenhaFunc { get; set; }

        public string genero { get; set; }

        public string nivelAcesso { get; set; }


        public Cadusuarios()
        {
            InitializeComponent();
        }

        private void bt_voltar_gerenciar_func_Click(object sender, EventArgs e)
        {
            panel_cad_func.Controls.Clear();
            Gerenciar gerenciar = new Gerenciar() { TopLevel = false, TopMost = true };
            gerenciar.FormBorderStyle = FormBorderStyle.None;
            panel_cad_func.Controls.Add(gerenciar);
            gerenciar.Show();
        }

        private void bt_cadastrar_func_Click(object sender, EventArgs e)
        {
            try
            {

                Connection cn = new Connection();
                cn.conn.Open();

                nomeFuncionario = tb_nome_func.Text;
                senhaFuncionario = tb_senha_func.Text;
                confirmarSenhaFunc = tb_confirm_senha.Text;

                // Definindo o valor do sexo como 'M' ou 'F' (pois a tabela só aceita 1 caractere)
                genero = ckb_fem.Checked ? "F" : (ckb_masc.Checked ? "M" : "");

                // Definindo o nível de acesso 
                nivelAcesso = ckb_comum.Checked ? "Comum" : (ckb_admin.Checked ? "Admin" : "");


                if (string.IsNullOrEmpty(nomeFuncionario) || string.IsNullOrEmpty(senhaFuncionario) || string.IsNullOrEmpty(confirmarSenhaFunc)
                    || string.IsNullOrEmpty(nivelAcesso) || string.IsNullOrEmpty(genero))
                {
                    MessageBox.Show("Por favor, preencha todos os dados!", "Preechimento de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "INSERT INTO usuarios (nome_usuario, senha_usuario, sexo, nivel_acesso) " +
                               "VALUES (@nome, @senha, @sexo, @nivel_acesso)";

                SqlCommand cmd = new SqlCommand(query, cn.conn);


                cmd.Parameters.AddWithValue("@nome", nomeFuncionario);
                cmd.Parameters.AddWithValue("@senha", senhaFuncionario);
                cmd.Parameters.AddWithValue("@sexo", genero);
                cmd.Parameters.AddWithValue("@nivel_acesso", nivelAcesso);


                int linhasAfetadas = cmd.ExecuteNonQuery();

                if (tb_senha_func.Text == tb_confirm_senha.Text)
                {
                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Novo funcionário registrado!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Cadastrar!", "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Confirme a senha corretamente!", "Senha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


                cn.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void ckb_fem_Click(object sender, EventArgs e)
        {

            this.ckb_masc.Enabled = false;
            this.ckb_masc.Checked = false;

            if (ckb_fem.Checked == true)
            {
                this.ckb_masc.Enabled = true;
                this.ckb_masc.Checked = false;
            }

        }

        private void ckb_masc_Click(object sender, EventArgs e)
        {
            this.ckb_fem.Enabled = false;
            this.ckb_fem.Checked = false;

            if (ckb_masc.Checked == true)
            {
                this.ckb_fem.Enabled = true;
                this.ckb_fem.Checked = false;
            }
        }

        private void ckb_comum_Click(object sender, EventArgs e)
        {
            this.ckb_admin.Enabled = false;
            this.ckb_admin.Checked = false;

            if (ckb_comum.Checked == true)
            {
                this.ckb_admin.Enabled = true;
                this.ckb_admin.Checked = false;
            }
        }

        private void ckb_admin_Click(object sender, EventArgs e)
        {
            this.ckb_comum.Enabled = false;
            this.ckb_comum.Checked = false;

            if (ckb_admin.Checked == true)
            {
                this.ckb_comum.Enabled = true;
                this.ckb_comum.Checked = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Troca o tipo de exibição da senha
            tb_senha_func.UseSystemPasswordChar = !tb_senha_func.UseSystemPasswordChar;

            // Torna a PictureBox de olho fechado invisível e o olho aberto visível
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            // Troca o tipo de exibição da senha
            tb_senha_func.UseSystemPasswordChar = !tb_senha_func.UseSystemPasswordChar;

            // Torna a PictureBox de olho aberto invisível e o olho fechado visível
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Troca o tipo de exibição da senha
            tb_confirm_senha.UseSystemPasswordChar = !tb_confirm_senha.UseSystemPasswordChar;

            // Torna a PictureBox de olho fechado invisível e o olho aberto visível
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            // Troca o tipo de exibição da senha
            tb_confirm_senha.UseSystemPasswordChar = !tb_confirm_senha.UseSystemPasswordChar;

            // Torna a PictureBox de olho aberto invisível e o olho fechado visível
            pictureBox5.Visible = false;
            pictureBox4.Visible = true;
        }
    }
}
