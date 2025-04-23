using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;
using System.Drawing.Design;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices.Marshalling;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace projeto_sala_petshop
{

    public partial class Consultavet : Form
    {

        public Consultavet()
        {
            InitializeComponent();
        }

        public void Esconderpes()
        {
            this.lb_cad_clientes.Visible = false;
            this.gb_cad_clientes.Visible = false;
            this.bt_avancar.Visible = true;
        }

        //Não
        private void cyberCheckBox2_Click(object sender, EventArgs e)
        {
            //primeiro clique
            this.lb_cad_clientes.Visible = true;
            this.gb_cad_clientes.Visible = true;
            this.bt_avancar.Visible = true;

            //segundo clique
            if (cyberCheckBox2.Checked == true)
            {
                Esconderpes();
            }

            if (cyberCheckBox1.Checked == true)
            {
                this.cyberCheckBox2.Enabled = true;
                this.cyberCheckBox2.Checked = true;
                Esconderpes();
            }
        }

        //check box de cadastro
        public void Exibircad()
        {
            this.gb_pes_clientes.Visible = false;
            this.tb_pet_search.Visible = false;
            this.tb_pet_reg_search.Visible = false;
            this.dataGridView1.Visible = false;
            this.bt_search.Visible = false;
            this.bt_avancar.Visible = true;
            this.lb_pes.Visible = false;
            this.bt_limpar_pes_clientes.Visible = false;
        }

        public void Exibirpes()
        {
            this.gb_pes_clientes.Visible = true;
            this.tb_pet_search.Visible = true;
            this.tb_pet_reg_search.Visible = true;
            this.dataGridView1.Visible = true;
            this.bt_search.Visible = true;
            this.bt_avancar.Visible = true;
            this.lb_pes.Visible = true;
            this.bt_limpar_pes_clientes.Visible = true;
        }

        private void cyberCheckBox1_Click(object sender, EventArgs e)
        {
            Exibirpes();

            if (cyberCheckBox1.Checked)
            {
                Exibircad();
            }

            if (cyberCheckBox2.Checked)
            {
                this.cyberCheckBox1.Enabled = true;
                this.cyberCheckBox1.Checked = true;
                Exibircad();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pn_consulta_vet.Controls.Clear();
            Servicos servicos = new Servicos() { TopLevel = false, TopMost = true };
            servicos.FormBorderStyle = FormBorderStyle.None;
            pn_consulta_vet.Controls.Add(servicos);
            servicos.Show();
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            string pet = tb_nome_pet.Text, especie = cb_especie.Text, porte = cb_porte.Text,
            raca = tb_raca.Text, responsavel = tb_nome_responsavel.Text, emailVet = tb_email_vet.Text,
            celularVet = mtb_celular_vet.Text, bairro = tb_bairro_vet.Text, endereco = tb_endereco_vet.Text,
            complementoRes = tb_complemento_res.Text, numeroRes = mtb_numero_res.Text;


            if (string.IsNullOrWhiteSpace(pet) || string.IsNullOrWhiteSpace(especie) ||
            string.IsNullOrWhiteSpace(porte) || string.IsNullOrWhiteSpace(responsavel) ||
            string.IsNullOrWhiteSpace(emailVet) || string.IsNullOrWhiteSpace(celularVet) ||
            string.IsNullOrWhiteSpace(bairro) || string.IsNullOrWhiteSpace(endereco) ||
            string.IsNullOrWhiteSpace(numeroRes))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Validação de Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Interrompe a execução se houver campos vazios
            }

            string validacaoEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(tb_email_vet.Text, validacaoEmail))
            {
                MessageBox.Show("Por favor, insira um e-mail válido.", "Validação de Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_email_vet.Focus();
                return;
            }
            string validacaoCelular = @"^\(\d{2}\)\s?\d{4,5}-\d{4}$";
            if (!Regex.IsMatch(mtb_celular_vet.Text, validacaoCelular))
            {
                MessageBox.Show("Por favor, insira um número de celular válido.", "Validação de Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtb_celular_vet.Focus();
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
            insertCmd.Parameters.AddWithValue("@responsavel", responsavel); insertCmd.Parameters.AddWithValue("@email_usuario", emailVet);
            insertCmd.Parameters.AddWithValue("@cel_usuario", celularVet); insertCmd.Parameters.AddWithValue("@bairro", bairro);
            insertCmd.Parameters.AddWithValue("@endereco", endereco); insertCmd.Parameters.AddWithValue("@numero_endereco", numeroRes);
            insertCmd.Parameters.AddWithValue("@complemento_endereco", complementoRes);

            Consulage consulage = new Consulage();

            int lastId = (int)insertCmd.ExecuteScalar();
            if (lastId > 0)
            {
                MessageBox.Show($"Cadastro efetuado com sucesso! Número de Registro: {lastId}",
                    "Cadastro bem sucedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                consulage.tb_numero_registro.Text = $"{lastId}";
                //"Numero de Registro:" + reader["id_usuario"].ToString(), "Validação Correta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //bt_limpar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cn.conn.Close();
        }

        private void bt_avancar_Click(object sender, EventArgs e)
        {
            pn_consulta_vet.Controls.Clear();
            Consulage consulage = new Consulage() { TopLevel = false, TopMost = true };
            consulage.FormBorderStyle = FormBorderStyle.None;
            pn_consulta_vet.Controls.Add(consulage);
            consulage.Show();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_nome_pet.Clear(); tb_raca.Clear(); tb_nome_responsavel.Clear(); tb_email_vet.Clear(); mtb_celular_vet.Clear();
            tb_endereco_vet.Clear(); tb_complemento_res.Clear(); mtb_numero_res.Clear(); tb_bairro_vet.Clear();

            cb_especie.SelectedIndex = -1;
            cb_porte.SelectedIndex = -1;
        }

        private void bt_search_Click(object sender, EventArgs e)
        {

            string nome_pet = tb_pet_search.Text;
            string numeroRegistroStr = tb_pet_reg_search.Text;
            int numeroRegistro;

            
            if (string.IsNullOrWhiteSpace(nome_pet) || !int.TryParse(numeroRegistroStr, out numeroRegistro) || numeroRegistro <= 0)
            {
                MessageBox.Show("Preencha todos os campos corretamente para efetuar a busca", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            DataTable dt = new DataTable();
            Connection cn = new Connection();

            try
            {
                cn.conn.Open();

                string selectQuery = "SELECT id_usuario AS numero_registro, nome_pet, especie, porte, raca, responsavel, " +
                                     "email_usuario AS email_responsavel, cel_usuario AS celular_responsavel, bairro, endereco, " +
                                     "numero_endereco, complemento_endereco " +
                                     "FROM usuarios " +
                                     "WHERE nome_pet = @NomePet AND id_usuario = @IdUsuario";

                using (SqlCommand cmd = new SqlCommand(selectQuery, cn.conn))
                {
                    cmd.Parameters.AddWithValue("@NomePet", nome_pet);
                    cmd.Parameters.AddWithValue("@IdUsuario", numeroRegistro);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.conn.Close();
            }

            dataGridView1.DataSource = dt;

        }

        private void bt_limpar_pes_clientes_Click(object sender, EventArgs e)
        {
            tb_pet_search.Clear();
            tb_pet_reg_search.Clear();
            dataGridView1.DataSource = "";
        }

        private void tb_pet_reg_search_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloqueia o caractere
            }
            if (tb_pet_reg_search.Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Impede digitar mais de 5 caracteres
            }

        }

        private void gb_pes_clientes_Enter(object sender, EventArgs e)
        {

        }

        private void cyberCheckBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
