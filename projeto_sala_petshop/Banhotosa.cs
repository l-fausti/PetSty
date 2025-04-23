using Microsoft.Data.SqlClient;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_sala_petshop
{
    public partial class Banhotosa : Form
    {
        public Banhotosa()
        {
            InitializeComponent();
        }

        public void Esconderpes()
        {
            this.lb_cad_clientes.Visible = false;
            this.gb_cad_clientes_bant.Visible = false;
            this.bt_avancar_bant.Visible = true;
        }

        //primeiro clique
        private void cyberRadioButton2_Click(object sender, EventArgs e)
        {
            this.lb_cad_clientes.Visible = true;
            this.gb_cad_clientes_bant.Visible = true;
            this.bt_avancar_bant.Visible = true;

            //segundo clique
            if (cyberRadioButton2.Checked == true)
            {
                Esconderpes();
            }
            if (cyberRadioButton1.Checked == true)
            {
                this.cyberRadioButton2.Enabled = true;
                this.cyberRadioButton2.Checked = true;
                Esconderpes();
            }
        }

        //check box de cadastro
        public void Exibircad()
        {
            this.gb_pes_clientes.Visible = false;
            this.tb_pet_search_bant.Visible = false;
            this.tb_pet_reg_search_bant.Visible = false;
            this.dataGridViewBant.Visible = false;
            this.bt_search.Visible = false;
            this.bt_avancar_bant.Visible = true;
            this.lb_pes_bant.Visible = false;
            this.bt_limpar_pes_clientes_bant.Visible = false;
        }

        public void Exibirpes()
        {
            this.gb_pes_clientes.Visible = true;
            this.tb_pet_search_bant.Visible = true;
            this.tb_pet_reg_search_bant.Visible = true;
            this.dataGridViewBant.Visible = true;
            this.bt_search.Visible = true;
            this.bt_avancar_bant.Visible = true;
            this.lb_pes_bant.Visible = true;
            this.bt_limpar_pes_clientes_bant.Visible = true;
        }

        private void cyberRadioButton1_Click(object sender, EventArgs e)
        {
            Exibirpes();

            if (cyberRadioButton1.Checked == true)
            {
                Exibircad();
            }
            if (cyberRadioButton2.Checked == true)
            {
                this.cyberRadioButton1.Enabled = true;
                this.cyberRadioButton1.Checked = true;
                Exibircad();
            }
        }

        private void bt_voltar_servicos_Click(object sender, EventArgs e)
        {
            pn_banho_tosa.Controls.Clear();
            Servicos servicos = new Servicos() { TopLevel = false, TopMost = true };
            servicos.FormBorderStyle = FormBorderStyle.None;
            pn_banho_tosa.Controls.Add(servicos);
            servicos.Show();
        }

        private void bt_cadastrar_cliente_ban_Click(object sender, EventArgs e)
        {
            string pet = tb_nome_pet_bant.Text, especie = cb_especie_bant.Text, porte = cb_porte_bant.Text,
            raca = tb_raca_bant.Text, responsavel = tb_responsavel_bant.Text, emailBant = tb_email_bant.Text,
            celularBant = mtb_celular_bant.Text, bairro = tb_bairro_bant.Text, endereco = tb_endereco_bant.Text,
            complementoRes = tb_complemento_res_bant.Text, numeroRes = mtb_numero_res_bant.Text;


            if (string.IsNullOrWhiteSpace(pet) || string.IsNullOrWhiteSpace(especie) ||
            string.IsNullOrWhiteSpace(porte) || string.IsNullOrWhiteSpace(responsavel) ||
            string.IsNullOrWhiteSpace(emailBant) || string.IsNullOrWhiteSpace(celularBant) ||
            string.IsNullOrWhiteSpace(endereco) || string.IsNullOrWhiteSpace(bairro) ||
            string.IsNullOrWhiteSpace(numeroRes))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Validação de Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Interrompe a execução se houver campos vazios
            }

            string validacaoEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(tb_email_bant.Text, validacaoEmail))
            {
                MessageBox.Show("Por favor, insira um e-mail válido.", "Validação de Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_email_bant.Focus();
                return;
            }
            string validacaoCelular = @"^\(\d{2}\)\s?\d{4,5}-\d{4}$";
            if (!Regex.IsMatch(mtb_celular_bant.Text, validacaoCelular))
            {
                MessageBox.Show("Por favor, insira um número de celular válido.", "Validação de Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtb_celular_bant.Focus();
                return;
            }

            Connection cn = new Connection();

            string insertQuery = "insert into usuarios (nome_pet,especie,porte,raca,responsavel,email_usuario,cel_usuario," +
            "bairro,endereco,numero_endereco,complemento_endereco) values (@nome_pet,@especie,@porte,@raca,@responsavel," +
            "@email_usuario,@cel_usuario,@bairro,@endereco,@numero_endereco,@complemento_endereco);" +
            "SELECT CAST(scope_identity()AS int)";

            cn.conn.Open();
            SqlCommand insertCmd = new SqlCommand(insertQuery, cn.conn);
            insertCmd.Parameters.AddWithValue("@nome_pet", pet); insertCmd.Parameters.AddWithValue("@especie", especie);
            insertCmd.Parameters.AddWithValue("@porte", porte); insertCmd.Parameters.AddWithValue("@raca", raca);
            insertCmd.Parameters.AddWithValue("@responsavel", responsavel); insertCmd.Parameters.AddWithValue("@email_usuario", emailBant);
            insertCmd.Parameters.AddWithValue("@cel_usuario", celularBant); insertCmd.Parameters.AddWithValue("@bairro", bairro);
            insertCmd.Parameters.AddWithValue("@endereco", endereco); insertCmd.Parameters.AddWithValue("@numero_endereco", numeroRes);
            insertCmd.Parameters.AddWithValue("@complemento_endereco", complementoRes);

            Bantosa bantosa = new Bantosa();


            int lastId = (int)insertCmd.ExecuteScalar();
            if (lastId > 0)
            {
                MessageBox.Show($"Cadastro efetuado com sucesso! \r\nNúmero de Registro: {lastId}",
                    "Cadastro bem sucedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bantosa.tb_numero_registro_bant.Text = $"{lastId}";
            }

            else
            {
                MessageBox.Show("Erro ao cadastrar cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cn.conn.Close();


        }

        private void bt_limpar_bent_Click(object sender, EventArgs e)
        {
            tb_nome_pet_bant.Clear(); tb_raca_bant.Clear(); tb_responsavel_bant.Clear(); tb_email_bant.Clear();
            mtb_celular_bant.Clear(); tb_bairro_bant.Clear(); tb_endereco_bant.Clear();
            tb_complemento_res_bant.Clear(); mtb_numero_res_bant.Clear();

            cb_especie_bant.SelectedIndex = -1;
            cb_porte_bant.SelectedIndex = -1;
        }

        private void bt_avancar_Click(object sender, EventArgs e)
        {
            pn_banho_tosa.Controls.Clear();
            Bantosa bantosa = new Bantosa() { TopLevel = false, TopMost = true };
            bantosa.FormBorderStyle = FormBorderStyle.None;
            pn_banho_tosa.Controls.Add(bantosa);
            bantosa.Show();
        }

        private void tb_pet_reg_search_bant_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_search_bent_Click(object sender, EventArgs e)
        {
            string nome_pet = tb_pet_search_bant.Text;
            int numeroRegistro = int.Parse(tb_pet_reg_search_bant.Text);

            DataTable dt = new DataTable();

            Connection cn = new Connection();
            cn.conn.Open();

            string selectQuery = "select id_usuario AS numero_registro, nome_pet, especie, porte, raca, responsavel, " +
                                 "email_usuario AS email_responsavel, cel_usuario AS celular_responsavel, bairro, endereco, " +
                                 "numero_endereco, complemento_endereco " +
                                 "from usuarios " +
                                 "where nome_pet = @NomePet AND id_usuario = @IdUsuario";

            SqlCommand cmd = new SqlCommand(selectQuery, cn.conn);
            cmd.Parameters.AddWithValue("@NomePet", nome_pet);
            cmd.Parameters.AddWithValue("@IdUsuario", numeroRegistro);

            SqlDataReader reader = cmd.ExecuteReader();

            
            dt.Load(reader);

            reader.Close();
            cn.conn.Close();
 
            dataGridViewBant.DataSource = dt;

            if(tb_pet_search_bant.Text == null && tb_pet_reg_search_bant.Text == null)
            {
                MessageBox.Show("Preencha todos os campos para efetuar a busca", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_limpar_pes_clientes_Click(object sender, EventArgs e)
        {
            tb_pet_search_bant.Clear();
            tb_pet_reg_search_bant.Clear();
            dataGridViewBant.DataSource = "";
        }

        private void cyberRadioButton1_Load(object sender, EventArgs e)
        {

        }

        private void Banhotosa_Load(object sender, EventArgs e)
        {

        }

        private void lb_pes_bant_Click(object sender, EventArgs e)
        {

        }

        private void pn_banho_tosa_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
