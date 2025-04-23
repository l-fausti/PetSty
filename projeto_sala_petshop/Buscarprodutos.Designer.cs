namespace projeto_sala_petshop
{
    partial class Buscarprodutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt_remover_produto = new ReaLTaiizor.Controls.Button();
            bt_remover_unidade = new ReaLTaiizor.Controls.Button();
            bt_adicionar_unidade = new ReaLTaiizor.Controls.Button();
            bt_buscar_produtos = new ReaLTaiizor.Controls.Button();
            panel3 = new Panel();
            panel2 = new Panel();
            dataGridViewProdutos = new DataGridView();
            headerLabel1 = new ReaLTaiizor.Controls.HeaderLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            SuspendLayout();
            // 
            // bt_remover_produto
            // 
            bt_remover_produto.BackColor = Color.Transparent;
            bt_remover_produto.BorderColor = Color.FromArgb(165, 37, 37);
            bt_remover_produto.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            bt_remover_produto.EnteredColor = Color.FromArgb(165, 37, 37);
            bt_remover_produto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_remover_produto.Image = null;
            bt_remover_produto.ImageAlign = ContentAlignment.MiddleLeft;
            bt_remover_produto.InactiveColor = Color.FromArgb(165, 37, 37);
            bt_remover_produto.Location = new Point(464, 454);
            bt_remover_produto.Name = "bt_remover_produto";
            bt_remover_produto.PressedBorderColor = Color.FromArgb(165, 37, 37);
            bt_remover_produto.PressedColor = Color.FromArgb(165, 37, 37);
            bt_remover_produto.Size = new Size(169, 30);
            bt_remover_produto.TabIndex = 202;
            bt_remover_produto.Text = "Remover Produto";
            bt_remover_produto.TextAlignment = StringAlignment.Center;
            bt_remover_produto.Click += bt_remover_produto_Click;
            // 
            // bt_remover_unidade
            // 
            bt_remover_unidade.BackColor = Color.Transparent;
            bt_remover_unidade.BorderColor = Color.FromArgb(32, 34, 37);
            bt_remover_unidade.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            bt_remover_unidade.EnteredColor = Color.FromArgb(32, 34, 37);
            bt_remover_unidade.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_remover_unidade.Image = null;
            bt_remover_unidade.ImageAlign = ContentAlignment.MiddleLeft;
            bt_remover_unidade.InactiveColor = Color.FromArgb(32, 34, 37);
            bt_remover_unidade.Location = new Point(464, 74);
            bt_remover_unidade.Name = "bt_remover_unidade";
            bt_remover_unidade.PressedBorderColor = Color.FromArgb(165, 37, 37);
            bt_remover_unidade.PressedColor = Color.FromArgb(165, 37, 37);
            bt_remover_unidade.Size = new Size(169, 30);
            bt_remover_unidade.TabIndex = 201;
            bt_remover_unidade.Text = "Remover Unidade -";
            bt_remover_unidade.TextAlignment = StringAlignment.Center;
            bt_remover_unidade.Click += bt_remover_unidade_Click;
            // 
            // bt_adicionar_unidade
            // 
            bt_adicionar_unidade.BackColor = Color.Transparent;
            bt_adicionar_unidade.BorderColor = Color.FromArgb(32, 34, 37);
            bt_adicionar_unidade.EnteredBorderColor = Color.Lime;
            bt_adicionar_unidade.EnteredColor = Color.FromArgb(32, 34, 37);
            bt_adicionar_unidade.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_adicionar_unidade.Image = null;
            bt_adicionar_unidade.ImageAlign = ContentAlignment.MiddleLeft;
            bt_adicionar_unidade.InactiveColor = Color.FromArgb(32, 34, 37);
            bt_adicionar_unidade.Location = new Point(244, 74);
            bt_adicionar_unidade.Name = "bt_adicionar_unidade";
            bt_adicionar_unidade.PressedBorderColor = Color.Lime;
            bt_adicionar_unidade.PressedColor = Color.Lime;
            bt_adicionar_unidade.Size = new Size(169, 30);
            bt_adicionar_unidade.TabIndex = 200;
            bt_adicionar_unidade.Text = "Adicionar Unidade +";
            bt_adicionar_unidade.TextAlignment = StringAlignment.Center;
            bt_adicionar_unidade.Click += bt_adicionar_unidade_Click;
            // 
            // bt_buscar_produtos
            // 
            bt_buscar_produtos.BackColor = Color.Transparent;
            bt_buscar_produtos.BorderColor = Color.FromArgb(32, 34, 37);
            bt_buscar_produtos.EnteredBorderColor = Color.Gold;
            bt_buscar_produtos.EnteredColor = Color.FromArgb(32, 34, 37);
            bt_buscar_produtos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_buscar_produtos.Image = null;
            bt_buscar_produtos.ImageAlign = ContentAlignment.MiddleLeft;
            bt_buscar_produtos.InactiveColor = Color.Gray;
            bt_buscar_produtos.Location = new Point(25, 74);
            bt_buscar_produtos.Name = "bt_buscar_produtos";
            bt_buscar_produtos.PressedBorderColor = Color.Gold;
            bt_buscar_produtos.PressedColor = Color.Gold;
            bt_buscar_produtos.Size = new Size(149, 30);
            bt_buscar_produtos.TabIndex = 199;
            bt_buscar_produtos.Text = "Buscar Produtos";
            bt_buscar_produtos.TextAlignment = StringAlignment.Center;
            bt_buscar_produtos.Click += bt_buscar_produtos_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(22, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(611, 10);
            panel3.TabIndex = 198;
            panel3.UseWaitCursor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(1, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(680, 10);
            panel2.TabIndex = 196;
            panel2.UseWaitCursor = true;
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.BackgroundColor = Color.Azure;
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Location = new Point(25, 129);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.Size = new Size(608, 319);
            dataGridViewProdutos.TabIndex = 194;
            // 
            // headerLabel1
            // 
            headerLabel1.AutoSize = true;
            headerLabel1.BackColor = Color.Transparent;
            headerLabel1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel1.ForeColor = Color.Black;
            headerLabel1.Location = new Point(12, 20);
            headerLabel1.Name = "headerLabel1";
            headerLabel1.Size = new Size(143, 18);
            headerLabel1.TabIndex = 195;
            headerLabel1.Text = "Busca de Produtos";
            // 
            // Buscarprodutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(658, 539);
            Controls.Add(bt_remover_produto);
            Controls.Add(bt_remover_unidade);
            Controls.Add(bt_adicionar_unidade);
            Controls.Add(bt_buscar_produtos);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dataGridViewProdutos);
            Controls.Add(headerLabel1);
            Name = "Buscarprodutos";
            Text = "Buscarprodutos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.Button bt_remover_produto;
        private ReaLTaiizor.Controls.Button bt_remover_unidade;
        private ReaLTaiizor.Controls.Button bt_adicionar_unidade;
        private ReaLTaiizor.Controls.Button bt_buscar_produtos;
        private Panel panel3;
        private Panel panel2;
        private DataGridView dataGridViewProdutos;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel1;
    }
}