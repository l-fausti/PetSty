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
    public partial class Menu : Form
    {

        public static Menu instance;

        public static Menu getInstance()
        {
            if (instance == null)
            {
                instance = new Menu();
            }

            return instance;
        }
        public Menu()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();

            // Fecha a instância atual do menu
            this.Close();

            // Reseta a instância do Menu para evitar problemas ao logar novamente
            instance = null;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel_home.Controls.Clear();

            Home home = new Home() { TopLevel = false, TopMost = true };
            home.FormBorderStyle = FormBorderStyle.None;

            // Passando os dados do usuário para o formulário Home
            home.DefinirDadosUsuario(lblBemVindo.Text, pb_5.Image);

            panel_home.Controls.Add(home);
            home.Show();
        }


        private void button12_Click(object sender, EventArgs e)
        {
            panel_home.Controls.Clear();
            Servicos servicos = new Servicos() { TopLevel = false, TopMost = true };
            servicos.FormBorderStyle = FormBorderStyle.None;
            panel_home.Controls.Add(servicos);
            servicos.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            panel_home.Focus();
            panel_home.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel_home.Controls.Clear();
            Gerenciar gerenciar = new Gerenciar() { TopLevel = false, TopMost = true };
            gerenciar.FormBorderStyle = FormBorderStyle.None;
            panel_home.Controls.Add(gerenciar);
            gerenciar.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel_home.Controls.Clear();
            Produtos produtos = new Produtos() { TopLevel = false, TopMost = true };
            produtos.FormBorderStyle = FormBorderStyle.None;
            panel_home.Controls.Add(produtos);
            produtos.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel_home.Controls.Clear();
            Consultas consultas = new Consultas() { TopLevel = false, TopMost = true };
            consultas.FormBorderStyle = FormBorderStyle.None;
            panel_home.Controls.Add(consultas);
            consultas.Show();
        }

        public void DefinirAcesso(string nivelAcesso, string sexoUsuario, string nomeUsuario)
        {
            // Ocultar botão "Gerenciar Usuários" para usuários comuns
            button5.Visible = (nivelAcesso == "Admin");
            bt_alterar_senha.Visible = (nivelAcesso == "Comum");

            // Alterar a imagem do usuário conforme o sexo
            if (sexoUsuario == "F")
            {
                pb_5.Image = Image.FromFile(@"C:\Users\Lucas\source\repos\final\projeto_ATUALIZADO_petsty\projeto_sala_petshop\projeto_sala_petshop\imagens\user_f.png");
                lblBemVindo.Text = $"Bem-vinda, {nomeUsuario}!";
            }
            else if (sexoUsuario == "M")
            {
                pb_5.Image = Image.FromFile(@"C:\Users\Lucas\source\repos\final\projeto_ATUALIZADO_petsty\projeto_sala_petshop\projeto_sala_petshop\imagens\user_m.png");
                lblBemVindo.Text = $"Bem-vindo, {nomeUsuario}!";
            }
        }





        private void bt_alterar_senha_Click(object sender, EventArgs e)
        {
            panel_home.Controls.Clear();
            Alterarsenha alterarsenha = new Alterarsenha() { TopLevel = false, TopMost = true };
            alterarsenha.FormBorderStyle = FormBorderStyle.None;
            panel_home.Controls.Add(alterarsenha);
            alterarsenha.Show();
        }
    }
}
