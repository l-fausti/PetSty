using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_sala_petshop
{
    public partial class Consultas : Form
    {
        public string servicos { get; set; }
        public string tipos { get; set; }
        public string profissional_responsavel { get; set; }

        public string categoriaSelecionada { get; set; }
        public string tipoSelecionado { get; set; }
        public string profissionalSelecionado { get; set; }

        public string selectQueryVac { get; set; }

        public DataTable dt = new DataTable();

        public Consultas()
        {
            InitializeComponent();
        }

        public void consulta_veterinaria()
        {
            cb_tipo.Items.Add("");
            cb_tipo.Items.Add("Vacinação");
            cb_tipo.Items.Add("Check-up");
            cb_tipo.Items.Add("Doença");
            cb_tipo.Items.Add("Castração");
            cb_tipo.Items.Add("Acidente");
            cb_profissional_responsavel.Items.Add("");
            cb_profissional_responsavel.Items.Add("Carlos");
            cb_profissional_responsavel.Items.Add("Guilherme");
            cb_profissional_responsavel.Items.Add("Lucas");
            cb_profissional_responsavel.Items.Add("Nicollas");
            cb_profissional_responsavel.Items.Add("Samuel");
            cb_profissional_responsavel.Items.Add("Stephanie");
        }

        public void banho_tosa()
        {
            cb_tipo.Items.Add("");
            cb_tipo.Items.Add("Tosa Higiênica");
            cb_tipo.Items.Add("Tosa na Tesoura");
            cb_tipo.Items.Add("Tosa na Máquina");
            cb_tipo.Items.Add("Tosa Bebê");
            cb_tipo.Items.Add("Tosa Verão");
            cb_profissional_responsavel.Items.Add("");
            cb_profissional_responsavel.Items.Add("Carlos");
            cb_profissional_responsavel.Items.Add("Guilherme");
            cb_profissional_responsavel.Items.Add("Lucas");
            cb_profissional_responsavel.Items.Add("Nicollas");
            cb_profissional_responsavel.Items.Add("Samuel");
            cb_profissional_responsavel.Items.Add("Stephanie");
        }

        public void adocao()
        {
            cb_tipo.Items.Add("");
            cb_tipo.Items.Add("Cachorro");
            cb_tipo.Items.Add("Gato");
            cb_tipo.Items.Add("Coelho");
            cb_tipo.Items.Add("Rato");
            cb_tipo.Items.Add("Pássaro");
            cb_tipo.Items.Add("Peixe");
        }

        public void passeio_caes()
        {
            cb_tipo.Items.Add("");
            cb_tipo.Items.Add("Leve");
            cb_tipo.Items.Add("Moderada");
            cb_tipo.Items.Add("Trote");
            cb_profissional_responsavel.Items.Add("");
            cb_profissional_responsavel.Items.Add("Guilherme");
            cb_profissional_responsavel.Items.Add("Lucas");
            cb_profissional_responsavel.Items.Add("Nicollas");
            cb_profissional_responsavel.Items.Add("Stephanie");
        }


        private void cb_servico_SelectedIndexChanged(object sender, EventArgs e)
        {

            cb_tipo.Items.Clear();
            cb_profissional_responsavel.Items.Clear();
            categoriaSelecionada = cb_servico.SelectedItem.ToString();


            categoria_consulta_agendamento();

        }


        public void categoria_consulta_agendamento()
        {
            if (categoriaSelecionada == "Consulta Veterinária")
            {
                cb_profissional_responsavel.Visible = true;
                lb_profissional_responsavel.Visible = true;
                consulta_veterinaria();

            }
            else if (categoriaSelecionada == "Banho e Tosa")
            {
                cb_profissional_responsavel.Visible = true;
                lb_profissional_responsavel.Visible = true;
                banho_tosa();
            }
            else if (categoriaSelecionada == "Adoção")
            {
                cb_profissional_responsavel.Visible = false;
                lb_profissional_responsavel.Visible = false;
                adocao();
            }
            else if (categoriaSelecionada == "Passeio de Cães")
            {
                cb_profissional_responsavel.Visible = true;
                lb_profissional_responsavel.Visible = true;
                passeio_caes();
            }

        }


        private void FiltroGeralServicos(string servico)
        {
            Connection cn = new Connection();

            categoriaSelecionada = cb_servico.SelectedItem.ToString();
            tipoSelecionado = cb_tipo.Text;
            profissionalSelecionado = cb_profissional_responsavel.Text;


            cn.conn.Open();
            selectQueryVac = @"SELECT a.id_usuario AS 'Número de Registro do Pet',u.nome_pet AS 'Nome do Pet',
                                        u.responsavel AS 'Responsável',u.cel_usuario AS 'Celular',a.id_agendamento AS 'Número do Agendamento',
                                        a.id_servico AS 'Número do Serviço',s.servico AS 'Tipo de Serviço',a.motivo AS 'Especialidade',
                                        a.profissional_responsavel AS 'Profissional Responsável',a.preco_agend AS 'Preço do Serviço',
                                        a.data_hora AS 'Data do Agendamento' FROM agendamentos a JOIN usuarios u ON a.id_usuario = u.id_usuario 
                                        JOIN servicos s ON a.id_servico = s.id_servico 
                                        WHERE s.servico = @servico";





            SqlCommand cmdVac = new SqlCommand(selectQueryVac, cn.conn);

            cmdVac.Parameters.AddWithValue("@servico", servico);


            SqlDataReader reader = cmdVac.ExecuteReader();

            // Carregando os dados do reader para o DataTable
            dt.Load(reader);
            reader.Close();
            dataGridViewHistAgen.DataSource = dt;

            // Limpa os itens após restaurar o texto
            cb_tipo.Items.Clear();
            cb_profissional_responsavel.Items.Clear();

            categoria_consulta_agendamento();


            cn.conn.Close();
        }


        private void FiltroGeralTipos(string tipos)
        {
            Connection cn = new Connection();

            categoriaSelecionada = cb_servico.SelectedItem.ToString();
            tipoSelecionado = cb_tipo.Text;
            profissionalSelecionado = cb_profissional_responsavel.Text;


            cn.conn.Open();
            selectQueryVac = @"SELECT a.id_usuario AS 'Número de Registro do Pet',u.nome_pet AS 'Nome do Pet',
                                        u.responsavel AS 'Responsável',u.cel_usuario AS 'Celular',a.id_agendamento AS 'Número do Agendamento',
                                        a.id_servico AS 'Número do Serviço',s.servico AS 'Tipo de Serviço',a.motivo AS 'Especialidade',
                                        a.profissional_responsavel AS 'Profissional Responsável',a.preco_agend AS 'Preço do Serviço',
                                        a.data_hora AS 'Data do Agendamento' FROM agendamentos a JOIN usuarios u ON a.id_usuario = u.id_usuario 
                                        JOIN servicos s ON a.id_servico = s.id_servico 
                                        WHERE a.motivo = @motivo";



            SqlCommand cmdVac = new SqlCommand(selectQueryVac, cn.conn);

            cmdVac.Parameters.AddWithValue("@motivo", tipos);


            SqlDataReader reader = cmdVac.ExecuteReader();

            // Carregando os dados do reader para o DataTable
            dt.Load(reader);
            reader.Close();
            dataGridViewHistAgen.DataSource = dt;

            // Limpa os itens após restaurar o texto
            cb_tipo.Items.Clear();
            cb_profissional_responsavel.Items.Clear();

            categoria_consulta_agendamento();


            cn.conn.Close();
        }

        private void RealizarConsultaVeterinaria(string tipos, string profissional_responsavel)
        {
            Connection cn = new Connection();

            categoriaSelecionada = cb_servico.SelectedItem.ToString();
            tipoSelecionado = cb_tipo.Text;
            profissionalSelecionado = cb_profissional_responsavel.Text;



            cn.conn.Open();
            selectQueryVac = @"SELECT a.id_usuario AS 'Número de Registro do Pet',u.nome_pet AS 'Nome do Pet',
                                        u.responsavel AS 'Responsável',u.cel_usuario AS 'Celular',a.id_agendamento AS 'Número do Agendamento',
                                        a.id_servico AS 'Número do Serviço',s.servico AS 'Tipo de Serviço',a.motivo AS 'Especialidade',
                                        a.profissional_responsavel AS 'Profissional Responsável',a.preco_agend AS 'Preço do Serviço',
                                        a.data_hora AS 'Data do Agendamento' FROM agendamentos a JOIN usuarios u ON a.id_usuario = u.id_usuario 
                                        JOIN servicos s ON a.id_servico = s.id_servico 
                                        WHERE a.motivo = @motivo AND a.profissional_responsavel = @profissional_responsavel";



            SqlCommand cmdVac = new SqlCommand(selectQueryVac, cn.conn);

            cmdVac.Parameters.AddWithValue("@motivo", tipos);
            cmdVac.Parameters.AddWithValue("@profissional_responsavel", profissional_responsavel);


            SqlDataReader reader = cmdVac.ExecuteReader();

            // Carregando os dados do reader para o DataTable
            dt.Load(reader);
            reader.Close();
            dataGridViewHistAgen.DataSource = dt;

            // Limpa os itens após restaurar o texto
            cb_tipo.Items.Clear();
            cb_profissional_responsavel.Items.Clear();

            categoria_consulta_agendamento();


            cn.conn.Close();
        }



        private void AdotarPets(string tipos)
        {
            tipoSelecionado = cb_tipo.Text;

            Connection connect = new Connection();
            DataTable dt = new DataTable();
            connect.conn.Open();

            string selectnumRegis = "select id_usuario AS 'Número de Registro do Pet', nome_pet AS 'Nome do Pet', especie AS 'Espécie', porte AS 'Porte', " +
                "raca AS 'Raça', situacao AS 'Situação', responsavel AS 'Responsável', email_usuario AS 'E-mail', cel_usuario AS 'Celular', bairro AS 'Bairro', " +
                "endereco AS 'Endereço', numero_endereco AS 'Número do Endereço', complemento_endereco AS 'Complemento' " +
                "from usuarios where especie = @especie and situacao IN ('Em adoção', 'Adotado')";

            SqlCommand cmdnumRegis = new SqlCommand(selectnumRegis, connect.conn);

            cmdnumRegis.Parameters.AddWithValue("@especie", tipos);


            SqlDataReader dr = cmdnumRegis.ExecuteReader();

            dt.Load(dr);
            dr.Close();
            dataGridViewHistAgen.DataSource = dt;

            cb_tipo.Items.Clear();


            categoria_consulta_agendamento();

            connect.conn.Close();

        }


        private void bt_busca_registro_Click(object sender, EventArgs e)
        {
            servicos = cb_servico.Text; tipos = cb_tipo.Text; profissional_responsavel = cb_profissional_responsavel.Text;
            string categoriaSelecionada = cb_servico.SelectedItem.ToString();


            dt = new DataTable();


            //Consulta Veterinária - Carlos

            if (servicos == "Consulta Veterinária" && profissional_responsavel == "Carlos" && tipos == "Vacinação")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Vacinação", "Carlos");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Carlos" && tipos == "Check-up")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Check-up", "Carlos");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Carlos" && tipos == "Doença")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Doença", "Carlos");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Carlos" && tipos == "Castração")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Castração", "Carlos");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Carlos" && tipos == "Acidente")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Acidente", "Carlos");
            }
            //Banho e Tosa - Carlos
            if (servicos == "Banho e Tosa" && profissional_responsavel == "Carlos" && tipos == "Tosa Higiênica")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa Higiênica", "Carlos");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Carlos" && tipos == "Tosa na Tesoura")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa na Tesoura", "Carlos");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Carlos" && tipos == "Tosa na Máquina")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa na Máquina", "Carlos");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Carlos" && tipos == "Tosa Bebê")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa Bebê", "Carlos");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Carlos" && tipos == "Tosa Verão")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa Verão", "Carlos");
            }

            //Consulta Veterinária - Guilherme
            if (servicos == "Consulta Veterinária" && profissional_responsavel == "Guilherme" && tipos == "Vacinação")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Vacinação", "Guilherme");

            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Guilherme" && tipos == "Check-up")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Check-up", "Guilherme");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Guilherme" && tipos == "Doença")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Doença", "Guilherme");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Guilherme" && tipos == "Castração")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Castração", "Guilherme");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Guilherme" && tipos == "Acidente")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Acidente", "Guilherme");
            }

            //Banho e Tosa - Guilherme
            if (servicos == "Banho e Tosa" && profissional_responsavel == "Guilherme" && tipos == "Tosa Higiênica")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa Higiênica", "Guilherme");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Guilherme" && tipos == "Tosa na Tesoura")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa na Tesoura", "Guilherme");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Guilherme" && tipos == "Tosa na Máquina")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa na Máquina", "Guilherme");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Guilherme" && tipos == "Tosa Bebê")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa Bebê", "Guilherme");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Guilherme" && tipos == "Tosa Verão")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa Verão", "Guilherme");
            }

            //Passeio de Cães - Guilherme
            if (servicos == "Passeio de Cães" && profissional_responsavel == "Guilherme" && tipos == "Leve")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Leve", "Guilherme");
            }
            else if (servicos == "Passeio de Cães" && profissional_responsavel == "Guilherme" && tipos == "Moderada")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Moderada", "Guilherme");
            }
            else if (servicos == "Passeio de Cães" && profissional_responsavel == "Guilherme" && tipos == "Trote")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Trote", "Guilherme");
            }

            //Consulta Veterinária - Lucas
            if (servicos == "Consulta Veterinária" && profissional_responsavel == "Lucas" && tipos == "Vacinação")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Vacinação", "Lucas");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Lucas" && tipos == "Check-up")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Check-up", "Lucas");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Lucas" && tipos == "Doença")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Doença", "Lucas");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Lucas" && tipos == "Castração")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Castração", "Lucas");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Lucas" && tipos == "Acidente")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Acidente", "Lucas");
            }

            //Banho e Tosa - Lucas
            if (servicos == "Banho e Tosa" && profissional_responsavel == "Lucas" && tipos == "Tosa Higiênica")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa Higiênica", "Lucas");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Lucas" && tipos == "Tosa na Tesoura")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa na Tesoura", "Lucas");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Lucas" && tipos == "Tosa na Máquina")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa na Máquina", "Lucas");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Lucas" && tipos == "Tosa Bebê")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa Bebê", "Lucas");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Lucas" && tipos == "Tosa Verão")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa Verão", "Lucas");
            }

            //Passeio de Cães - Lucas
            if (servicos == "Passeio de Cães" && profissional_responsavel == "Lucas" && tipos == "Leve")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Leve", "Lucas");
            }
            else if (servicos == "Passeio de Cães" && profissional_responsavel == "Lucas" && tipos == "Moderada")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Moderada", "Lucas");
            }
            else if (servicos == "Passeio de Cães" && profissional_responsavel == "Lucas" && tipos == "Trote")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Trote", "Lucas");
            }


            //Consulta Veterinária - Nicollas
            if (servicos == "Consulta Veterinária" && profissional_responsavel == "Nicollas" && tipos == "Vacinação")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Vacinação", "Nicollas");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Nicollas" && tipos == "Check-up")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Check-up", "Nicollas");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Nicollas" && tipos == "Doença")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Doença", "Nicollas");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Nicollas" && tipos == "Castração")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Castração", "Nicollas");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Nicollas" && tipos == "Acidente")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Acidente", "Nicollas");
            }

            //Banho e Tosa - Nicollas
            if (servicos == "Banho e Tosa" && profissional_responsavel == "Nicollas" && tipos == "Tosa Higiênica")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa Higiênica", "Nicollas");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Nicollas" && tipos == "Tosa na Tesoura")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa na Tesoura", "Nicollas");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Nicollas" && tipos == "Tosa na Máquina")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa na Máquina", "Nicollas");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Nicollas" && tipos == "Tosa Bebê")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa Bebê", "Nicollas");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Nicollas" && tipos == "Tosa Verão")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa Verão", "Nicollas");
            }

            //Passeio de Cães - Nicollas
            if (servicos == "Passeio de Cães" && profissional_responsavel == "Nicollas" && tipos == "Leve")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Leve", "Nicollas");
            }
            else if (servicos == "Passeio de Cães" && profissional_responsavel == "Nicollas" && tipos == "Moderada")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Moderada", "Nicollas");
            }
            else if (servicos == "Passeio de Cães" && profissional_responsavel == "Nicollas" && tipos == "Trote")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Trote", "Nicollas");
            }


            //Consulta Veterinária - Samuel
            if (servicos == "Consulta Veterinária" && profissional_responsavel == "Samuel" && tipos == "Vacinação")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Vacinação", "Samuel");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Samuel" && tipos == "Check-up")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Check-up", "Samuel");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Samuel" && tipos == "Doença")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Doença", "Samuel");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Samuel" && tipos == "Castração")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Castração", "Samuel");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Samuel" && tipos == "Acidente")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Acidente", "Samuel");
            }

            //Banho e Tosa - Samuel
            if (servicos == "Banho e Tosa" && profissional_responsavel == "Samuel" && tipos == "Tosa Higiênica")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa Higiênica", "Samuel");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Samuel" && tipos == "Tosa na Tesoura")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa na Tesoura", "Samuel");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Samuel" && tipos == "Tosa na Máquina")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa na Máquina", "Samuel");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Samuel" && tipos == "Tosa Bebê")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa Bebê", "Samuel");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Samuel" && tipos == "Tosa Verão")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa Verão", "Samuel");
            }

            //Consulta Veterinária - Stephanie
            if (servicos == "Consulta Veterinária" && profissional_responsavel == "Stephanie" && tipos == "Vacinação")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Vacinação", "Stephanie");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Stephanie" && tipos == "Check-up")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Check-up", "Stephanie");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Stephanie" && tipos == "Doença")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Doença", "Stephanie");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Stephanie" && tipos == "Castração")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Castração", "Stephanie");
            }
            else if (servicos == "Consulta Veterinária" && profissional_responsavel == "Stephanie" && tipos == "Acidente")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Acidente", "Stephanie");
            }

            //Banho e Tosa - Stephanie
            if (servicos == "Banho e Tosa" && profissional_responsavel == "Stephanie" && tipos == "Tosa Higiênica")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa Higiênica", "Stephanie");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Stephanie" && tipos == "Tosa na Tesoura")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa na Tesoura", "Stephanie");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Stephanie" && tipos == "Tosa na Máquina")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa na Máquina", "Stephanie");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Stephanie" && tipos == "Tosa Bebê")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa Bebê", "SaStephaniemuel");
            }
            else if (servicos == "Banho e Tosa" && profissional_responsavel == "Stephanie" && tipos == "Tosa Verão")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Tosa Verão", "Stephanie");
            }

            //Passeio de Cães - Stephanie
            if (servicos == "Passeio de Cães" && profissional_responsavel == "Stephanie" && tipos == "Leve")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Leve", "Stephanie");
            }
            else if (servicos == "Passeio de Cães" && profissional_responsavel == "Stephanie" && tipos == "Moderada")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Moderada", "Stephanie");
            }
            else if (servicos == "Passeio de Cães" && profissional_responsavel == "Stephanie" && tipos == "Trote")
            {
                categoria_consulta_agendamento();
                RealizarConsultaVeterinaria("Trote", "Stephanie");
            }


            //Adoção de Cães
            if (servicos == "Adoção" && tipos == "Cachorro")
            {
                categoria_consulta_agendamento();
                AdotarPets("Cachorro");

            }
            else if (servicos == "Adoção" && tipos == "Gato")
            {
                categoria_consulta_agendamento();
                AdotarPets("Gato");
            }
            else if (servicos == "Adoção" && tipos == "Coelho")
            {
                categoria_consulta_agendamento();
                AdotarPets("Coelho");
            }
            else if (servicos == "Adoção" && tipos == "Rato")
            {
                categoria_consulta_agendamento();
                AdotarPets("Rato");
            }
            else if (servicos == "Adoção" && tipos == "Pássaro")
            {
                categoria_consulta_agendamento();
                AdotarPets("Pássaro");
            }
            else if (servicos == "Adoção" && tipos == "Peixe")
            {
                categoria_consulta_agendamento();
                AdotarPets("Peixe");
            }

            cb_tipo.Text = tipoSelecionado;
            cb_profissional_responsavel.Text = profissionalSelecionado;

        }

        private void bt_limpar_bant_Click(object sender, EventArgs e)
        {
            dataGridViewHistAgen.DataSource = "";
            cb_servico.Text = "";
            cb_tipo.Text = "";
            cb_profissional_responsavel.Text = "";
        }

        private void bt_excluir_regis_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Confirma a exclusão do registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (resultado == DialogResult.Yes)
            {
                // Verifica se uma linha está selecionada
                if (dataGridViewHistAgen.SelectedRows.Count > 0)
                {
                    try
                    {
                        Connection cn = new Connection();

                        cn.conn.Open();

                        if (categoriaSelecionada == "Adoção")
                        {
                            int rowIndexAdot = dataGridViewHistAgen.SelectedRows[0].Index;

                            // Obtém o ID do registro selecionado
                            int idAdot = Convert.ToInt32(dataGridViewHistAgen.Rows[rowIndexAdot].Cells["Número de Registro do Pet"].Value);

                            dataGridViewHistAgen.Rows.RemoveAt(rowIndexAdot);

                            string delRegisAdot = "delete from usuarios where id_usuario = @id_usuario";

                            SqlCommand cmdDel = new SqlCommand(delRegisAdot, cn.conn);

                            cmdDel.Parameters.AddWithValue("@id_usuario", idAdot);
                            cmdDel.ExecuteNonQuery();

                            MessageBox.Show("Registro Excluído!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                            //Obtém o índice da linha selecionada
                            int rowIndex = dataGridViewHistAgen.SelectedRows[0].Index;

                            // Obtém o ID do registro selecionado
                            int id = Convert.ToInt32(dataGridViewHistAgen.Rows[rowIndex].Cells["Número do Agendamento"].Value);

                            dataGridViewHistAgen.Rows.RemoveAt(rowIndex);


                            string delRegis = "delete from agendamentos where id_agendamento = @id_agendamento";

                            SqlCommand cmdDel = new SqlCommand(delRegis, cn.conn);

                            cmdDel.Parameters.AddWithValue("@id_agendamento", id);
                            cmdDel.ExecuteNonQuery();

                            MessageBox.Show("Registro Excluído!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        cn.conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir registro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Erro ao excluir registro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

        }

        private void bt_salvar_regis_Click(object sender, EventArgs e)
        {
            if (dataGridViewHistAgen.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow row = dataGridViewHistAgen.SelectedRows[0];

                // Obtém os valores das células da linha
                int id = Convert.ToInt32(row.Cells["Número do Agendamento"].Value);

                profissional_responsavel = row.Cells["Profissional Responsável"].Value.ToString();
                DateTime dataAgendamento;
                DateTime.TryParse(row.Cells["Data do Agendamento"].Value.ToString(), out dataAgendamento);


                DialogResult resultado = MessageBox.Show("Tem certeza que deseja salvar as alterações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        Connection cn = new Connection();

                        cn.conn.Open();

                        string query = "UPDATE Agendamentos SET profissional_responsavel = @profissional_responsavel, " +
                            "data_hora = @data_hora WHERE id_agendamento = @id_agendamento";

                        SqlCommand command = new SqlCommand(query, cn.conn);
                        command.Parameters.AddWithValue("@profissional_responsavel", profissional_responsavel);
                        command.Parameters.AddWithValue("@data_hora", dataAgendamento);
                        command.Parameters.AddWithValue("@id_agendamento", id);

                        // Executa o comando SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro foi atualizado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao atualizar registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma linha para atualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }

        }

        private void bt_voltar_passeio_caes_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Home home = new Home() { TopLevel = false, TopMost = true };
            home.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(home);
            home.Show();
        }
    }
}
