using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_sala_petshop
{
    public partial class Adoteagora : Form
    {
        string tipoPetAdtAgr { get; set; }
        string cbPorteAdtAgr { get; set; }
        string responsavelAdtAgr { get; set; }
        string emailAdtAgr { get; set; }
        string celAdtAgr { get; set; }
        string bairroAdtAgr { get; set; }
        string enderecoAdtAgr { get; set; }
        string numeroAdtAgr { get; set; }
        string complementoAdtAgr { get; set; }
        string numero_registro { get; set; }

        string petsLocalizados { get; set; }
        string nomePetAdtAgr { get; set; }
        string especieAdtAgr { get; set; }
        string porteAdtAgr { get; set; }
        string racaAdtAgr { get; set; }

        private List<string> nomeLocalizado;
        private int indiceAtual = -1;


        public Adoteagora()
        {
            InitializeComponent();
        }

        private void bt_voltar_adote_agora_Click(object sender, EventArgs e)
        {
            pn_adote_agora.Controls.Clear();
            Adocao adocao = new Adocao() { TopLevel = false, TopMost = true };
            adocao.FormBorderStyle = FormBorderStyle.None;
            pn_adote_agora.Controls.Add(adocao);
            adocao.Show();
        }

        private void bt_search_adot_agora_Click(object sender, EventArgs e)
        {
            petsLocalizados = tb_pets_localizados.Text;
            tipoPetAdtAgr = cb_tipo_adot.Text;
            cbPorteAdtAgr = cb_porte_adot.Text;
            nomePetAdtAgr = tb_nome_pet_adot.Text;
            especieAdtAgr = tb_especie_adot.Text;
            porteAdtAgr = tb_porte_adot.Text;
            racaAdtAgr = tb_raca_adot.Text;
            responsavelAdtAgr = tb_responsavel_adot.Text;
            emailAdtAgr = tb_email_adot.Text;
            celAdtAgr = mtb_celular_adot.Text;
            bairroAdtAgr = tb_bairro_adot.Text;
            enderecoAdtAgr = tb_endereco_adot.Text;
            numeroAdtAgr = mtb_numero_res_adot.Text;
            complementoAdtAgr = tb_complemento_res_adot.Text;

            pictureBox_dog.Visible = false;

            Connection cn = new Connection();
            cn.conn.Open();

            string selectImage = "select foto_pet from usuarios where especie = @especie and porte = @porte and situacao = 'Em adoção'";

            SqlCommand cmdImage = new SqlCommand(selectImage, cn.conn);

            cmdImage.Parameters.AddWithValue("@especie", tipoPetAdtAgr);
            cmdImage.Parameters.AddWithValue("@porte", cbPorteAdtAgr);

            SqlDataReader reader = cmdImage.ExecuteReader();

            if (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("foto_pet")))
                {
                    byte[] imagemBytes = (byte[])reader["foto_pet"];

                    MemoryStream ms = new MemoryStream(imagemBytes);
                    picture_box_img_pet_adot.Image = Image.FromStream(ms);
                }
                else
                {
                    MessageBox.Show("Imagem não encontrada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    picture_box_img_pet_adot.Image = null;
                    
                    tb_pets_localizados.Clear();
                }
            }

            cn.conn.Close();


            Connection connect = new Connection();
            DataTable dt = new DataTable();
            connect.conn.Open();

            string selectnumRegis = "select id_usuario AS numero_registro, nome_pet, especie, porte, " +
                "raca, bairro, situacao from usuarios where especie = @especie and porte = @porte and id_usuario > 103";

            SqlCommand cmdnumRegis = new SqlCommand(selectnumRegis, connect.conn);

            cmdnumRegis.Parameters.AddWithValue("@especie", tipoPetAdtAgr);
            cmdnumRegis.Parameters.AddWithValue("@porte", cbPorteAdtAgr);

            SqlDataReader dr = cmdnumRegis.ExecuteReader();

            dt.Load(dr);
            dr.Close();

            connect.conn.Close();

            Connection conNumRegis = new Connection();
            conNumRegis.conn.Open();

            string queryQuantRes = "select count(*) from usuarios where especie = @especie and porte = @porte and situacao = 'Em adoção'";

            SqlCommand cmdQuantRes = new SqlCommand(queryQuantRes, conNumRegis.conn);

            cmdQuantRes.Parameters.AddWithValue("@especie", tipoPetAdtAgr);
            cmdQuantRes.Parameters.AddWithValue("@porte", cbPorteAdtAgr);

            int quantidadeRegistro = (int)cmdQuantRes.ExecuteScalar();

            if (quantidadeRegistro > 1)
            {
                tb_pets_localizados.Text = $"{quantidadeRegistro} pets localizados";
                bt_arrow_right_adot.Visible = true;
                bt_arrow_left_adot.Visible = true;
            }
            else if (quantidadeRegistro == 1)
            {
                tb_pets_localizados.Text = $"{quantidadeRegistro} pet localizado";
                bt_arrow_right_adot.Visible = false;
                bt_arrow_left_adot.Visible = false;
            }

            conNumRegis.conn.Close();

            nomePetLocalizado();
            ExibirProximoNome();

        }

        private void nomePetLocalizado()
        {
     
            Connection nomePet = new Connection();

            nomePet.conn.Open();
            string queryNomePet = "select nome_pet from usuarios where especie = @especie and porte = @porte and situacao = 'Em adoção'";
            SqlCommand cmdNomePet = new SqlCommand(queryNomePet, nomePet.conn);

            cmdNomePet.Parameters.AddWithValue("@especie", tipoPetAdtAgr);
            cmdNomePet.Parameters.AddWithValue("@porte", cbPorteAdtAgr);

            SqlDataReader readerNomes = cmdNomePet.ExecuteReader();

            nomeLocalizado = new List<string>();

           while (readerNomes.Read())
            {
                string nome = readerNomes["nome_pet"].ToString();
                nomeLocalizado.Add(nome);
            }

            readerNomes.Close();
            nomePet.conn.Close();
        }

        private void ExibirProximoNome()
        {
            if (nomeLocalizado == null || nomeLocalizado.Count == 0)
            {
                tb_nome_pet_localizado.Text = "Nenhum pet localizado";
                picture_box_img_pet_adot.Image = null;
                tb_pets_localizados.Clear();
                bt_arrow_right_adot.Visible = false;
                bt_arrow_left_adot.Visible = false;
                return;
            }

            indiceAtual++; // Incrementa o índice

            if (indiceAtual >= nomeLocalizado.Count)
            {
                indiceAtual = 0; // Volta para o primeiro nome se chegar ao final da lista
            }

            tb_nome_pet_localizado.Text = nomeLocalizado[indiceAtual]; // Exibe o nome no TextBox
        }

        private void bt_arrow_right_adot_Click(object sender, EventArgs e)
        {
            string tipoPetAdtAgr = cb_tipo_adot.Text;
            string cbPorteAdtAgr = cb_porte_adot.Text;

            List<byte[]> imagensBytes = new List<byte[]>();
            int currentIndex = 0;


            Connection connection = new Connection();

            try
            {
                connection.conn.Open();

                string queryNext = "select foto_pet from usuarios where especie = @especie and porte = @porte and situacao = 'Em adoção'";
                SqlCommand cmdNext = new SqlCommand(queryNext, connection.conn);

                cmdNext.Parameters.AddWithValue("@especie", tipoPetAdtAgr);
                cmdNext.Parameters.AddWithValue("@porte", cbPorteAdtAgr);

                SqlDataReader reader = cmdNext.ExecuteReader();

                // Percorre os resultados e adiciona as imagens (em byte[]) à lista
                while (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("foto_pet")))
                    {
                        byte[] imagemBytes = (byte[])reader["foto_pet"];
                        imagensBytes.Add(imagemBytes);

                    }
                }

                if (imagensBytes.Count > 0)
                {
                    // Atualiza o índice para a próxima imagem
                    currentIndex = (currentIndex + 1) % imagensBytes.Count;

                    using (MemoryStream ms = new MemoryStream(imagensBytes[currentIndex]))
                    {
                        Image imagem = Image.FromStream(ms);
                        picture_box_img_pet_adot.Image = imagem;

                        if (indiceAtual == -1) // Carrega os nomes apenas na primeira vez
                        {
                            nomePetLocalizado();
                        }
                        ExibirProximoNome();
                    }
                }
                else
                {
                    MessageBox.Show("Nenhuma imagem encontrada para os critérios selecionados.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar ou carregar imagens: " + ex.Message);

            }
            finally
            {
                if (connection.conn.State == System.Data.ConnectionState.Open)
                {
                    connection.conn.Close();
                }
            }

        }

        private void bt_arrow_left_adot_Click(object sender, EventArgs e)
        {
            tipoPetAdtAgr = cb_tipo_adot.Text;
            cbPorteAdtAgr = cb_porte_adot.Text;

            List<byte[]> imagensBytes = new List<byte[]>();
            int currentIndex = 0;


            Connection connection = new Connection();

            try
            {
                connection.conn.Open();

                string queryNext = "select foto_pet from usuarios where especie = @especie and porte = @porte and situacao = 'Em adoção'";
                SqlCommand cmdNext = new SqlCommand(queryNext, connection.conn);

                cmdNext.Parameters.AddWithValue("@especie", tipoPetAdtAgr);
                cmdNext.Parameters.AddWithValue("@porte", cbPorteAdtAgr);

                SqlDataReader reader = cmdNext.ExecuteReader();

                // Percorre os resultados e adiciona as imagens (em byte[]) à lista
                while (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("foto_pet")))
                    {
                        byte[] imagemBytes = (byte[])reader["foto_pet"];
                        imagensBytes.Add(imagemBytes);

                    }
                }


                if (imagensBytes.Count > 0)
                {
                    // Atualiza o índice para a próxima imagem
                    currentIndex = (currentIndex) % imagensBytes.Count;

                    using (MemoryStream ms = new MemoryStream(imagensBytes[currentIndex]))
                    {
                        Image imagem = Image.FromStream(ms);
                        picture_box_img_pet_adot.Image = imagem;

                        if (indiceAtual == -1) // Carrega os nomes apenas na primeira vez
                        {
                            nomePetLocalizado();
                        }
                        ExibirProximoNome();
                    }
                }
                else
                {
                    MessageBox.Show("Nenhuma imagem encontrada para os critérios selecionados.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar ou carregar imagens: " + ex.Message);

            }
            finally
            {
                if (connection.conn.State == System.Data.ConnectionState.Open)
                {
                    connection.conn.Close();
                }
            }
        }

        private void bt_confirm_adot_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirma a adoção do pet?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            try
            {
                if (resultado == DialogResult.Yes)
                {
                    numero_registro = tb_nr_adt_agr.Text;
                    petsLocalizados = tb_pets_localizados.Text;
                    nomePetAdtAgr = tb_nome_pet_adot.Text;
                    especieAdtAgr = tb_especie_adot.Text;
                    porteAdtAgr = tb_porte_adot.Text;
                    racaAdtAgr = tb_raca_adot.Text;
                    responsavelAdtAgr = tb_responsavel_adot.Text;
                    emailAdtAgr = tb_email_adot.Text;
                    celAdtAgr = mtb_celular_adot.Text;
                    bairroAdtAgr = tb_bairro_adot.Text;
                    enderecoAdtAgr = tb_endereco_adot.Text;
                    numeroAdtAgr = mtb_numero_res_adot.Text;
                    complementoAdtAgr = tb_complemento_res_adot.Text;

                    if (string.IsNullOrWhiteSpace(petsLocalizados) || string.IsNullOrWhiteSpace(nomePetAdtAgr) ||
                    string.IsNullOrWhiteSpace(especieAdtAgr) || string.IsNullOrWhiteSpace(porteAdtAgr) ||
                    string.IsNullOrWhiteSpace(racaAdtAgr) || string.IsNullOrWhiteSpace(responsavelAdtAgr) ||
                    string.IsNullOrWhiteSpace(emailAdtAgr) || string.IsNullOrWhiteSpace(celAdtAgr) ||
                    string.IsNullOrWhiteSpace(bairroAdtAgr) || string.IsNullOrWhiteSpace(enderecoAdtAgr) ||
                    string.IsNullOrWhiteSpace(numeroAdtAgr))
                    {
                        MessageBox.Show("Por favor, preencha todos os campos.", "Validação de Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Interrompe a execução se houver campos vazios
                    }

                    Connection cn = new Connection();
                    cn.conn.Open();

                    //Verifica se já existe alguma consulta agendada
                    string upQuery = "UPDATE  usuarios SET responsavel = @responsavel, email_usuario = @email_usuario, cel_usuario = @cel_usuario, bairro = @bairro," +
                        "endereco = @endereco, numero_endereco = @numero_endereco, complemento_endereco = @complemento_endereco," +
                        "situacao = 'Adotado' where id_usuario = @id_usuario";

                    SqlCommand cmdUp = new SqlCommand(upQuery, cn.conn);
                    cmdUp.Parameters.AddWithValue("@id_usuario", numero_registro);
                    cmdUp.Parameters.AddWithValue("@responsavel", responsavelAdtAgr);
                    cmdUp.Parameters.AddWithValue("@email_usuario", emailAdtAgr);
                    cmdUp.Parameters.AddWithValue("@cel_usuario", celAdtAgr);
                    cmdUp.Parameters.AddWithValue("@bairro", bairroAdtAgr);
                    cmdUp.Parameters.AddWithValue("@endereco", enderecoAdtAgr);
                    cmdUp.Parameters.AddWithValue("@numero_endereco", numeroAdtAgr);
                    cmdUp.Parameters.AddWithValue("@complemento_endereco", complementoAdtAgr);


                    int linhasAfetadasUpdate = (int)cmdUp.ExecuteNonQuery(); // Executa a consulta e retorna o número de linhas afetadas
                    

                    if (linhasAfetadasUpdate > 0)
                    {
                        MessageBox.Show("Adoção realizada!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Pet não localizado para adoção!", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    //ultima modificação
                    cn.conn.Close();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Pet não encontrado", "Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_limpar_adot_Click(object sender, EventArgs e)
        {
            tb_pets_localizados.Clear();
            cb_tipo_adot.SelectedIndex = 0;
            cb_porte_adot.SelectedIndex = 0;
            tb_nr_adt_agr.Clear();
            tb_nome_pet_adot.Clear();
            tb_especie_adot.Clear();
            tb_porte_adot.Clear();
            tb_raca_adot.Clear();
            tb_responsavel_adot.Clear();
            tb_email_adot.Clear();
            mtb_celular_adot.Clear();
            tb_bairro_adot.Clear();
            tb_endereco_adot.Clear();
            mtb_numero_res_adot.Clear();
            tb_complemento_res_adot.Clear();
            tb_pets_localizados.Clear();
            picture_box_img_pet_adot.Image = null;
            pictureBox_dog.Visible = true;
        }

        private void tb_nr_adt_agr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloqueia o caractere
            }
            if (tb_nr_adt_agr.Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Impede digitar mais de 5 caracteres
            }
        }
    }
}
