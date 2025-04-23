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
    public partial class Cadastrodepets : Form
    {
        public Cadastrodepets()
        {
            InitializeComponent();
        }

        private void bt_voltar_cad_pets_Click(object sender, EventArgs e)
        {
            pn_cad_pets_adotivos.Controls.Clear();
            Adocao adocao = new Adocao() { TopLevel = false, TopMost = true };
            adocao.FormBorderStyle = FormBorderStyle.None;
            pn_cad_pets_adotivos.Controls.Add(adocao);
            adocao.Show();
        }


        //Inserção de imagem computador
        private void bt_load_img_cad_pets_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picture_box_cad_pets.Image = Image.FromFile(openFileDialog.FileName);
            }

        }

        private void bt_confirmar_cad_pets_Click(object sender, EventArgs e)
        {
            string nomeCadPet = tb_nome_pet_cad_pets.Text; string especieCadPet = tb_especie_cad_pets.Text;
            string porteCadPet = tb_porte_cad_pets.Text; string racaCadPet = tb_raca_cad_pets.Text;
            string situacaoCadPet = tb_situacao_cad_pets.Text;

            if (string.IsNullOrWhiteSpace(nomeCadPet) || string.IsNullOrWhiteSpace(especieCadPet) || string.IsNullOrWhiteSpace(racaCadPet) ||
                string.IsNullOrWhiteSpace(situacaoCadPet))
            {
                MessageBox.Show("Por favor, preencha todos os campos para validar o registro.", "Validação de Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (picture_box_cad_pets.Image == null)
            {
                MessageBox.Show("Imagem não encontrada ao cadastrar pet, insira uma imagem!.",
                    "Registro de imagens", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tb_descricao_cad_pets.Text = $"{nomeCadPet} \r\n {especieCadPet} \r\n {porteCadPet} " +
                $"\r\n {racaCadPet} \r\n {situacaoCadPet}";
            }
        }

        private void bt_cadastrar_pets_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja confirmar o cadastro?", "Confirmação", MessageBoxButtons.YesNo);

            string nomeCadPet = tb_nome_pet_cad_pets.Text; string especieCadPet = tb_especie_cad_pets.Text;
            string porteCadPet = tb_porte_cad_pets.Text; string racaCadPet = tb_raca_cad_pets.Text;
            string situacaoCadPet = tb_situacao_cad_pets.Text;

            try
            {
                if (resultado == DialogResult.Yes)
                {
                    if (tb_descricao_cad_pets.Text != null)
                    {
                        byte[] imagemBytes;
                        using (MemoryStream ms = new MemoryStream())
                        {
                            // Obtém o formato da imagem
                            System.Drawing.Imaging.ImageFormat formatoImagem = picture_box_cad_pets.Image.RawFormat;

                            // Salvar a imagem com o formato original
                            picture_box_cad_pets.Image.Save(ms, formatoImagem);
                            imagemBytes = ms.ToArray();
                        }

                        Connection cn = new Connection();
                        cn.conn.Open();

                        string insertPetAdot = "insert into usuarios(foto_pet,nome_pet,especie,porte,raca,situacao) " +
                            "values (@foto_pet,@nome_pet,@especie,@porte,@raca,@situacao);" +
                            "select cast(scope_identity()as int)";

                        SqlCommand insertCmd = new SqlCommand(insertPetAdot, cn.conn);

                        insertCmd.Parameters.AddWithValue("@foto_pet", imagemBytes);
                        insertCmd.Parameters.AddWithValue("@nome_pet", nomeCadPet);
                        insertCmd.Parameters.AddWithValue("@especie", especieCadPet);
                        insertCmd.Parameters.AddWithValue("@porte", porteCadPet);
                        insertCmd.Parameters.AddWithValue("@raca", racaCadPet);
                        insertCmd.Parameters.AddWithValue("@situacao", situacaoCadPet);


                        int lastId = (int)insertCmd.ExecuteScalar();

                        if (lastId > 0)
                        {
                            MessageBox.Show($"Cadastro efetuado com sucesso! \r\nNúmero de Registro: {lastId}",
                            "Cadastro de Pet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Por favor, preencha todos os campos para validar o registro.", 
                    "Validação de Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_limpar_cad_pets_Click(object sender, EventArgs e)
        {
            tb_descricao_cad_pets.Clear(); tb_nome_pet_cad_pets.Text = ""; tb_especie_cad_pets.Text = "";
            tb_porte_cad_pets.Text = ""; tb_raca_cad_pets.Text = ""; 
            tb_situacao_cad_pets.Text = ""; picture_box_cad_pets.Image = null;
        }
    }
}
