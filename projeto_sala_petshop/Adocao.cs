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
    public partial class Adocao : Form
    {
        public Adocao()
        {
            InitializeComponent();
        }

        private void bt_adote_agora_Click(object sender, EventArgs e)
        {
            pn_adocao.Controls.Clear();
            Adoteagora adoteagora = new Adoteagora() { TopLevel = false, TopMost = true };
            adoteagora.FormBorderStyle = FormBorderStyle.None;
            pn_adocao.Controls.Add(adoteagora);
            adoteagora.Show();
        }

        private void bt_cad_pets_Click(object sender, EventArgs e)
        {
            pn_adocao.Controls.Clear();
            Cadastrodepets cadpets = new Cadastrodepets() { TopLevel = false, TopMost = true };
            cadpets.FormBorderStyle = FormBorderStyle.None;
            pn_adocao.Controls.Add(cadpets);
            cadpets.Show();
        }

        private void bt_voltar_servicos_Click(object sender, EventArgs e)
        {         
            pn_adocao.Controls.Clear();
            Servicos servicos = new Servicos() { TopLevel = false, TopMost = true };
            servicos.FormBorderStyle = FormBorderStyle.None;
            pn_adocao.Controls.Add(servicos);
            servicos.Show();
        }

        private void pn_adocao_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
