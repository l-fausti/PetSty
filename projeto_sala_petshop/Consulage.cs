using Microsoft.Data.SqlClient;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_sala_petshop
{
    public partial class Consulage : Form
    {
        public Consulage()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel_consulage.Controls.Clear();
            Consultavet consultasvet = new Consultavet() { TopLevel = false, TopMost = true };
            consultasvet.FormBorderStyle = FormBorderStyle.None;
            panel_consulage.Controls.Add(consultasvet);
            consultasvet.Show();
            consultasvet.lb_cad_clientes.Visible = false;
            consultasvet.gb_cad_clientes.Visible = false;
            consultasvet.bt_avancar.Visible = false;
        }

        private void cb_motivo_consulta_SelectedIndexChanged(object sender, EventArgs e)
        {

            string motivoConsulta = cb_motivo_consulta.Text;
            decimal valor;


            switch (motivoConsulta)
            {
                case "Vacinação":
                    valor = 180.00m;
                    break;
                case "Check-up":
                    valor = 150.00m;
                    break;
                case "Doença":
                    valor = 200.00m;
                    break;
                case "Castração":
                    valor = 350.00m;
                    break;
                case "Acidente":
                    valor = 250.00m;
                    break;
                default:
                    valor = 0.00m;

                    break;
            }

            tb_valor.Text = valor.ToString("N2");

        }

        private void bt_agendamento_vet_Click(object sender, EventArgs e)
        {
            string numeroRegistro = tb_numero_registro.Text; string motivoConsulta = cb_motivo_consulta.Text;
            string veterinario = cb_vet_responsavel.Text; string data = dt_agendamento.Text;
            DateTime dataSelecionada = dt_agendamento.Value;


            if (string.IsNullOrWhiteSpace(numeroRegistro) || string.IsNullOrWhiteSpace(dt_agendamento.Text) || string.IsNullOrWhiteSpace(motivoConsulta) ||
                string.IsNullOrWhiteSpace(veterinario))
            {
                MessageBox.Show("Por favor, preencha todos os campos e selecione os dados.", "Validação de Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (dataSelecionada < DateTime.Today)
            {
                MessageBox.Show("A data selecionada não pode ser menor que a data atual.", "Data Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt_agendamento.Value = DateTime.Today;

            }
            else
            {
                tb_confirm_consulta.Text = $"NR do pet: {numeroRegistro} \r\nMotivo da consulta: {motivoConsulta} \r\nVeterinário responsável: {veterinario}" +
                $"\r\nData de agendamento: {data} \r\nValor da consulta: {tb_valor.Text}";
            }

        }

        private void bt_confirmar_vet_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja confirmar a consulta?", "Confirmação", MessageBoxButtons.YesNo);


            try
            {
                if (resultado == DialogResult.Yes)
                {

                    CultureInfo cultura = new CultureInfo("pt-BR");
                    string numeroRegistro = tb_numero_registro.Text;
                    int identityServ = 1;
                    string motivoConsulta = cb_motivo_consulta.Text;
                    string veterinario = cb_vet_responsavel.Text;
                    DateTime data = DateTime.Parse(dt_agendamento.Text, cultura);
                    decimal valor = decimal.Parse(tb_valor.Text, cultura);

                    if (string.IsNullOrWhiteSpace(numeroRegistro) || string.IsNullOrWhiteSpace(motivoConsulta) ||
                    string.IsNullOrWhiteSpace(veterinario) || valor == 0 ||
                    string.IsNullOrWhiteSpace(dt_agendamento.Text))
                    {
                        MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Validação de Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Interrompe a execução se houver campos vazios
                    }


                    Connection cn = new Connection();
                    cn.conn.Open();

                    //Verifica se já existe alguma consulta agendada
                    string selectQuery = "select count(1) from agendamentos where id_usuario = @id_usuario";

                    SqlCommand checkCmd = new SqlCommand(selectQuery, cn.conn);
                    checkCmd.Parameters.AddWithValue("@id_usuario", numeroRegistro);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Já existe consulta marcada para esse Número de Registro.", "Consulta já Existente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        //Cadastro de consulta caso não haja nenhum agendamento para o número de registro específico
                        string insertQuery = "insert into agendamentos (id_usuario,id_servico,motivo,profissional_responsavel,data_hora,preco_agend)" +
                            "values (@id_usuario,@id_servico,@motivo,@profissional_responsavel,@data_hora,@preco_agend)";


                        SqlCommand cmd = new SqlCommand(insertQuery, cn.conn);

                        cmd.Parameters.AddWithValue("@id_usuario", numeroRegistro);
                        cmd.Parameters.AddWithValue("@motivo", motivoConsulta);
                        cmd.Parameters.AddWithValue("@profissional_responsavel", veterinario);
                        cmd.Parameters.AddWithValue("@data_hora", data);
                        cmd.Parameters.AddWithValue("@preco_agend", valor);
                        cmd.Parameters.AddWithValue("@id_servico", identityServ);


                        int newRegis = (int)cmd.ExecuteNonQuery();
                        if (newRegis > 0)
                        {
                            MessageBox.Show("Consulta agendada com sucesso!", "Consulta Confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tb_numero_registro.Clear();
                            dt_agendamento.Text = "";
                            tb_valor.Clear();
                            cb_motivo_consulta.SelectedIndex = -1;
                            cb_vet_responsavel.SelectedIndex = -1;
                            tb_confirm_consulta.Text = "";
                        }

                        cn.conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Operação cancelada");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("O Número de Registro informado não existe", "ID não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void bt_limpar_vet_Click(object sender, EventArgs e)
        {
            tb_numero_registro.Clear();
            dt_agendamento.Text = "";
            tb_valor.Clear();
            cb_motivo_consulta.SelectedIndex = -1;
            cb_vet_responsavel.SelectedIndex = -1;
        }

        private void bt_cancelar_vet_Click(object sender, EventArgs e)
        {
            tb_confirm_consulta.Text = "";
        }

        private void tb_numero_registro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloqueia o caractere
            }
            if (tb_numero_registro.Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Impede digitar mais de 5 caracteres
            }
        }

        private void cb_vet_responsavel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}