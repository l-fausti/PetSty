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
    public partial class Gerenciar : Form
    {
        public Gerenciar()
        {
            InitializeComponent();
        }

        private void bt_cadastro_usuarios_Click(object sender, EventArgs e)
        {
            panel_gerenciar_usuarios.Controls.Clear();
            Cadusuarios cadusuarios = new Cadusuarios() { TopLevel = false, TopMost = true };
            cadusuarios.FormBorderStyle = FormBorderStyle.None;
            panel_gerenciar_usuarios.Controls.Add(cadusuarios);
            cadusuarios.Show();
        }

        private void bt_registro_usuarios_Click(object sender, EventArgs e)
        {
            panel_gerenciar_usuarios.Controls.Clear();
            Registrousuarios RegisUser = new Registrousuarios() { TopLevel = false, TopMost = true };
            RegisUser.FormBorderStyle = FormBorderStyle.None;
            panel_gerenciar_usuarios.Controls.Add(RegisUser);
            RegisUser.Show();
        }
    }
}
