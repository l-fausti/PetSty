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
    public partial class Produtos : Form
    {
        public Connection cn;
        public SqlCommand cmd;
        public String query;
        public Produtos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Buscarprodutos buscarprodutos = new Buscarprodutos() { TopLevel = false, TopMost = true };
            buscarprodutos.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(buscarprodutos);
            buscarprodutos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Adicionarprodutos adicionarprodutos = new Adicionarprodutos() { TopLevel = false, TopMost = true };
            adicionarprodutos.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(adicionarprodutos);
            adicionarprodutos.Show();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {

        }
    }
}
