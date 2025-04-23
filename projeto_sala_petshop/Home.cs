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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        public void DefinirAcesso(string sexoUsuario)
        {

            if (sexoUsuario == "F")
            {
                pb_5.Image = Image.FromFile(@"C:\Users\Lucas\source\repos\PI_petsty\projeto_sala_petshop\projeto_sala_petshop\imagens\user_f.png");
            }
            else if (sexoUsuario == "M")
            {
                pb_5.Image = Image.FromFile(@"C:\Users\Lucas\source\repos\PI_petsty\projeto_sala_petshop\projeto_sala_petshop\imagens\user_m.png");
            }
            else
            {
                pb_5.Image = null; // Define como null se não encontrar a imagem
            }

        }
        public void DefinirDadosUsuario(string mensagem, Image imagemUsuario)
        {
            foxBigLabel1.Text = mensagem; // Assume que você tem um Label chamado lblMensagem no Home
            pb_5.Image = imagemUsuario; // Assume que tem um PictureBox chamado pbUsuario
        }


        private void panel_home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pb_5_Click(object sender, EventArgs e)
        {

        }
    }
}
