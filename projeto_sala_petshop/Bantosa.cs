using Microsoft.Data.SqlClient;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace projeto_sala_petshop
{
    public partial class Bantosa : Form
    {
        public Bantosa()
        {
            InitializeComponent();
        }

        private void tb_numero_registro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (tb_numero_registro_bant.Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bt_agendamento_bant_Click(object sender, EventArgs e)
        {
            string numRegistroBant = tb_numero_registro_bant.Text; string tipoTosa = cb_tipo_tosa_bant.Text;
            string banResponsavel = cb_ban_responsavel_bant.Text; string dataAgendamentoBant = dt_agendamento_bant.Text;

            DateTime dataSelecionada = dt_agendamento_bant.Value;


            if (string.IsNullOrWhiteSpace(numRegistroBant) || string.IsNullOrWhiteSpace(dt_agendamento_bant.Text) || string.IsNullOrWhiteSpace(tipoTosa) ||
                string.IsNullOrWhiteSpace(banResponsavel))
            {
                MessageBox.Show("Por favor, preencha todos os campos e selecione os dados.", "Validação de Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (dataSelecionada < DateTime.Today)
            {
                MessageBox.Show("A data selecionada não pode ser menor que a data atual.", "Data Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt_agendamento_bant.Value = DateTime.Today;

            }
            else
            {
                tb_confirm_consulta_bant.Text = $"NR do pet: {numRegistroBant} \r\nTipo de Tosa: {tipoTosa} " +
                $"\r\nBanhista responsável: {banResponsavel}\r\nData de agendamento: {dataAgendamentoBant} " +
                $"\r\nValor da consulta: {tb_valor_bant.Text}";
            }
        }

        private void bt_limpar_bant_Click(object sender, EventArgs e)
        {
            tb_numero_registro_bant.Clear();
            tb_valor_bant.Clear();
            cb_tipo_tosa_bant.SelectedIndex = -1;
            cb_ban_responsavel_bant.SelectedIndex = -1;
            dt_agendamento_bant.Text = "";
        }

        private void cb_tipo_tosa_bant_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoTosa = cb_tipo_tosa_bant.Text;
            decimal valor;


            switch (tipoTosa)
            {
                case "Tosa Higiênica":
                    valor = 50.00m;
                    break;
                case "Tosa na Tesoura":
                    valor = 80.00m;
                    break;
                case "Tosa na Máquina":
                    valor = 40.00m;
                    break;
                case "Tosa Bebê":
                    valor = 60.00m;
                    break;
                case "Tosa Verão":
                    valor = 50.00m;
                    break;
                default:
                    valor = 0.00m;

                    break;
            }

            tb_valor_bant.Text = valor.ToString("N2");
        }

        private void bt_confirmar_bant_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja confirmar a tosa?", "Confirmação", MessageBoxButtons.YesNo);


            try
            {
                if (resultado == DialogResult.Yes)
                {

                    CultureInfo cultura = new CultureInfo("pt-BR");
                    int identityServ = 2;
                    string numRegistroBant = tb_numero_registro_bant.Text;
                    string tipoTosa = cb_tipo_tosa_bant.Text;
                    string banResponsavel = cb_ban_responsavel_bant.Text;
                    DateTime dataAgendamentoBant = DateTime.Parse(dt_agendamento_bant.Text, cultura);
                    decimal valor_bant = decimal.Parse(tb_valor_bant.Text, cultura);

                    if (string.IsNullOrWhiteSpace(numRegistroBant) || string.IsNullOrWhiteSpace(tipoTosa) ||
                    string.IsNullOrWhiteSpace(banResponsavel) || valor_bant == 0 ||
                    string.IsNullOrWhiteSpace(dt_agendamento_bant.Text))
                    {
                        MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Validação de Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Interrompe a execução se houver campos vazios
                    }

                    Connection cn = new Connection();
                    cn.conn.Open();

                    //Verifica se já existe alguma consulta agendada
                    string selectQuery = "select count(1) from agendamentos where id_usuario = @id_usuario";

                    SqlCommand checkCmd = new SqlCommand(selectQuery, cn.conn);
                    checkCmd.Parameters.AddWithValue("@id_usuario", numRegistroBant);

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

                        cmd.Parameters.AddWithValue("@id_usuario", numRegistroBant); cmd.Parameters.AddWithValue("@motivo", tipoTosa);
                        cmd.Parameters.AddWithValue("@profissional_responsavel", banResponsavel); cmd.Parameters.AddWithValue("@data_hora", dataAgendamentoBant);
                        cmd.Parameters.AddWithValue("@preco_agend", valor_bant); cmd.Parameters.AddWithValue("@id_servico", identityServ);


                        int newRegis = (int)cmd.ExecuteNonQuery();
                        if (newRegis > 0)
                        {
                            MessageBox.Show("Consulta agendada com sucesso!", "Consulta Confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tb_numero_registro_bant.Clear();
                            dt_agendamento_bant.Text = "";
                            tb_valor_bant.Clear();
                            cb_tipo_tosa_bant.SelectedIndex = -1;
                            cb_ban_responsavel_bant.SelectedIndex = -1;
                            tb_confirm_consulta_bant.Text = "";
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

        private void bt_cancelar_bant_Click(object sender, EventArgs e)
        {
            tb_confirm_consulta_bant.Text = "";
        }

        private void bt_voltar_bant_Click(object sender, EventArgs e)
        {
            panel_bantosa.Controls.Clear();
            Banhotosa banhotosa = new Banhotosa() { TopLevel = false, TopMost = true };
            banhotosa.FormBorderStyle = FormBorderStyle.None;
            panel_bantosa.Controls.Add(banhotosa);
            banhotosa.Show();
            banhotosa.lb_pes_bant.Visible = false;
            banhotosa.gb_cad_clientes_bant.Visible = false;
            banhotosa.bt_avancar_bant.Visible = false;
        }
    }
}
