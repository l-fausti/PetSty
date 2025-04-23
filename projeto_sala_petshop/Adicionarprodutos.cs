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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projeto_sala_petshop
{
    public partial class Adicionarprodutos : Form
    {
        public Adicionarprodutos()
        {
            InitializeComponent();
        }

        private void bt_voltar_adicionar_produtos_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Produtos produtos = new Produtos() { TopLevel = false, TopMost = true };
            produtos.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(produtos);
            produtos.Show();
        }

        private void bt_load_img_produtos_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picture_box_produtos.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void bt_cadastrar_produto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_preco_produto.Text) ||
            string.IsNullOrWhiteSpace(tb_categoria_produto.Text) ||
            string.IsNullOrWhiteSpace(tb_preco_produto.Text) ||
            numericUpDown1.Value == 0 || picture_box_produtos.Image == null)
            {
                MessageBox.Show("Preencha todos os campos e carregue uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult resultado = MessageBox.Show("Tem certeza que deseja salvar as alterações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // Obter o ID da caixa de texto
                if (!int.TryParse(tb_nr_func.Text, out int id))
                {
                    MessageBox.Show("Número de registro inválido!");
                    return;
                }


                if (VerificarIdExistente(id))
                {

                    Connection cn = new Connection();

                    string query = "INSERT INTO produtos (categoria, nome_produto, preco_produto, quantidade, imagem_produto, id_usuario) " +
                                   "VALUES (@categoria, @nome_produto, @preco, @quantidade, @imagem, @id_usuario)";

                    try
                    {
                        cn.conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, cn.conn))
                        {
                            MemoryStream ms = new MemoryStream();
                            picture_box_produtos.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] imgBytes = ms.ToArray();

                            cmd.Parameters.AddWithValue("@categoria", tb_categoria_produto.Text);
                            cmd.Parameters.AddWithValue("@nome_produto", tb_nome_produto.Text);
                            cmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(tb_preco_produto.Text));
                            cmd.Parameters.AddWithValue("@quantidade", Convert.ToInt32(numericUpDown1.Value));
                            cmd.Parameters.AddWithValue("@imagem", imgBytes);
                            cmd.Parameters.AddWithValue("@id_usuario", Convert.ToDecimal(tb_nr_func.Text)); // Adicionando o ID do usuário

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        cn.conn.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Número de registro não existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }


        }

        private bool VerificarIdExistente(int id)
        {
            Connection cn = new Connection();

            string query = "SELECT 1 FROM usuarios WHERE id_usuario = @id";

            SqlCommand command = new SqlCommand(query, cn.conn);

            command.Parameters.AddWithValue("@id", id);
            cn.conn.Open();

            object result = command.ExecuteScalar();

            return result != null && result != DBNull.Value;

        }

        private void bt_limpar_produtos_Click(object sender, EventArgs e)
        {
            tb_categoria_produto.Text = "";
            tb_nome_produto.Text = "";
            tb_preco_produto.Text = "";
            tb_nr_func.Text = "";
            numericUpDown1.Value = 0;
            picture_box_produtos.Image = null;

        }

        private void tb_preco_produto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
