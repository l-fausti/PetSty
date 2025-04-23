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
    public partial class Buscarprodutos : Form
    {
        public Buscarprodutos()
        {
            InitializeComponent();
        }

        private void bt_voltar_busca_produtos_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Produtos produtos = new Produtos() { TopLevel = false, TopMost = true };
            produtos.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(produtos);
            produtos.Show();
        }

        private int produtoSelecionadoId = -1; // Variável para armazenar o ID do produto selecionado




        private void bt_adicionar_unidade_Click(object sender, EventArgs e)
        {
            if(dataGridViewProdutos.SelectedRows.Count > 0) // Verifica se há alguma linha selecionada
    {
                DataGridViewRow selectedRow = dataGridViewProdutos.SelectedRows[0];
                int produtoSelecionadoId = Convert.ToInt32(selectedRow.Cells["id_produto"].Value);

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja adicionar uma unidade?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    Connection cn = new Connection();
                    string query = "UPDATE produtos SET quantidade = quantidade + 1 WHERE id_produto = @id";

                    try
                    {
                        cn.conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, cn.conn))
                        {
                            cmd.Parameters.AddWithValue("@id", produtoSelecionadoId);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Quantidade aumentada com sucesso!", "Aumento de Unidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AtualizarDataGridView(); // Atualiza o DataGridView após a alteração
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao aumentar a quantidade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        cn.conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto!", "Selecione para Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void AtualizarDataGridView()
        {
            Connection cn = new Connection();
            string query = "SELECT id_produto, categoria, nome_produto, quantidade, preco_produto, imagem_produto FROM produtos";

            try
            {
                cn.conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cn.conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Verifica se o DataGridView já tem colunas, se não, adiciona-as
                    if (dataGridViewProdutos.Columns.Count == 0)
                    {
                        // Coluna da imagem PRIMEIRO
                        DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                        imgColumn.Name = "imagem_produto";
                        imgColumn.HeaderText = "Imagem";
                        imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                        dataGridViewProdutos.Columns.Add(imgColumn);

                        // Outras colunas depois 
                        dataGridViewProdutos.Columns.Add("id_produto", "ID");
                        dataGridViewProdutos.Columns.Add("categoria", "Categoria");
                        dataGridViewProdutos.Columns.Add("nome_produto", "Nome do Produto");
                        dataGridViewProdutos.Columns.Add("quantidade", "Quantidade");
                        dataGridViewProdutos.Columns.Add("preco_produto", "Preço");

                        // Aumenta o tamanho das células para melhor exibição
                        dataGridViewProdutos.RowTemplate.Height = 100; // Linhas mais altas
                        dataGridViewProdutos.Columns["imagem_produto"].Width = 150; // Coluna de imagem mais larga
                    }


                    dataGridViewProdutos.Rows.Clear(); // Limpa os dados antigos

                    foreach (DataRow row in dt.Rows)
                    {
                        // Convertendo a imagem do banco de dados para um objeto Image
                        Image img = null;
                        if (row["imagem_produto"] != DBNull.Value)
                        {
                            byte[] imgBytes = (byte[])row["imagem_produto"];
                            using (MemoryStream ms = new MemoryStream(imgBytes))
                            {
                                img = Image.FromStream(ms);
                            }
                        }

                        // Adicionando os dados na linha do DataGridView
                        dataGridViewProdutos.Rows.Add(
                            img, // IMAGEM PRIMEIRO
                            row["id_produto"],
                            row["categoria"],
                            row["nome_produto"],
                            row["quantidade"],
                            row["preco_produto"]
                        );
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produtos","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                cn.conn.Close();
            }
        }

        private void bt_remover_unidade_Click(object sender, EventArgs e)
        {

            if (dataGridViewProdutos.SelectedRows.Count > 0) // Verifica se há alguma linha selecionada
            {
                DataGridViewRow selectedRow = dataGridViewProdutos.SelectedRows[0];
                int produtoSelecionadoId = Convert.ToInt32(selectedRow.Cells["id_produto"].Value);

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja remover uma unidade?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    Connection cn = new Connection();
                    string query = "UPDATE produtos SET quantidade = quantidade - 1 WHERE id_produto = @id AND quantidade > 0";

                    try
                    {
                        cn.conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, cn.conn))
                        {
                            cmd.Parameters.AddWithValue("@id", produtoSelecionadoId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Quantidade diminuída com sucesso", "Diminuição de Unidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AtualizarDataGridView(); // Atualiza o DataGridView após a alteração
                            }
                            else
                            {
                                MessageBox.Show("A quantidade não pode ser menor que zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao diminuir a quantidade" , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        cn.conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto!", "Selecione para Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bt_remover_produto_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.SelectedRows.Count > 0) // Verifica se há alguma linha selecionada
            {
                DataGridViewRow selectedRow = dataGridViewProdutos.SelectedRows[0];
                int produtoSelecionadoId = Convert.ToInt32(selectedRow.Cells["id_produto"].Value);

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja remover este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    Connection cn = new Connection();
                    string query = "DELETE FROM produtos WHERE id_produto = @id";

                    try
                    {
                        cn.conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, cn.conn))
                        {
                            cmd.Parameters.AddWithValue("@id", produtoSelecionadoId);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Produto removido com sucesso!");
                            AtualizarDataGridView(); // Atualiza o DataGridView após a remoção
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao remover produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        cn.conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para remover!", "Selecione um Produto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bt_buscar_produtos_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            string query = "SELECT id_produto, categoria, nome_produto, quantidade, preco_produto, imagem_produto FROM produtos";

            try
            {
                cn.conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cn.conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Verifica se o DataGridView já tem colunas, se não, adiciona-as
                    if (dataGridViewProdutos.Columns.Count == 0)
                    {
                        // Coluna da imagem PRIMEIRO
                        DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                        imgColumn.Name = "imagem_produto";
                        imgColumn.HeaderText = "Imagem";
                        imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                        dataGridViewProdutos.Columns.Add(imgColumn);

                        // Outras colunas depois 
                        dataGridViewProdutos.Columns.Add("id_produto", "ID");
                        dataGridViewProdutos.Columns.Add("categoria", "Categoria");
                        dataGridViewProdutos.Columns.Add("nome_produto", "Nome do Produto");
                        dataGridViewProdutos.Columns.Add("quantidade", "Quantidade");
                        dataGridViewProdutos.Columns.Add("preco_produto", "Preço");

                        // Aumenta o tamanho das células para melhor exibição
                        dataGridViewProdutos.RowTemplate.Height = 100; // Linhas mais altas
                        dataGridViewProdutos.Columns["imagem_produto"].Width = 150; // Coluna de imagem mais larga
                    }


                    dataGridViewProdutos.Rows.Clear(); // Limpa os dados antigos

                    foreach (DataRow row in dt.Rows)
                    {
                        // Convertendo a imagem do banco de dados para um objeto Image
                        Image img = null;
                        if (row["imagem_produto"] != DBNull.Value)
                        {
                            byte[] imgBytes = (byte[])row["imagem_produto"];
                            using (MemoryStream ms = new MemoryStream(imgBytes))
                            {
                                img = Image.FromStream(ms);
                            }
                        }

                        // Adicionando os dados na linha do DataGridView
                        dataGridViewProdutos.Rows.Add(
                            img, // IMAGEM PRIMEIRO
                            row["id_produto"],
                            row["categoria"],
                            row["nome_produto"],
                            row["quantidade"],
                            row["preco_produto"]
                        );
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                cn.conn.Close();
            }
        }
    }
}
