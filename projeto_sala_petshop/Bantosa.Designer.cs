namespace projeto_sala_petshop
{
    partial class Bantosa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bantosa));
            panel_bantosa = new Panel();
            panel1 = new Panel();
            headerLabel3 = new ReaLTaiizor.Controls.HeaderLabel();
            bt_confirmar_bant = new ReaLTaiizor.Controls.Button();
            bt_cancelar_bant = new ReaLTaiizor.Controls.Button();
            bt_agendamento_bant = new ReaLTaiizor.Controls.Button();
            bt_limpar_bant = new ReaLTaiizor.Controls.Button();
            panel_bant = new Panel();
            label1 = new Label();
            tb_numero_registro_bant = new TextBox();
            skyLabel5 = new ReaLTaiizor.Controls.SkyLabel();
            skyLabel4 = new ReaLTaiizor.Controls.SkyLabel();
            lb_veterinário = new ReaLTaiizor.Controls.SkyLabel();
            skyLabel2 = new ReaLTaiizor.Controls.SkyLabel();
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            dt_agendamento_bant = new ReaLTaiizor.Controls.PoisonDateTime();
            cb_ban_responsavel_bant = new ReaLTaiizor.Controls.SkyComboBox();
            cb_tipo_tosa_bant = new ReaLTaiizor.Controls.SkyComboBox();
            tb_valor_bant = new MaskedTextBox();
            tb_confirm_consulta_bant = new RichTextBox();
            bt_voltar_bant = new Button();
            panel_bantosa.SuspendLayout();
            panel_bant.SuspendLayout();
            SuspendLayout();
            // 
            // panel_bantosa
            // 
            panel_bantosa.BackColor = Color.White;
            panel_bantosa.Controls.Add(panel1);
            panel_bantosa.Controls.Add(headerLabel3);
            panel_bantosa.Controls.Add(bt_confirmar_bant);
            panel_bantosa.Controls.Add(bt_cancelar_bant);
            panel_bantosa.Controls.Add(bt_agendamento_bant);
            panel_bantosa.Controls.Add(bt_limpar_bant);
            panel_bantosa.Controls.Add(panel_bant);
            panel_bantosa.Controls.Add(tb_confirm_consulta_bant);
            panel_bantosa.Controls.Add(bt_voltar_bant);
            panel_bantosa.Location = new Point(0, 0);
            panel_bantosa.Name = "panel_bantosa";
            panel_bantosa.Size = new Size(738, 501);
            panel_bantosa.TabIndex = 51;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(-3, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 1);
            panel1.TabIndex = 97;
            panel1.UseWaitCursor = true;
            // 
            // headerLabel3
            // 
            headerLabel3.AutoSize = true;
            headerLabel3.BackColor = Color.Transparent;
            headerLabel3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel3.ForeColor = Color.Black;
            headerLabel3.Location = new Point(4, 28);
            headerLabel3.Name = "headerLabel3";
            headerLabel3.Size = new Size(105, 18);
            headerLabel3.TabIndex = 96;
            headerLabel3.Text = "Banho e Tosa";
            // 
            // bt_confirmar_bant
            // 
            bt_confirmar_bant.BackColor = Color.Transparent;
            bt_confirmar_bant.BorderColor = Color.FromArgb(32, 34, 37);
            bt_confirmar_bant.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            bt_confirmar_bant.EnteredColor = Color.FromArgb(32, 34, 37);
            bt_confirmar_bant.Font = new Font("Microsoft Sans Serif", 12F);
            bt_confirmar_bant.Image = null;
            bt_confirmar_bant.ImageAlign = ContentAlignment.MiddleLeft;
            bt_confirmar_bant.InactiveColor = Color.FromArgb(32, 34, 37);
            bt_confirmar_bant.Location = new Point(531, 454);
            bt_confirmar_bant.Name = "bt_confirmar_bant";
            bt_confirmar_bant.PressedBorderColor = Color.FromArgb(165, 37, 37);
            bt_confirmar_bant.PressedColor = Color.FromArgb(165, 37, 37);
            bt_confirmar_bant.Size = new Size(90, 30);
            bt_confirmar_bant.TabIndex = 95;
            bt_confirmar_bant.Text = "Confirmar";
            bt_confirmar_bant.TextAlignment = StringAlignment.Center;
            bt_confirmar_bant.Click += bt_confirmar_bant_Click;
            // 
            // bt_cancelar_bant
            // 
            bt_cancelar_bant.BackColor = Color.Transparent;
            bt_cancelar_bant.BorderColor = Color.FromArgb(32, 34, 37);
            bt_cancelar_bant.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            bt_cancelar_bant.EnteredColor = Color.FromArgb(32, 34, 37);
            bt_cancelar_bant.Font = new Font("Microsoft Sans Serif", 12F);
            bt_cancelar_bant.Image = null;
            bt_cancelar_bant.ImageAlign = ContentAlignment.MiddleLeft;
            bt_cancelar_bant.InactiveColor = Color.FromArgb(32, 34, 37);
            bt_cancelar_bant.Location = new Point(420, 454);
            bt_cancelar_bant.Name = "bt_cancelar_bant";
            bt_cancelar_bant.PressedBorderColor = Color.FromArgb(165, 37, 37);
            bt_cancelar_bant.PressedColor = Color.FromArgb(165, 37, 37);
            bt_cancelar_bant.Size = new Size(90, 30);
            bt_cancelar_bant.TabIndex = 94;
            bt_cancelar_bant.Text = "Cancelar";
            bt_cancelar_bant.TextAlignment = StringAlignment.Center;
            bt_cancelar_bant.Click += bt_cancelar_bant_Click;
            // 
            // bt_agendamento_bant
            // 
            bt_agendamento_bant.BackColor = Color.Transparent;
            bt_agendamento_bant.BorderColor = Color.FromArgb(32, 34, 37);
            bt_agendamento_bant.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            bt_agendamento_bant.EnteredColor = Color.FromArgb(32, 34, 37);
            bt_agendamento_bant.Font = new Font("Microsoft Sans Serif", 12F);
            bt_agendamento_bant.Image = null;
            bt_agendamento_bant.ImageAlign = ContentAlignment.MiddleLeft;
            bt_agendamento_bant.InactiveColor = Color.FromArgb(32, 34, 37);
            bt_agendamento_bant.Location = new Point(531, 288);
            bt_agendamento_bant.Name = "bt_agendamento_bant";
            bt_agendamento_bant.PressedBorderColor = Color.FromArgb(165, 37, 37);
            bt_agendamento_bant.PressedColor = Color.FromArgb(165, 37, 37);
            bt_agendamento_bant.Size = new Size(90, 30);
            bt_agendamento_bant.TabIndex = 93;
            bt_agendamento_bant.Text = "Agendar";
            bt_agendamento_bant.TextAlignment = StringAlignment.Center;
            bt_agendamento_bant.Click += bt_agendamento_bant_Click;
            // 
            // bt_limpar_bant
            // 
            bt_limpar_bant.BackColor = Color.Transparent;
            bt_limpar_bant.BorderColor = Color.FromArgb(32, 34, 37);
            bt_limpar_bant.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            bt_limpar_bant.EnteredColor = Color.FromArgb(32, 34, 37);
            bt_limpar_bant.Font = new Font("Microsoft Sans Serif", 12F);
            bt_limpar_bant.Image = null;
            bt_limpar_bant.ImageAlign = ContentAlignment.MiddleLeft;
            bt_limpar_bant.InactiveColor = Color.FromArgb(32, 34, 37);
            bt_limpar_bant.Location = new Point(420, 288);
            bt_limpar_bant.Name = "bt_limpar_bant";
            bt_limpar_bant.PressedBorderColor = Color.FromArgb(165, 37, 37);
            bt_limpar_bant.PressedColor = Color.FromArgb(165, 37, 37);
            bt_limpar_bant.Size = new Size(90, 30);
            bt_limpar_bant.TabIndex = 92;
            bt_limpar_bant.Text = "Limpar";
            bt_limpar_bant.TextAlignment = StringAlignment.Center;
            bt_limpar_bant.Click += bt_limpar_bant_Click;
            // 
            // panel_bant
            // 
            panel_bant.BackColor = Color.SeaShell;
            panel_bant.Controls.Add(label1);
            panel_bant.Controls.Add(tb_numero_registro_bant);
            panel_bant.Controls.Add(skyLabel5);
            panel_bant.Controls.Add(skyLabel4);
            panel_bant.Controls.Add(lb_veterinário);
            panel_bant.Controls.Add(skyLabel2);
            panel_bant.Controls.Add(skyLabel1);
            panel_bant.Controls.Add(dt_agendamento_bant);
            panel_bant.Controls.Add(cb_ban_responsavel_bant);
            panel_bant.Controls.Add(cb_tipo_tosa_bant);
            panel_bant.Controls.Add(tb_valor_bant);
            panel_bant.ForeColor = Color.White;
            panel_bant.Location = new Point(107, 74);
            panel_bant.Name = "panel_bant";
            panel_bant.Size = new Size(514, 198);
            panel_bant.TabIndex = 91;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(220, 165);
            label1.Name = "label1";
            label1.Size = new Size(29, 21);
            label1.TabIndex = 98;
            label1.Text = "R$";
            // 
            // tb_numero_registro_bant
            // 
            tb_numero_registro_bant.BackColor = Color.Thistle;
            tb_numero_registro_bant.BorderStyle = BorderStyle.FixedSingle;
            tb_numero_registro_bant.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_numero_registro_bant.ForeColor = Color.Black;
            tb_numero_registro_bant.Location = new Point(26, 32);
            tb_numero_registro_bant.Multiline = true;
            tb_numero_registro_bant.Name = "tb_numero_registro_bant";
            tb_numero_registro_bant.Size = new Size(59, 29);
            tb_numero_registro_bant.TabIndex = 109;
            tb_numero_registro_bant.TextAlign = HorizontalAlignment.Center;
            tb_numero_registro_bant.KeyPress += tb_numero_registro_KeyPress;
            // 
            // skyLabel5
            // 
            skyLabel5.AutoSize = true;
            skyLabel5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            skyLabel5.ForeColor = Color.FromArgb(27, 94, 137);
            skyLabel5.Location = new Point(255, 137);
            skyLabel5.Name = "skyLabel5";
            skyLabel5.Size = new Size(40, 16);
            skyLabel5.TabIndex = 108;
            skyLabel5.Text = "Valor";
            // 
            // skyLabel4
            // 
            skyLabel4.AutoSize = true;
            skyLabel4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            skyLabel4.ForeColor = Color.FromArgb(27, 94, 137);
            skyLabel4.Location = new Point(252, 78);
            skyLabel4.Name = "skyLabel4";
            skyLabel4.Size = new Size(96, 16);
            skyLabel4.TabIndex = 107;
            skyLabel4.Text = "Agendamento";
            // 
            // lb_veterinário
            // 
            lb_veterinário.AutoSize = true;
            lb_veterinário.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_veterinário.ForeColor = Color.FromArgb(27, 94, 137);
            lb_veterinário.Location = new Point(17, 137);
            lb_veterinário.Name = "lb_veterinário";
            lb_veterinário.Size = new Size(146, 16);
            lb_veterinário.TabIndex = 106;
            lb_veterinário.Text = "Banhista Responsável";
            // 
            // skyLabel2
            // 
            skyLabel2.AutoSize = true;
            skyLabel2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            skyLabel2.ForeColor = Color.FromArgb(27, 94, 137);
            skyLabel2.Location = new Point(17, 13);
            skyLabel2.Name = "skyLabel2";
            skyLabel2.Size = new Size(77, 16);
            skyLabel2.TabIndex = 105;
            skyLabel2.Text = "Nº Registro";
            // 
            // skyLabel1
            // 
            skyLabel1.AutoSize = true;
            skyLabel1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            skyLabel1.ForeColor = Color.FromArgb(27, 94, 137);
            skyLabel1.Location = new Point(17, 78);
            skyLabel1.Name = "skyLabel1";
            skyLabel1.Size = new Size(88, 16);
            skyLabel1.TabIndex = 104;
            skyLabel1.Text = "Tipo de Tosa";
            // 
            // dt_agendamento_bant
            // 
            dt_agendamento_bant.CalendarForeColor = SystemColors.HotTrack;
            dt_agendamento_bant.CalendarMonthBackground = SystemColors.HotTrack;
            dt_agendamento_bant.CalendarTitleBackColor = Color.RoyalBlue;
            dt_agendamento_bant.CalendarTitleForeColor = Color.RoyalBlue;
            dt_agendamento_bant.CalendarTrailingForeColor = Color.RoyalBlue;
            dt_agendamento_bant.Location = new Point(252, 97);
            dt_agendamento_bant.MinimumSize = new Size(0, 29);
            dt_agendamento_bant.Name = "dt_agendamento_bant";
            dt_agendamento_bant.Size = new Size(200, 29);
            dt_agendamento_bant.TabIndex = 89;
            // 
            // cb_ban_responsavel_bant
            // 
            cb_ban_responsavel_bant.BackColor = Color.White;
            cb_ban_responsavel_bant.BGColorA = Color.White;
            cb_ban_responsavel_bant.BGColorB = Color.White;
            cb_ban_responsavel_bant.BorderColorA = Color.White;
            cb_ban_responsavel_bant.BorderColorB = Color.Tomato;
            cb_ban_responsavel_bant.BorderColorC = Color.Tomato;
            cb_ban_responsavel_bant.BorderColorD = Color.Tomato;
            cb_ban_responsavel_bant.DrawMode = DrawMode.OwnerDrawFixed;
            cb_ban_responsavel_bant.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_ban_responsavel_bant.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cb_ban_responsavel_bant.ForeColor = Color.FromArgb(27, 94, 137);
            cb_ban_responsavel_bant.FormattingEnabled = true;
            cb_ban_responsavel_bant.ItemHeight = 16;
            cb_ban_responsavel_bant.ItemHighlightColor = Color.Tomato;
            cb_ban_responsavel_bant.Items.AddRange(new object[] { "", "Carlos", "Guilherme", "Lucas", "Nicollas", "Samuel", "Stephanie" });
            cb_ban_responsavel_bant.LineColorA = Color.White;
            cb_ban_responsavel_bant.LineColorB = Color.White;
            cb_ban_responsavel_bant.LineColorC = Color.White;
            cb_ban_responsavel_bant.ListBackColor = Color.FromArgb(224, 224, 224);
            cb_ban_responsavel_bant.ListBorderColor = Color.White;
            cb_ban_responsavel_bant.ListDashType = System.Drawing.Drawing2D.DashStyle.Dot;
            cb_ban_responsavel_bant.ListForeColor = Color.Black;
            cb_ban_responsavel_bant.ListSelectedBackColorA = Color.White;
            cb_ban_responsavel_bant.ListSelectedBackColorB = Color.White;
            cb_ban_responsavel_bant.Location = new Point(17, 156);
            cb_ban_responsavel_bant.Name = "cb_ban_responsavel_bant";
            cb_ban_responsavel_bant.Size = new Size(162, 22);
            cb_ban_responsavel_bant.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cb_ban_responsavel_bant.StartIndex = 0;
            cb_ban_responsavel_bant.TabIndex = 103;
            cb_ban_responsavel_bant.TriangleColorA = Color.Tomato;
            cb_ban_responsavel_bant.TriangleColorB = Color.Tomato;
            // 
            // cb_tipo_tosa_bant
            // 
            cb_tipo_tosa_bant.BackColor = Color.White;
            cb_tipo_tosa_bant.BGColorA = Color.White;
            cb_tipo_tosa_bant.BGColorB = Color.White;
            cb_tipo_tosa_bant.BorderColorA = Color.White;
            cb_tipo_tosa_bant.BorderColorB = Color.Tomato;
            cb_tipo_tosa_bant.BorderColorC = Color.Tomato;
            cb_tipo_tosa_bant.BorderColorD = Color.Tomato;
            cb_tipo_tosa_bant.DrawMode = DrawMode.OwnerDrawFixed;
            cb_tipo_tosa_bant.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tipo_tosa_bant.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cb_tipo_tosa_bant.ForeColor = Color.FromArgb(27, 94, 137);
            cb_tipo_tosa_bant.FormattingEnabled = true;
            cb_tipo_tosa_bant.ItemHeight = 16;
            cb_tipo_tosa_bant.ItemHighlightColor = Color.Tomato;
            cb_tipo_tosa_bant.Items.AddRange(new object[] { "", "Tosa Higiênica", "Tosa na Tesoura", "Tosa na Máquina", "Tosa Bebê", "Tosa Verão" });
            cb_tipo_tosa_bant.LineColorA = Color.White;
            cb_tipo_tosa_bant.LineColorB = Color.White;
            cb_tipo_tosa_bant.LineColorC = Color.White;
            cb_tipo_tosa_bant.ListBackColor = Color.FromArgb(224, 224, 224);
            cb_tipo_tosa_bant.ListBorderColor = Color.White;
            cb_tipo_tosa_bant.ListDashType = System.Drawing.Drawing2D.DashStyle.Dot;
            cb_tipo_tosa_bant.ListForeColor = Color.Black;
            cb_tipo_tosa_bant.ListSelectedBackColorA = Color.White;
            cb_tipo_tosa_bant.ListSelectedBackColorB = Color.White;
            cb_tipo_tosa_bant.Location = new Point(17, 100);
            cb_tipo_tosa_bant.Name = "cb_tipo_tosa_bant";
            cb_tipo_tosa_bant.Size = new Size(162, 22);
            cb_tipo_tosa_bant.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cb_tipo_tosa_bant.StartIndex = 0;
            cb_tipo_tosa_bant.TabIndex = 102;
            cb_tipo_tosa_bant.TriangleColorA = Color.Tomato;
            cb_tipo_tosa_bant.TriangleColorB = Color.Tomato;
            cb_tipo_tosa_bant.SelectedIndexChanged += cb_tipo_tosa_bant_SelectedIndexChanged;
            // 
            // tb_valor_bant
            // 
            tb_valor_bant.AllowDrop = true;
            tb_valor_bant.BackColor = Color.LightPink;
            tb_valor_bant.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_valor_bant.Location = new Point(255, 160);
            tb_valor_bant.Name = "tb_valor_bant";
            tb_valor_bant.ReadOnly = true;
            tb_valor_bant.Size = new Size(93, 26);
            tb_valor_bant.TabIndex = 79;
            // 
            // tb_confirm_consulta_bant
            // 
            tb_confirm_consulta_bant.BackColor = Color.White;
            tb_confirm_consulta_bant.BorderStyle = BorderStyle.FixedSingle;
            tb_confirm_consulta_bant.Font = new Font("Segoe UI", 9.75F);
            tb_confirm_consulta_bant.Location = new Point(107, 343);
            tb_confirm_consulta_bant.Name = "tb_confirm_consulta_bant";
            tb_confirm_consulta_bant.Size = new Size(514, 103);
            tb_confirm_consulta_bant.TabIndex = 90;
            tb_confirm_consulta_bant.Text = "";
            // 
            // bt_voltar_bant
            // 
            bt_voltar_bant.BackColor = Color.Transparent;
            bt_voltar_bant.FlatAppearance.BorderColor = Color.White;
            bt_voltar_bant.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bt_voltar_bant.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
            bt_voltar_bant.Image = (Image)resources.GetObject("bt_voltar_bant.Image");
            bt_voltar_bant.Location = new Point(4, 49);
            bt_voltar_bant.Name = "bt_voltar_bant";
            bt_voltar_bant.Size = new Size(57, 54);
            bt_voltar_bant.TabIndex = 89;
            bt_voltar_bant.UseVisualStyleBackColor = false;
            bt_voltar_bant.Click += bt_voltar_bant_Click;
            // 
            // Bantosa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 501);
            Controls.Add(panel_bantosa);
            Name = "Bantosa";
            Text = "Bantosa";
            panel_bantosa.ResumeLayout(false);
            panel_bantosa.PerformLayout();
            panel_bant.ResumeLayout(false);
            panel_bant.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel_bantosa;
        private Panel panel1;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel3;
        private ReaLTaiizor.Controls.Button bt_confirmar_bant;
        private ReaLTaiizor.Controls.Button bt_cancelar_bant;
        private ReaLTaiizor.Controls.Button bt_agendamento_bant;
        private ReaLTaiizor.Controls.Button bt_limpar_bant;
        public Panel panel_bant;
        public TextBox tb_numero_registro_bant;
        private ReaLTaiizor.Controls.SkyLabel skyLabel5;
        private ReaLTaiizor.Controls.SkyLabel skyLabel4;
        private ReaLTaiizor.Controls.SkyLabel lb_veterinário;
        private ReaLTaiizor.Controls.SkyLabel skyLabel2;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private ReaLTaiizor.Controls.PoisonDateTime dt_agendamento_bant;
        private ReaLTaiizor.Controls.SkyComboBox cb_ban_responsavel_bant;
        private ReaLTaiizor.Controls.SkyComboBox cb_tipo_tosa_bant;
        private MaskedTextBox tb_valor_bant;
        private RichTextBox tb_confirm_consulta_bant;
        private Button bt_voltar_bant;
        private Label label1;
    }
}