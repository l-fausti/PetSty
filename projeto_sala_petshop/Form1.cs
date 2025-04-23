using Microsoft.Data.SqlClient;
using ReaLTaiizor.Controls;
using System.Drawing.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace projeto_sala_petshop
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            // Configurando a ordem do Tab
            tb_acesso.TabIndex = 0;  
            tb_senha_log.TabIndex = 1; 
            bt_login.TabIndex = 2;  
        }

        private void exibirForm(Menu menu)
        {
            menu.Show();
            menu.Activate();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            
            string usuario = tb_acesso.Text;
            string senha = tb_senha_log.Text;

                Connection cn = new Connection();

                try
                {
                    cn.conn.Open();

                    // Query com parâmetros para evitar SQL Injection
                    string query = "SELECT nome_usuario, nivel_acesso, sexo FROM usuarios WHERE nome_usuario COLLATE Latin1_General_CS_AS = @Usuario AND senha_usuario COLLATE Latin1_General_CS_AS = @Senha";

                    using (SqlCommand cmd = new SqlCommand(query, cn.conn))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@Senha", senha);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nomeUsuario = reader["nome_usuario"].ToString();
                                string nivelAcesso = reader["nivel_acesso"].ToString();
                                string sexoUsuario = reader["sexo"].ToString();

                                MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Menu menu = Menu.getInstance();
                                menu.DefinirAcesso(nivelAcesso, sexoUsuario, nomeUsuario);

                                exibirForm(menu);
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Usuário ou senha inválido.", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao conectar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            tb_senha_log.UseSystemPasswordChar = !tb_senha_log.UseSystemPasswordChar;

            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            tb_senha_log.UseSystemPasswordChar = !tb_senha_log.UseSystemPasswordChar;

            pictureBox6.Visible = false;
            pictureBox5.Visible = true;
        }



    }
}



