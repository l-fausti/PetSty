namespace projeto_sala_petshop
{
    partial class Treinamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Treinamento));
            panel_passeio_caes = new Panel();
            tb_nr_pet = new TextBox();
            tb_nome_passeador = new TextBox();
            desc_ste = new Label();
            desc_nicollas = new Label();
            lb_guilherme = new Label();
            lb_ste = new Label();
            lb_nicollas = new Label();
            lb_lucas = new Label();
            desc_lucas = new Label();
            desc_guilherme = new Label();
            pictureBoxSte = new PictureBox();
            label5 = new Label();
            pictureBoxLucas = new PictureBox();
            pictureBoxNicollas = new PictureBox();
            pictureBoxGuilherme = new PictureBox();
            tb_base_nr_pet = new ReaLTaiizor.Controls.DungeonTextBox();
            label3 = new Label();
            tb_valor_pass = new MaskedTextBox();
            tb_tipo_caminhada = new ReaLTaiizor.Controls.DungeonComboBox();
            dt_agendamento_pass = new ReaLTaiizor.Controls.PoisonDateTime();
            label8 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            bt_selecionar_pass = new ReaLTaiizor.Controls.SkyButton();
            bt_agendamento_pass = new ReaLTaiizor.Controls.Button();
            bt_limpar_pass = new ReaLTaiizor.Controls.Button();
            rtb_confirmacao_pass = new ReaLTaiizor.Controls.HopeRichTextBox();
            panel2 = new Panel();
            headerLabel1 = new ReaLTaiizor.Controls.HeaderLabel();
            panel_passeio_caes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLucas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNicollas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGuilherme).BeginInit();
            SuspendLayout();
            // 
            // panel_passeio_caes
            // 
            panel_passeio_caes.Controls.Add(tb_nr_pet);
            panel_passeio_caes.Controls.Add(tb_nome_passeador);
            panel_passeio_caes.Controls.Add(desc_ste);
            panel_passeio_caes.Controls.Add(desc_nicollas);
            panel_passeio_caes.Controls.Add(lb_guilherme);
            panel_passeio_caes.Controls.Add(lb_ste);
            panel_passeio_caes.Controls.Add(lb_nicollas);
            panel_passeio_caes.Controls.Add(lb_lucas);
            panel_passeio_caes.Controls.Add(desc_lucas);
            panel_passeio_caes.Controls.Add(desc_guilherme);
            panel_passeio_caes.Controls.Add(pictureBoxSte);
            panel_passeio_caes.Controls.Add(label5);
            panel_passeio_caes.Controls.Add(pictureBoxLucas);
            panel_passeio_caes.Controls.Add(pictureBoxNicollas);
            panel_passeio_caes.Controls.Add(pictureBoxGuilherme);
            panel_passeio_caes.Controls.Add(tb_base_nr_pet);
            panel_passeio_caes.Controls.Add(label3);
            panel_passeio_caes.Controls.Add(tb_valor_pass);
            panel_passeio_caes.Controls.Add(tb_tipo_caminhada);
            panel_passeio_caes.Controls.Add(dt_agendamento_pass);
            panel_passeio_caes.Controls.Add(label8);
            panel_passeio_caes.Controls.Add(label4);
            panel_passeio_caes.Controls.Add(label2);
            panel_passeio_caes.Controls.Add(label1);
            panel_passeio_caes.Controls.Add(bt_selecionar_pass);
            panel_passeio_caes.Controls.Add(bt_agendamento_pass);
            panel_passeio_caes.Controls.Add(bt_limpar_pass);
            panel_passeio_caes.Controls.Add(rtb_confirmacao_pass);
            panel_passeio_caes.Controls.Add(panel2);
            panel_passeio_caes.Controls.Add(headerLabel1);
            panel_passeio_caes.Cursor = Cursors.Hand;
            panel_passeio_caes.Location = new Point(0, 0);
            panel_passeio_caes.Name = "panel_passeio_caes";
            panel_passeio_caes.Size = new Size(735, 501);
            panel_passeio_caes.TabIndex = 176;
            // 
            // tb_nr_pet
            // 
            tb_nr_pet.BorderStyle = BorderStyle.None;
            tb_nr_pet.Font = new Font("Segoe UI", 10F);
            tb_nr_pet.Location = new Point(229, 70);
            tb_nr_pet.Multiline = true;
            tb_nr_pet.Name = "tb_nr_pet";
            tb_nr_pet.Size = new Size(49, 21);
            tb_nr_pet.TabIndex = 256;
            tb_nr_pet.TextAlign = HorizontalAlignment.Center;
            tb_nr_pet.KeyPress += tb_nr_pet_KeyPress_1;
            // 
            // tb_nome_passeador
            // 
            tb_nome_passeador.BorderStyle = BorderStyle.None;
            tb_nome_passeador.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_nome_passeador.Location = new Point(187, 403);
            tb_nome_passeador.Multiline = true;
            tb_nome_passeador.Name = "tb_nome_passeador";
            tb_nome_passeador.Size = new Size(110, 15);
            tb_nome_passeador.TabIndex = 255;
            // 
            // desc_ste
            // 
            desc_ste.AutoSize = true;
            desc_ste.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            desc_ste.Location = new Point(509, 234);
            desc_ste.Name = "desc_ste";
            desc_ste.Size = new Size(124, 30);
            desc_ste.TabIndex = 253;
            desc_ste.Text = "Passeadora de cães \r\natenciosa e cuidadosa";
            desc_ste.Visible = false;
            // 
            // desc_nicollas
            // 
            desc_nicollas.AutoSize = true;
            desc_nicollas.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            desc_nicollas.Location = new Point(370, 233);
            desc_nicollas.Name = "desc_nicollas";
            desc_nicollas.Size = new Size(108, 30);
            desc_nicollas.TabIndex = 252;
            desc_nicollas.Text = "Passeador de cães \r\njovem e enérgico";
            desc_nicollas.Visible = false;
            // 
            // lb_guilherme
            // 
            lb_guilherme.AutoSize = true;
            lb_guilherme.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_guilherme.Location = new Point(381, 72);
            lb_guilherme.Name = "lb_guilherme";
            lb_guilherme.Size = new Size(101, 23);
            lb_guilherme.TabIndex = 251;
            lb_guilherme.Text = "Guilherme";
            lb_guilherme.Visible = false;
            // 
            // lb_ste
            // 
            lb_ste.AutoSize = true;
            lb_ste.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_ste.Location = new Point(524, 186);
            lb_ste.Name = "lb_ste";
            lb_ste.Size = new Size(100, 23);
            lb_ste.TabIndex = 250;
            lb_ste.Text = "Stephanie";
            lb_ste.Visible = false;
            // 
            // lb_nicollas
            // 
            lb_nicollas.AutoSize = true;
            lb_nicollas.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_nicollas.Location = new Point(390, 186);
            lb_nicollas.Name = "lb_nicollas";
            lb_nicollas.Size = new Size(81, 23);
            lb_nicollas.TabIndex = 249;
            lb_nicollas.Text = "Nicollas";
            lb_nicollas.Visible = false;
            // 
            // lb_lucas
            // 
            lb_lucas.AutoSize = true;
            lb_lucas.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_lucas.Location = new Point(540, 72);
            lb_lucas.Name = "lb_lucas";
            lb_lucas.Size = new Size(64, 23);
            lb_lucas.TabIndex = 248;
            lb_lucas.Text = "Lucas";
            lb_lucas.Visible = false;
            // 
            // desc_lucas
            // 
            desc_lucas.AutoSize = true;
            desc_lucas.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            desc_lucas.Location = new Point(514, 128);
            desc_lucas.Name = "desc_lucas";
            desc_lucas.Size = new Size(113, 30);
            desc_lucas.TabIndex = 247;
            desc_lucas.Text = "Passeador de cães \r\nexperiente e calmo";
            desc_lucas.Visible = false;
            // 
            // desc_guilherme
            // 
            desc_guilherme.AutoSize = true;
            desc_guilherme.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            desc_guilherme.Location = new Point(370, 128);
            desc_guilherme.Name = "desc_guilherme";
            desc_guilherme.Size = new Size(126, 30);
            desc_guilherme.TabIndex = 246;
            desc_guilherme.Text = "Passeador de cães \r\ndivertido e brincalhão";
            desc_guilherme.Visible = false;
            // 
            // pictureBoxSte
            // 
            pictureBoxSte.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxSte.Image = (Image)resources.GetObject("pictureBoxSte.Image");
            pictureBoxSte.Location = new Point(504, 183);
            pictureBoxSte.Name = "pictureBoxSte";
            pictureBoxSte.Size = new Size(142, 117);
            pictureBoxSte.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSte.TabIndex = 182;
            pictureBoxSte.TabStop = false;
            pictureBoxSte.Click += pictureBoxSte_Click;
            pictureBoxSte.Paint += pictureBoxSte_Paint;
            pictureBoxSte.MouseEnter += pictureBoxSte_MouseEnter;
            pictureBoxSte.MouseLeave += pictureBoxSte_MouseLeave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(413, 40);
            label5.Name = "label5";
            label5.Size = new Size(183, 18);
            label5.TabIndex = 244;
            label5.Text = "Passeador Responsável:";
            // 
            // pictureBoxLucas
            // 
            pictureBoxLucas.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxLucas.Image = (Image)resources.GetObject("pictureBoxLucas.Image");
            pictureBoxLucas.Location = new Point(504, 66);
            pictureBoxLucas.Name = "pictureBoxLucas";
            pictureBoxLucas.Size = new Size(142, 117);
            pictureBoxLucas.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLucas.TabIndex = 182;
            pictureBoxLucas.TabStop = false;
            pictureBoxLucas.Click += pictureBoxLucas_Click;
            pictureBoxLucas.Paint += pictureBoxLucas_Paint;
            pictureBoxLucas.MouseEnter += pictureBoxLucas_MouseEnter;
            pictureBoxLucas.MouseLeave += pictureBoxLucas_MouseLeave;
            // 
            // pictureBoxNicollas
            // 
            pictureBoxNicollas.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxNicollas.Image = (Image)resources.GetObject("pictureBoxNicollas.Image");
            pictureBoxNicollas.Location = new Point(361, 183);
            pictureBoxNicollas.Name = "pictureBoxNicollas";
            pictureBoxNicollas.Size = new Size(142, 117);
            pictureBoxNicollas.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxNicollas.TabIndex = 182;
            pictureBoxNicollas.TabStop = false;
            pictureBoxNicollas.Click += pictureBoxNicollas_Click;
            pictureBoxNicollas.Paint += pictureBoxNicollas_Paint;
            pictureBoxNicollas.MouseEnter += pictureBoxNicollas_MouseEnter;
            pictureBoxNicollas.MouseLeave += pictureBoxNicollas_MouseLeave;
            // 
            // pictureBoxGuilherme
            // 
            pictureBoxGuilherme.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxGuilherme.Image = (Image)resources.GetObject("pictureBoxGuilherme.Image");
            pictureBoxGuilherme.Location = new Point(361, 66);
            pictureBoxGuilherme.Name = "pictureBoxGuilherme";
            pictureBoxGuilherme.Size = new Size(142, 117);
            pictureBoxGuilherme.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGuilherme.TabIndex = 181;
            pictureBoxGuilherme.TabStop = false;
            pictureBoxGuilherme.Click += pictureBoxGuilherme_Click;
            pictureBoxGuilherme.Paint += pictureBoxGuilherme_Paint;
            pictureBoxGuilherme.MouseEnter += pictureBoxGuilherme_MouseEnter;
            pictureBoxGuilherme.MouseLeave += pictureBoxGuilherme_MouseLeave;
            // 
            // tb_base_nr_pet
            // 
            tb_base_nr_pet.BackColor = Color.Transparent;
            tb_base_nr_pet.BorderColor = SystemColors.GradientActiveCaption;
            tb_base_nr_pet.EdgeColor = Color.White;
            tb_base_nr_pet.Font = new Font("Tahoma", 11F);
            tb_base_nr_pet.ForeColor = Color.DimGray;
            tb_base_nr_pet.Location = new Point(224, 66);
            tb_base_nr_pet.MaxLength = 32767;
            tb_base_nr_pet.Multiline = false;
            tb_base_nr_pet.Name = "tb_base_nr_pet";
            tb_base_nr_pet.ReadOnly = false;
            tb_base_nr_pet.Size = new Size(61, 28);
            tb_base_nr_pet.TabIndex = 243;
            tb_base_nr_pet.TextAlignment = HorizontalAlignment.Left;
            tb_base_nr_pet.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(200, 282);
            label3.Name = "label3";
            label3.Size = new Size(29, 21);
            label3.TabIndex = 242;
            label3.Text = "R$";
            // 
            // tb_valor_pass
            // 
            tb_valor_pass.AllowDrop = true;
            tb_valor_pass.BackColor = SystemColors.GradientActiveCaption;
            tb_valor_pass.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_valor_pass.Location = new Point(229, 277);
            tb_valor_pass.Name = "tb_valor_pass";
            tb_valor_pass.ReadOnly = true;
            tb_valor_pass.Size = new Size(93, 26);
            tb_valor_pass.TabIndex = 241;
            // 
            // tb_tipo_caminhada
            // 
            tb_tipo_caminhada.BackColor = Color.White;
            tb_tipo_caminhada.ColorA = Color.Empty;
            tb_tipo_caminhada.ColorB = SystemColors.GradientActiveCaption;
            tb_tipo_caminhada.ColorC = SystemColors.GradientActiveCaption;
            tb_tipo_caminhada.ColorD = Color.White;
            tb_tipo_caminhada.ColorE = Color.White;
            tb_tipo_caminhada.ColorF = SystemColors.GradientActiveCaption;
            tb_tipo_caminhada.ColorG = SystemColors.GradientActiveCaption;
            tb_tipo_caminhada.ColorH = SystemColors.GradientActiveCaption;
            tb_tipo_caminhada.ColorI = Color.White;
            tb_tipo_caminhada.DrawMode = DrawMode.OwnerDrawFixed;
            tb_tipo_caminhada.DropDownHeight = 100;
            tb_tipo_caminhada.DropDownStyle = ComboBoxStyle.DropDownList;
            tb_tipo_caminhada.Font = new Font("Segoe UI", 10F);
            tb_tipo_caminhada.ForeColor = Color.Black;
            tb_tipo_caminhada.FormattingEnabled = true;
            tb_tipo_caminhada.HoverSelectionColor = Color.FromArgb(224, 224, 224);
            tb_tipo_caminhada.IntegralHeight = false;
            tb_tipo_caminhada.ItemHeight = 20;
            tb_tipo_caminhada.Items.AddRange(new object[] { "", "Leve", "Moderada", "Trote" });
            tb_tipo_caminhada.Location = new Point(151, 104);
            tb_tipo_caminhada.Name = "tb_tipo_caminhada";
            tb_tipo_caminhada.Size = new Size(168, 26);
            tb_tipo_caminhada.StartIndex = 0;
            tb_tipo_caminhada.TabIndex = 240;
            tb_tipo_caminhada.SelectedIndexChanged += tb_tipo_caminhada_SelectedIndexChanged;
            // 
            // dt_agendamento_pass
            // 
            dt_agendamento_pass.CalendarForeColor = SystemColors.GradientActiveCaption;
            dt_agendamento_pass.CalendarMonthBackground = SystemColors.GradientActiveCaption;
            dt_agendamento_pass.CalendarTitleBackColor = Color.RoyalBlue;
            dt_agendamento_pass.CalendarTitleForeColor = Color.RoyalBlue;
            dt_agendamento_pass.CalendarTrailingForeColor = Color.RoyalBlue;
            dt_agendamento_pass.Location = new Point(151, 139);
            dt_agendamento_pass.MinimumSize = new Size(0, 29);
            dt_agendamento_pass.Name = "dt_agendamento_pass";
            dt_agendamento_pass.Size = new Size(168, 29);
            dt_agendamento_pass.TabIndex = 239;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 11.25F);
            label8.Location = new Point(160, 285);
            label8.Name = "label8";
            label8.Size = new Size(44, 17);
            label8.TabIndex = 231;
            label8.Text = "Valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F);
            label4.Location = new Point(98, 146);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 230;
            label4.Text = "Data:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F);
            label2.Location = new Point(7, 107);
            label2.Name = "label2";
            label2.Size = new Size(138, 17);
            label2.TabIndex = 228;
            label2.Text = "Tipo de Caminhada:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 70);
            label1.Name = "label1";
            label1.Size = new Size(189, 17);
            label1.TabIndex = 227;
            label1.Text = "Número de Registro do Pet:";
            // 
            // bt_selecionar_pass
            // 
            bt_selecionar_pass.BackColor = Color.Transparent;
            bt_selecionar_pass.DownBGColorA = Color.FromArgb(70, 153, 205);
            bt_selecionar_pass.DownBGColorB = Color.FromArgb(53, 124, 170);
            bt_selecionar_pass.DownBorderColorA = Color.FromArgb(88, 168, 221);
            bt_selecionar_pass.DownBorderColorB = Color.FromArgb(76, 149, 194);
            bt_selecionar_pass.DownBorderColorC = Color.FromArgb(38, 93, 131);
            bt_selecionar_pass.DownBorderColorD = Color.FromArgb(200, 25, 73, 109);
            bt_selecionar_pass.DownForeColor = Color.White;
            bt_selecionar_pass.DownShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            bt_selecionar_pass.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_selecionar_pass.ForeColor = Color.FromArgb(27, 94, 137);
            bt_selecionar_pass.HoverBGColorA = Color.FromArgb(70, 153, 205);
            bt_selecionar_pass.HoverBGColorB = Color.FromArgb(53, 124, 170);
            bt_selecionar_pass.HoverBorderColorA = Color.FromArgb(88, 168, 221);
            bt_selecionar_pass.HoverBorderColorB = Color.FromArgb(76, 149, 194);
            bt_selecionar_pass.HoverBorderColorC = Color.FromArgb(38, 93, 131);
            bt_selecionar_pass.HoverBorderColorD = Color.FromArgb(200, 25, 73, 109);
            bt_selecionar_pass.HoverForeColor = Color.White;
            bt_selecionar_pass.HoverShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            bt_selecionar_pass.Location = new Point(551, 309);
            bt_selecionar_pass.Name = "bt_selecionar_pass";
            bt_selecionar_pass.NormalBGColorA = Color.FromArgb(245, 245, 245);
            bt_selecionar_pass.NormalBGColorB = Color.FromArgb(230, 230, 230);
            bt_selecionar_pass.NormalBorderColorA = Color.FromArgb(252, 252, 252);
            bt_selecionar_pass.NormalBorderColorB = Color.FromArgb(249, 249, 249);
            bt_selecionar_pass.NormalBorderColorC = Color.FromArgb(189, 189, 189);
            bt_selecionar_pass.NormalBorderColorD = Color.FromArgb(200, 168, 168, 168);
            bt_selecionar_pass.NormalForeColor = Color.FromArgb(27, 94, 137);
            bt_selecionar_pass.NormalShadowForeColor = Color.FromArgb(200, 255, 255, 255);
            bt_selecionar_pass.Size = new Size(95, 29);
            bt_selecionar_pass.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            bt_selecionar_pass.TabIndex = 189;
            bt_selecionar_pass.Text = "Selecionar";
            bt_selecionar_pass.Click += bt_selecionar_pass_Click;
            // 
            // bt_agendamento_pass
            // 
            bt_agendamento_pass.BackColor = Color.Transparent;
            bt_agendamento_pass.BorderColor = Color.FromArgb(32, 34, 37);
            bt_agendamento_pass.EnteredBorderColor = SystemColors.GradientActiveCaption;
            bt_agendamento_pass.EnteredColor = Color.FromArgb(32, 34, 37);
            bt_agendamento_pass.Font = new Font("Microsoft Sans Serif", 12F);
            bt_agendamento_pass.Image = null;
            bt_agendamento_pass.ImageAlign = ContentAlignment.MiddleLeft;
            bt_agendamento_pass.InactiveColor = Color.FromArgb(32, 34, 37);
            bt_agendamento_pass.Location = new Point(557, 458);
            bt_agendamento_pass.Name = "bt_agendamento_pass";
            bt_agendamento_pass.PressedBorderColor = SystemColors.GradientActiveCaption;
            bt_agendamento_pass.PressedColor = SystemColors.GradientActiveCaption;
            bt_agendamento_pass.Size = new Size(90, 30);
            bt_agendamento_pass.TabIndex = 187;
            bt_agendamento_pass.Text = "Agendar";
            bt_agendamento_pass.TextAlignment = StringAlignment.Center;
            bt_agendamento_pass.Click += bt_agendamento_pass_Click;
            // 
            // bt_limpar_pass
            // 
            bt_limpar_pass.BackColor = Color.Transparent;
            bt_limpar_pass.BorderColor = Color.FromArgb(32, 34, 37);
            bt_limpar_pass.EnteredBorderColor = SystemColors.GradientActiveCaption;
            bt_limpar_pass.EnteredColor = Color.FromArgb(32, 34, 37);
            bt_limpar_pass.Font = new Font("Microsoft Sans Serif", 12F);
            bt_limpar_pass.Image = null;
            bt_limpar_pass.ImageAlign = ContentAlignment.MiddleLeft;
            bt_limpar_pass.InactiveColor = Color.FromArgb(32, 34, 37);
            bt_limpar_pass.Location = new Point(459, 458);
            bt_limpar_pass.Name = "bt_limpar_pass";
            bt_limpar_pass.PressedBorderColor = SystemColors.GradientActiveCaption;
            bt_limpar_pass.PressedColor = SystemColors.GradientActiveCaption;
            bt_limpar_pass.Size = new Size(90, 30);
            bt_limpar_pass.TabIndex = 186;
            bt_limpar_pass.Text = "Limpar";
            bt_limpar_pass.TextAlignment = StringAlignment.Center;
            bt_limpar_pass.Click += bt_limpar_pass_Click;
            // 
            // rtb_confirmacao_pass
            // 
            rtb_confirmacao_pass.BorderColor = Color.FromArgb(220, 223, 230);
            rtb_confirmacao_pass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtb_confirmacao_pass.ForeColor = Color.FromArgb(48, 49, 51);
            rtb_confirmacao_pass.Hint = "";
            rtb_confirmacao_pass.HoverBorderColor = Color.FromArgb(64, 158, 255);
            rtb_confirmacao_pass.Location = new Point(12, 344);
            rtb_confirmacao_pass.MaxLength = 32767;
            rtb_confirmacao_pass.Multiline = true;
            rtb_confirmacao_pass.Name = "rtb_confirmacao_pass";
            rtb_confirmacao_pass.PasswordChar = '\0';
            rtb_confirmacao_pass.ScrollBars = ScrollBars.None;
            rtb_confirmacao_pass.SelectedText = "";
            rtb_confirmacao_pass.SelectionLength = 0;
            rtb_confirmacao_pass.SelectionStart = 0;
            rtb_confirmacao_pass.Size = new Size(635, 106);
            rtb_confirmacao_pass.TabIndex = 185;
            rtb_confirmacao_pass.TabStop = false;
            rtb_confirmacao_pass.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.NavajoWhite;
            panel2.Location = new Point(-7, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(843, 10);
            panel2.TabIndex = 178;
            panel2.UseWaitCursor = true;
            // 
            // headerLabel1
            // 
            headerLabel1.AutoSize = true;
            headerLabel1.BackColor = Color.Transparent;
            headerLabel1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel1.ForeColor = Color.Black;
            headerLabel1.Location = new Point(15, 9);
            headerLabel1.Name = "headerLabel1";
            headerLabel1.Size = new Size(126, 18);
            headerLabel1.TabIndex = 177;
            headerLabel1.Text = "Passeio de Cães";
            // 
            // Treinamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(736, 498);
            Controls.Add(panel_passeio_caes);
            Name = "Treinamento";
            Text = "Passeio de Cães";
            panel_passeio_caes.ResumeLayout(false);
            panel_passeio_caes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSte).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLucas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNicollas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGuilherme).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_passeio_caes;
        private Panel panel2;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel1;
        private ReaLTaiizor.Controls.Button bt_agendamento_pass;
        private ReaLTaiizor.Controls.Button bt_limpar_pass;
        private ReaLTaiizor.Controls.SkyButton bt_selecionar_pass;
        private Label label8;
        private Label label4;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.PoisonDateTime dt_agendamento_pass;
        private ReaLTaiizor.Controls.DungeonComboBox tb_tipo_caminhada;
        private Label label3;
        private MaskedTextBox tb_valor_pass;
        private ReaLTaiizor.Controls.DungeonTextBox tb_base_nr_pet;
        private Label label5;
        private Label desc_guilherme;
        private PictureBox pictureBoxSte;
        private PictureBox pictureBoxLucas;
        private PictureBox pictureBoxNicollas;
        private PictureBox pictureBoxGuilherme;
        private Label lb_guilherme;
        private Label lb_ste;
        private Label lb_nicollas;
        private Label lb_lucas;
        private Label desc_lucas;
        private Label desc_ste;
        private Label desc_nicollas;
        private TextBox tb_nome_passeador;
        private ReaLTaiizor.Controls.HopeRichTextBox rtb_confirmacao_pass;
        private TextBox tb_nr_pet;
    }
}