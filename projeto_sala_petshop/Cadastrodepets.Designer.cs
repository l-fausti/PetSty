namespace projeto_sala_petshop
{
    partial class Cadastrodepets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrodepets));
            pn_cad_pets_adotivos = new Panel();
            picture_box_cad_pets = new PictureBox();
            panel2 = new Panel();
            headerLabel1 = new ReaLTaiizor.Controls.HeaderLabel();
            bt_voltar_cad_pets = new Button();
            bt_confirmar_cad_pets = new ReaLTaiizor.Controls.Button();
            tb_situacao_cad_pets = new ReaLTaiizor.Controls.DungeonRichTextBox();
            label6 = new Label();
            bt_load_img_cad_pets = new ReaLTaiizor.Controls.Button();
            bt_cadastrar_pets = new ReaLTaiizor.Controls.Button();
            bt_limpar_cad_pets = new ReaLTaiizor.Controls.Button();
            label5 = new Label();
            tb_raca_cad_pets = new ReaLTaiizor.Controls.DungeonRichTextBox();
            tb_porte_cad_pets = new ReaLTaiizor.Controls.DungeonRichTextBox();
            tb_especie_cad_pets = new ReaLTaiizor.Controls.DungeonRichTextBox();
            tb_nome_pet_cad_pets = new ReaLTaiizor.Controls.DungeonRichTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tb_descricao_cad_pets = new RichTextBox();
            pn_cad_pets_adotivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_box_cad_pets).BeginInit();
            SuspendLayout();
            // 
            // pn_cad_pets_adotivos
            // 
            pn_cad_pets_adotivos.BackColor = Color.White;
            pn_cad_pets_adotivos.Controls.Add(picture_box_cad_pets);
            pn_cad_pets_adotivos.Controls.Add(panel2);
            pn_cad_pets_adotivos.Controls.Add(headerLabel1);
            pn_cad_pets_adotivos.Controls.Add(bt_voltar_cad_pets);
            pn_cad_pets_adotivos.Controls.Add(bt_confirmar_cad_pets);
            pn_cad_pets_adotivos.Controls.Add(tb_situacao_cad_pets);
            pn_cad_pets_adotivos.Controls.Add(label6);
            pn_cad_pets_adotivos.Controls.Add(bt_load_img_cad_pets);
            pn_cad_pets_adotivos.Controls.Add(bt_cadastrar_pets);
            pn_cad_pets_adotivos.Controls.Add(bt_limpar_cad_pets);
            pn_cad_pets_adotivos.Controls.Add(label5);
            pn_cad_pets_adotivos.Controls.Add(tb_raca_cad_pets);
            pn_cad_pets_adotivos.Controls.Add(tb_porte_cad_pets);
            pn_cad_pets_adotivos.Controls.Add(tb_especie_cad_pets);
            pn_cad_pets_adotivos.Controls.Add(tb_nome_pet_cad_pets);
            pn_cad_pets_adotivos.Controls.Add(label4);
            pn_cad_pets_adotivos.Controls.Add(label3);
            pn_cad_pets_adotivos.Controls.Add(label2);
            pn_cad_pets_adotivos.Controls.Add(label1);
            pn_cad_pets_adotivos.Controls.Add(tb_descricao_cad_pets);
            pn_cad_pets_adotivos.Location = new Point(1, 0);
            pn_cad_pets_adotivos.Name = "pn_cad_pets_adotivos";
            pn_cad_pets_adotivos.Size = new Size(741, 505);
            pn_cad_pets_adotivos.TabIndex = 0;
            // 
            // picture_box_cad_pets
            // 
            picture_box_cad_pets.BackColor = Color.Transparent;
            picture_box_cad_pets.Location = new Point(121, 71);
            picture_box_cad_pets.Name = "picture_box_cad_pets";
            picture_box_cad_pets.Size = new Size(172, 186);
            picture_box_cad_pets.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_box_cad_pets.TabIndex = 61;
            picture_box_cad_pets.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(61, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(738, 1);
            panel2.TabIndex = 229;
            panel2.UseWaitCursor = true;
            // 
            // headerLabel1
            // 
            headerLabel1.AutoSize = true;
            headerLabel1.BackColor = Color.Transparent;
            headerLabel1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel1.ForeColor = Color.Black;
            headerLabel1.Location = new Point(64, 26);
            headerLabel1.Name = "headerLabel1";
            headerLabel1.Size = new Size(195, 18);
            headerLabel1.TabIndex = 228;
            headerLabel1.Text = "Cadastro de Pets Adotivos";
            // 
            // bt_voltar_cad_pets
            // 
            bt_voltar_cad_pets.BackColor = Color.Transparent;
            bt_voltar_cad_pets.FlatAppearance.BorderColor = Color.White;
            bt_voltar_cad_pets.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bt_voltar_cad_pets.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
            bt_voltar_cad_pets.Image = (Image)resources.GetObject("bt_voltar_cad_pets.Image");
            bt_voltar_cad_pets.Location = new Point(1, 17);
            bt_voltar_cad_pets.Name = "bt_voltar_cad_pets";
            bt_voltar_cad_pets.Size = new Size(57, 54);
            bt_voltar_cad_pets.TabIndex = 175;
            bt_voltar_cad_pets.UseVisualStyleBackColor = false;
            bt_voltar_cad_pets.Click += bt_voltar_cad_pets_Click;
            // 
            // bt_confirmar_cad_pets
            // 
            bt_confirmar_cad_pets.BackColor = Color.Transparent;
            bt_confirmar_cad_pets.BorderColor = SystemColors.GradientActiveCaption;
            bt_confirmar_cad_pets.EnteredBorderColor = SystemColors.GradientActiveCaption;
            bt_confirmar_cad_pets.EnteredColor = SystemColors.GradientActiveCaption;
            bt_confirmar_cad_pets.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_confirmar_cad_pets.Image = null;
            bt_confirmar_cad_pets.ImageAlign = ContentAlignment.MiddleLeft;
            bt_confirmar_cad_pets.InactiveColor = Color.FromArgb(32, 34, 37);
            bt_confirmar_cad_pets.Location = new Point(542, 266);
            bt_confirmar_cad_pets.Name = "bt_confirmar_cad_pets";
            bt_confirmar_cad_pets.PressedBorderColor = SystemColors.GradientActiveCaption;
            bt_confirmar_cad_pets.PressedColor = SystemColors.GradientActiveCaption;
            bt_confirmar_cad_pets.Size = new Size(90, 30);
            bt_confirmar_cad_pets.TabIndex = 227;
            bt_confirmar_cad_pets.Text = "Confirmar";
            bt_confirmar_cad_pets.TextAlignment = StringAlignment.Center;
            bt_confirmar_cad_pets.Click += bt_confirmar_cad_pets_Click;
            // 
            // tb_situacao_cad_pets
            // 
            tb_situacao_cad_pets.AutoWordSelection = false;
            tb_situacao_cad_pets.BackColor = Color.Transparent;
            tb_situacao_cad_pets.BorderColor = Color.FromArgb(180, 180, 180);
            tb_situacao_cad_pets.EdgeColor = SystemColors.GradientActiveCaption;
            tb_situacao_cad_pets.Font = new Font("Tahoma", 10F);
            tb_situacao_cad_pets.ForeColor = Color.FromArgb(76, 76, 76);
            tb_situacao_cad_pets.Location = new Point(435, 212);
            tb_situacao_cad_pets.Name = "tb_situacao_cad_pets";
            tb_situacao_cad_pets.ReadOnly = false;
            tb_situacao_cad_pets.Size = new Size(196, 27);
            tb_situacao_cad_pets.TabIndex = 226;
            tb_situacao_cad_pets.TextBackColor = Color.White;
            tb_situacao_cad_pets.WordWrap = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F);
            label6.Location = new Point(354, 222);
            label6.Name = "label6";
            label6.Size = new Size(69, 17);
            label6.TabIndex = 225;
            label6.Text = "Situação:";
            // 
            // bt_load_img_cad_pets
            // 
            bt_load_img_cad_pets.BackColor = Color.Transparent;
            bt_load_img_cad_pets.BorderColor = Color.Black;
            bt_load_img_cad_pets.EnteredBorderColor = Color.Black;
            bt_load_img_cad_pets.EnteredColor = Color.Black;
            bt_load_img_cad_pets.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_load_img_cad_pets.Image = null;
            bt_load_img_cad_pets.ImageAlign = ContentAlignment.MiddleLeft;
            bt_load_img_cad_pets.InactiveColor = SystemColors.GradientActiveCaption;
            bt_load_img_cad_pets.Location = new Point(148, 269);
            bt_load_img_cad_pets.Name = "bt_load_img_cad_pets";
            bt_load_img_cad_pets.PressedBorderColor = Color.FromArgb(165, 37, 37);
            bt_load_img_cad_pets.PressedColor = Color.FromArgb(165, 37, 37);
            bt_load_img_cad_pets.Size = new Size(109, 19);
            bt_load_img_cad_pets.TabIndex = 224;
            bt_load_img_cad_pets.Text = "Carregar imagem";
            bt_load_img_cad_pets.TextAlignment = StringAlignment.Center;
            bt_load_img_cad_pets.Click += bt_load_img_cad_pets_Click;
            // 
            // bt_cadastrar_pets
            // 
            bt_cadastrar_pets.BackColor = Color.Transparent;
            bt_cadastrar_pets.BorderColor = Color.FromArgb(32, 34, 37);
            bt_cadastrar_pets.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            bt_cadastrar_pets.EnteredColor = Color.FromArgb(32, 34, 37);
            bt_cadastrar_pets.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_cadastrar_pets.Image = null;
            bt_cadastrar_pets.ImageAlign = ContentAlignment.MiddleLeft;
            bt_cadastrar_pets.InactiveColor = SystemColors.GradientActiveCaption;
            bt_cadastrar_pets.Location = new Point(541, 438);
            bt_cadastrar_pets.Name = "bt_cadastrar_pets";
            bt_cadastrar_pets.PressedBorderColor = Color.FromArgb(165, 37, 37);
            bt_cadastrar_pets.PressedColor = Color.FromArgb(165, 37, 37);
            bt_cadastrar_pets.Size = new Size(90, 30);
            bt_cadastrar_pets.TabIndex = 223;
            bt_cadastrar_pets.Text = "Cadastrar";
            bt_cadastrar_pets.TextAlignment = StringAlignment.Center;
            bt_cadastrar_pets.Click += bt_cadastrar_pets_Click;
            // 
            // bt_limpar_cad_pets
            // 
            bt_limpar_cad_pets.BackColor = Color.Transparent;
            bt_limpar_cad_pets.BorderColor = SystemColors.GradientActiveCaption;
            bt_limpar_cad_pets.EnteredBorderColor = SystemColors.GradientActiveCaption;
            bt_limpar_cad_pets.EnteredColor = SystemColors.GradientActiveCaption;
            bt_limpar_cad_pets.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_limpar_cad_pets.Image = null;
            bt_limpar_cad_pets.ImageAlign = ContentAlignment.MiddleLeft;
            bt_limpar_cad_pets.InactiveColor = Color.FromArgb(32, 34, 37);
            bt_limpar_cad_pets.Location = new Point(435, 438);
            bt_limpar_cad_pets.Name = "bt_limpar_cad_pets";
            bt_limpar_cad_pets.PressedBorderColor = SystemColors.GradientActiveCaption;
            bt_limpar_cad_pets.PressedColor = SystemColors.GradientActiveCaption;
            bt_limpar_cad_pets.Size = new Size(90, 30);
            bt_limpar_cad_pets.TabIndex = 222;
            bt_limpar_cad_pets.Text = "Limpar";
            bt_limpar_cad_pets.TextAlignment = StringAlignment.Center;
            bt_limpar_cad_pets.Click += bt_limpar_cad_pets_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F);
            label5.Location = new Point(121, 296);
            label5.Name = "label5";
            label5.Size = new Size(79, 17);
            label5.TabIndex = 221;
            label5.Text = "Descrição:";
            // 
            // tb_raca_cad_pets
            // 
            tb_raca_cad_pets.AutoWordSelection = false;
            tb_raca_cad_pets.BackColor = Color.Transparent;
            tb_raca_cad_pets.BorderColor = Color.FromArgb(180, 180, 180);
            tb_raca_cad_pets.EdgeColor = SystemColors.GradientActiveCaption;
            tb_raca_cad_pets.Font = new Font("Tahoma", 10F);
            tb_raca_cad_pets.ForeColor = Color.FromArgb(76, 76, 76);
            tb_raca_cad_pets.Location = new Point(435, 176);
            tb_raca_cad_pets.Name = "tb_raca_cad_pets";
            tb_raca_cad_pets.ReadOnly = false;
            tb_raca_cad_pets.Size = new Size(196, 27);
            tb_raca_cad_pets.TabIndex = 219;
            tb_raca_cad_pets.TextBackColor = Color.White;
            tb_raca_cad_pets.WordWrap = true;
            // 
            // tb_porte_cad_pets
            // 
            tb_porte_cad_pets.AutoWordSelection = false;
            tb_porte_cad_pets.BackColor = Color.Transparent;
            tb_porte_cad_pets.BorderColor = Color.FromArgb(180, 180, 180);
            tb_porte_cad_pets.EdgeColor = SystemColors.GradientActiveCaption;
            tb_porte_cad_pets.Font = new Font("Tahoma", 10F);
            tb_porte_cad_pets.ForeColor = Color.FromArgb(76, 76, 76);
            tb_porte_cad_pets.Location = new Point(435, 140);
            tb_porte_cad_pets.Name = "tb_porte_cad_pets";
            tb_porte_cad_pets.ReadOnly = false;
            tb_porte_cad_pets.Size = new Size(196, 27);
            tb_porte_cad_pets.TabIndex = 216;
            tb_porte_cad_pets.TextBackColor = Color.White;
            tb_porte_cad_pets.WordWrap = true;
            // 
            // tb_especie_cad_pets
            // 
            tb_especie_cad_pets.AutoWordSelection = false;
            tb_especie_cad_pets.BackColor = Color.Transparent;
            tb_especie_cad_pets.BorderColor = Color.FromArgb(180, 180, 180);
            tb_especie_cad_pets.EdgeColor = SystemColors.GradientActiveCaption;
            tb_especie_cad_pets.Font = new Font("Tahoma", 10F);
            tb_especie_cad_pets.ForeColor = Color.FromArgb(76, 76, 76);
            tb_especie_cad_pets.Location = new Point(435, 107);
            tb_especie_cad_pets.Name = "tb_especie_cad_pets";
            tb_especie_cad_pets.ReadOnly = false;
            tb_especie_cad_pets.Size = new Size(196, 27);
            tb_especie_cad_pets.TabIndex = 214;
            tb_especie_cad_pets.TextBackColor = Color.White;
            tb_especie_cad_pets.WordWrap = true;
            // 
            // tb_nome_pet_cad_pets
            // 
            tb_nome_pet_cad_pets.AutoWordSelection = false;
            tb_nome_pet_cad_pets.BackColor = Color.Transparent;
            tb_nome_pet_cad_pets.BorderColor = Color.FromArgb(180, 180, 180);
            tb_nome_pet_cad_pets.EdgeColor = SystemColors.GradientActiveCaption;
            tb_nome_pet_cad_pets.Font = new Font("Tahoma", 10F);
            tb_nome_pet_cad_pets.ForeColor = Color.FromArgb(76, 76, 76);
            tb_nome_pet_cad_pets.Location = new Point(435, 71);
            tb_nome_pet_cad_pets.Name = "tb_nome_pet_cad_pets";
            tb_nome_pet_cad_pets.ReadOnly = false;
            tb_nome_pet_cad_pets.Size = new Size(196, 28);
            tb_nome_pet_cad_pets.TabIndex = 212;
            tb_nome_pet_cad_pets.TextBackColor = Color.White;
            tb_nome_pet_cad_pets.WordWrap = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F);
            label4.Location = new Point(376, 186);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 207;
            label4.Text = "Raça:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F);
            label3.Location = new Point(376, 150);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 206;
            label3.Text = "Porte:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F);
            label2.Location = new Point(364, 117);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 205;
            label2.Text = "Espécie:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(332, 82);
            label1.Name = "label1";
            label1.Size = new Size(97, 17);
            label1.TabIndex = 204;
            label1.Text = "Nome do Pet:";
            // 
            // tb_descricao_cad_pets
            // 
            tb_descricao_cad_pets.Font = new Font("Segoe UI", 9.75F);
            tb_descricao_cad_pets.Location = new Point(121, 316);
            tb_descricao_cad_pets.Name = "tb_descricao_cad_pets";
            tb_descricao_cad_pets.Size = new Size(510, 116);
            tb_descricao_cad_pets.TabIndex = 59;
            tb_descricao_cad_pets.Text = "";
            // 
            // Cadastrodepets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 504);
            Controls.Add(pn_cad_pets_adotivos);
            Name = "Cadastrodepets";
            Text = "Cadastrodepets";
            pn_cad_pets_adotivos.ResumeLayout(false);
            pn_cad_pets_adotivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_box_cad_pets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_cad_pets_adotivos;
        private RichTextBox tb_descricao_cad_pets;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.DungeonRichTextBox tb_nome_pet_cad_pets;
        private ReaLTaiizor.Controls.DungeonRichTextBox tb_raca_cad_pets;
        private ReaLTaiizor.Controls.DungeonRichTextBox tb_porte_cad_pets;
        private ReaLTaiizor.Controls.DungeonRichTextBox tb_especie_cad_pets;
        private Label label5;
        private ReaLTaiizor.Controls.Button bt_cadastrar_pets;
        private ReaLTaiizor.Controls.Button bt_limpar_cad_pets;
        private ReaLTaiizor.Controls.DungeonRichTextBox tb_situacao_cad_pets;
        private Label label6;
        private ReaLTaiizor.Controls.Button bt_load_img_cad_pets;
        private ReaLTaiizor.Controls.Button bt_confirmar_cad_pets;
        private Panel panel2;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel1;
        private Button bt_voltar_cad_pets;
        private PictureBox picture_box_cad_pets;
    }
}