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
    public partial class Servicos : Form
    {
        public Servicos()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel_servicos.Controls.Clear();
            Consultavet consultasvet = new Consultavet() { TopLevel = false, TopMost = true };
            consultasvet.FormBorderStyle = FormBorderStyle.None;
            panel_servicos.Controls.Add(consultasvet);
            consultasvet.Show();
            consultasvet.lb_cad_clientes.Visible = false;
            consultasvet.gb_cad_clientes.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_servicos.Controls.Clear();
            Banhotosa banho_tosa = new Banhotosa() { TopLevel = false, TopMost = true };
            banho_tosa.FormBorderStyle = FormBorderStyle.None;
            panel_servicos.Controls.Add(banho_tosa);
            banho_tosa.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_servicos.Controls.Clear();
            Adocao adocao = new Adocao() { TopLevel = false, TopMost = true };
            adocao.FormBorderStyle = FormBorderStyle.None;
            panel_servicos.Controls.Add(adocao);
            adocao.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel_servicos.Controls.Clear();
            Treinamento treinamento = new Treinamento() { TopLevel = false, TopMost = true };
            treinamento.FormBorderStyle = FormBorderStyle.None;
            panel_servicos.Controls.Add(treinamento);
            treinamento.Show();
        }
    }
}
