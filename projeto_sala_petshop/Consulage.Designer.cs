namespace projeto_sala_petshop
{
    partial class Consulage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulage));
            panel_consulage = new Panel();
            panel1 = new Panel();
            headerLabel3 = new ReaLTaiizor.Controls.HeaderLabel();
            bt_confirmar_vet = new ReaLTaiizor.Controls.Button();
            bt_cancelar_vet = new ReaLTaiizor.Controls.Button();
            bt_agendamento_vet = new ReaLTaiizor.Controls.Button();
            bt_limpar_vet = new ReaLTaiizor.Controls.Button();
            panel3 = new Panel();
            label1 = new Label();
            tb_numero_registro = new TextBox();
            skyLabel5 = new ReaLTaiizor.Controls.SkyLabel();
            skyLabel4 = new ReaLTaiizor.Controls.SkyLabel();
            lb_veterinário = new ReaLTaiizor.Controls.SkyLabel();
            skyLabel2 = new ReaLTaiizor.Controls.SkyLabel();
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            dt_agendamento = new ReaLTaiizor.Controls.PoisonDateTime();
            cb_vet_responsavel = new ReaLTaiizor.Controls.SkyComboBox();
            cb_motivo_consulta = new ReaLTaiizor.Controls.SkyComboBox();
            tb_valor = new MaskedTextBox();
            tb_confirm_consulta = new RichTextBox();
            button5 = new Button();
            panel_consulage.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel_consulage
            // 
            panel_consulage.BackColor = Color.White;
            panel_consulage.Controls.Add(panel1);
            panel_consulage.Controls.Add(headerLabel3);
            panel_consulage.Controls.Add(bt_confirmar_vet);
            panel_consulage.Controls.Add(bt_cancelar_vet);
            panel_consulage.Controls.Add(bt_agendamento_vet);
            panel_consulage.Controls.Add(bt_limpar_vet);
            panel_consulage.Controls.Add(panel3);
            panel_consulage.Controls.Add(tb_confirm_consulta);
            panel_consulage.Controls.Add(button5);
            panel_consulage.Location = new Point(2, 0);
            panel_consulage.Name = "panel_consulage";
            panel_consulage.Size = new Size(738, 501);
            panel_consulage.TabIndex = 50;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(-3, 36);
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
            headerLabel3.Location = new Point(0, 15);
            headerLabel3.Name = "headerLabel3";
            headerLabel3.Size = new Size(151, 18);
            headerLabel3.TabIndex = 96;
            headerLabel3.Text = "Consulta Veterinária";
            // 
            // bt_confirmar_vet
            // 
            bt_confirmar_vet.BackColor = Color.Transparent;
            bt_confirmar_vet.BorderColor = Color.FromArgb(32, 34, 37);
            bt_confirmar_vet.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            bt_confirmar_vet.EnteredColor = Color.FromArgb(32, 34, 37);
            bt_confirmar_vet.Font = new Font("Microsoft Sans Serif", 12F);
            bt_confirmar_vet.Image = null;
            bt_confirmar_vet.ImageAlign = ContentAlignment.MiddleLeft;
            bt_confirmar_vet.InactiveColor = Color.FromArgb(32, 34, 37);
            bt_confirmar_vet.Location = new Point(531, 454);
            bt_confirmar_vet.Name = "bt_confirmar_vet";
            bt_confirmar_vet.PressedBorderColor = Color.FromArgb(165, 37, 37);
            bt_confirmar_vet.PressedColor = Color.FromArgb(165, 37, 37);
            bt_confirmar_vet.Size = new Size(90, 30);
            bt_confirmar_vet.TabIndex = 95;
            bt_confirmar_vet.Text = "Confirmar";
            bt_confirmar_vet.TextAlignment = StringAlignment.Center;
            bt_confirmar_vet.Click += bt_confirmar_vet_Click;
            // 
            // bt_cancelar_vet
            // 
            bt_cancelar_vet.BackColor = Color.Transparent;
            bt_cancelar_vet.BorderColor = Color.FromArgb(32, 34, 37);
            bt_cancelar_vet.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            bt_cancelar_vet.EnteredColor = Color.FromArgb(32, 34, 37);
            bt_cancelar_vet.Font = new Font("Microsoft Sans Serif", 12F);
            bt_cancelar_vet.Image = null;
            bt_cancelar_vet.ImageAlign = ContentAlignment.MiddleLeft;
            bt_cancelar_vet.InactiveColor = Color.FromArgb(32, 34, 37);
            bt_cancelar_vet.Location = new Point(420, 454);
            bt_cancelar_vet.Name = "bt_cancelar_vet";
            bt_cancelar_vet.PressedBorderColor = Color.FromArgb(165, 37, 37);
            bt_cancelar_vet.PressedColor = Color.FromArgb(165, 37, 37);
            bt_cancelar_vet.Size = new Size(90, 30);
            bt_cancelar_vet.TabIndex = 94;
            bt_cancelar_vet.Text = "Cancelar";
            bt_cancelar_vet.TextAlignment = StringAlignment.Center;
            bt_cancelar_vet.Click += bt_cancelar_vet_Click;
            // 
            // bt_agendamento_vet
            // 
            bt_agendamento_vet.BackColor = Color.Transparent;
            bt_agendamento_vet.BorderColor = Color.FromArgb(32, 34, 37);
            bt_agendamento_vet.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            bt_agendamento_vet.EnteredColor = Color.FromArgb(32, 34, 37);
            bt_agendamento_vet.Font = new Font("Microsoft Sans Serif", 12F);
            bt_agendamento_vet.Image = null;
            bt_agendamento_vet.ImageAlign = ContentAlignment.MiddleLeft;
            bt_agendamento_vet.InactiveColor = Color.FromArgb(32, 34, 37);
            bt_agendamento_vet.Location = new Point(531, 288);
            bt_agendamento_vet.Name = "bt_agendamento_vet";
            bt_agendamento_vet.PressedBorderColor = Color.FromArgb(165, 37, 37);
            bt_agendamento_vet.PressedColor = Color.FromArgb(165, 37, 37);
            bt_agendamento_vet.Size = new Size(90, 30);
            bt_agendamento_vet.TabIndex = 93;
            bt_agendamento_vet.Text = "Agendar";
            bt_agendamento_vet.TextAlignment = StringAlignment.Center;
            bt_agendamento_vet.Click += bt_agendamento_vet_Click;
            // 
            // bt_limpar_vet
            // 
            bt_limpar_vet.BackColor = Color.Transparent;
            bt_limpar_vet.BorderColor = Color.FromArgb(32, 34, 37);
            bt_limpar_vet.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            bt_limpar_vet.EnteredColor = Color.FromArgb(32, 34, 37);
            bt_limpar_vet.Font = new Font("Microsoft Sans Serif", 12F);
            bt_limpar_vet.Image = null;
            bt_limpar_vet.ImageAlign = ContentAlignment.MiddleLeft;
            bt_limpar_vet.InactiveColor = Color.FromArgb(32, 34, 37);
            bt_limpar_vet.Location = new Point(420, 288);
            bt_limpar_vet.Name = "bt_limpar_vet";
            bt_limpar_vet.PressedBorderColor = Color.FromArgb(165, 37, 37);
            bt_limpar_vet.PressedColor = Color.FromArgb(165, 37, 37);
            bt_limpar_vet.Size = new Size(90, 30);
            bt_limpar_vet.TabIndex = 92;
            bt_limpar_vet.Text = "Limpar";
            bt_limpar_vet.TextAlignment = StringAlignment.Center;
            bt_limpar_vet.Click += bt_limpar_vet_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(tb_numero_registro);
            panel3.Controls.Add(skyLabel5);
            panel3.Controls.Add(skyLabel4);
            panel3.Controls.Add(lb_veterinário);
            panel3.Controls.Add(skyLabel2);
            panel3.Controls.Add(skyLabel1);
            panel3.Controls.Add(dt_agendamento);
            panel3.Controls.Add(cb_vet_responsavel);
            panel3.Controls.Add(cb_motivo_consulta);
            panel3.Controls.Add(tb_valor);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(107, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(514, 198);
            panel3.TabIndex = 91;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(240, 160);
            label1.Name = "label1";
            label1.Size = new Size(23, 17);
            label1.TabIndex = 110;
            label1.Text = "R$";
            // 
            // tb_numero_registro
            // 
            tb_numero_registro.BackColor = Color.LightCyan;
            tb_numero_registro.BorderStyle = BorderStyle.FixedSingle;
            tb_numero_registro.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_numero_registro.ForeColor = Color.Black;
            tb_numero_registro.Location = new Point(26, 32);
            tb_numero_registro.Multiline = true;
            tb_numero_registro.Name = "tb_numero_registro";
            tb_numero_registro.Size = new Size(59, 29);
            tb_numero_registro.TabIndex = 109;
            tb_numero_registro.TextAlign = HorizontalAlignment.Center;
            tb_numero_registro.KeyPress += tb_numero_registro_KeyPress;
            // 
            // skyLabel5
            // 
            skyLabel5.AutoSize = true;
            skyLabel5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            skyLabel5.ForeColor = Color.FromArgb(27, 94, 137);
            skyLabel5.Location = new Point(238, 137);
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
            skyLabel4.Location = new Point(238, 78);
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
            lb_veterinário.Size = new Size(161, 16);
            lb_veterinário.TabIndex = 106;
            lb_veterinário.Text = "Veterinário Responsável";
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
            skyLabel1.Size = new Size(128, 16);
            skyLabel1.TabIndex = 104;
            skyLabel1.Text = "Motivo da Consulta";
            // 
            // dt_agendamento
            // 
            dt_agendamento.CalendarForeColor = SystemColors.HotTrack;
            dt_agendamento.CalendarMonthBackground = SystemColors.HotTrack;
            dt_agendamento.CalendarTitleBackColor = Color.RoyalBlue;
            dt_agendamento.CalendarTitleForeColor = Color.RoyalBlue;
            dt_agendamento.CalendarTrailingForeColor = Color.RoyalBlue;
            dt_agendamento.Location = new Point(238, 97);
            dt_agendamento.MinimumSize = new Size(0, 29);
            dt_agendamento.Name = "dt_agendamento";
            dt_agendamento.Size = new Size(200, 29);
            dt_agendamento.TabIndex = 89;
            // 
            // cb_vet_responsavel
            // 
            cb_vet_responsavel.BackColor = Color.White;
            cb_vet_responsavel.BGColorA = Color.White;
            cb_vet_responsavel.BGColorB = Color.White;
            cb_vet_responsavel.BorderColorA = Color.White;
            cb_vet_responsavel.BorderColorB = Color.SkyBlue;
            cb_vet_responsavel.BorderColorC = Color.SkyBlue;
            cb_vet_responsavel.BorderColorD = Color.SkyBlue;
            cb_vet_responsavel.DrawMode = DrawMode.OwnerDrawFixed;
            cb_vet_responsavel.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_vet_responsavel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cb_vet_responsavel.ForeColor = Color.FromArgb(27, 94, 137);
            cb_vet_responsavel.FormattingEnabled = true;
            cb_vet_responsavel.ItemHeight = 16;
            cb_vet_responsavel.ItemHighlightColor = Color.FromArgb(121, 176, 214);
            cb_vet_responsavel.Items.AddRange(new object[] { "", "Carlos", "Guilherme", "Lucas", "Nicollas", "Samuel", "Stephanie" });
            cb_vet_responsavel.LineColorA = Color.White;
            cb_vet_responsavel.LineColorB = Color.White;
            cb_vet_responsavel.LineColorC = Color.White;
            cb_vet_responsavel.ListBackColor = Color.FromArgb(224, 224, 224);
            cb_vet_responsavel.ListBorderColor = Color.White;
            cb_vet_responsavel.ListDashType = System.Drawing.Drawing2D.DashStyle.Dot;
            cb_vet_responsavel.ListForeColor = Color.Black;
            cb_vet_responsavel.ListSelectedBackColorA = Color.White;
            cb_vet_responsavel.ListSelectedBackColorB = Color.White;
            cb_vet_responsavel.Location = new Point(17, 156);
            cb_vet_responsavel.Name = "cb_vet_responsavel";
            cb_vet_responsavel.Size = new Size(162, 22);
            cb_vet_responsavel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cb_vet_responsavel.StartIndex = 0;
            cb_vet_responsavel.TabIndex = 103;
            cb_vet_responsavel.TriangleColorA = Color.FromArgb(121, 176, 214);
            cb_vet_responsavel.TriangleColorB = Color.FromArgb(27, 94, 137);
            cb_vet_responsavel.SelectedIndexChanged += cb_vet_responsavel_SelectedIndexChanged;
            // 
            // cb_motivo_consulta
            // 
            cb_motivo_consulta.BackColor = Color.White;
            cb_motivo_consulta.BGColorA = Color.White;
            cb_motivo_consulta.BGColorB = Color.White;
            cb_motivo_consulta.BorderColorA = Color.White;
            cb_motivo_consulta.BorderColorB = Color.SkyBlue;
            cb_motivo_consulta.BorderColorC = Color.SkyBlue;
            cb_motivo_consulta.BorderColorD = Color.SkyBlue;
            cb_motivo_consulta.DrawMode = DrawMode.OwnerDrawFixed;
            cb_motivo_consulta.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_motivo_consulta.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cb_motivo_consulta.ForeColor = Color.FromArgb(27, 94, 137);
            cb_motivo_consulta.FormattingEnabled = true;
            cb_motivo_consulta.ItemHeight = 16;
            cb_motivo_consulta.ItemHighlightColor = Color.FromArgb(121, 176, 214);
            cb_motivo_consulta.Items.AddRange(new object[] { "", "Vacinação", "Check-up", "Doença", "Castração", "Acidente" });
            cb_motivo_consulta.LineColorA = Color.White;
            cb_motivo_consulta.LineColorB = Color.White;
            cb_motivo_consulta.LineColorC = Color.White;
            cb_motivo_consulta.ListBackColor = Color.FromArgb(224, 224, 224);
            cb_motivo_consulta.ListBorderColor = Color.White;
            cb_motivo_consulta.ListDashType = System.Drawing.Drawing2D.DashStyle.Dot;
            cb_motivo_consulta.ListForeColor = Color.Black;
            cb_motivo_consulta.ListSelectedBackColorA = Color.White;
            cb_motivo_consulta.ListSelectedBackColorB = Color.White;
            cb_motivo_consulta.Location = new Point(17, 100);
            cb_motivo_consulta.Name = "cb_motivo_consulta";
            cb_motivo_consulta.Size = new Size(162, 22);
            cb_motivo_consulta.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cb_motivo_consulta.StartIndex = 0;
            cb_motivo_consulta.TabIndex = 102;
            cb_motivo_consulta.TriangleColorA = Color.FromArgb(121, 176, 214);
            cb_motivo_consulta.TriangleColorB = Color.FromArgb(27, 94, 137);
            cb_motivo_consulta.SelectedIndexChanged += cb_motivo_consulta_SelectedIndexChanged;
            // 
            // tb_valor
            // 
            tb_valor.AllowDrop = true;
            tb_valor.BackColor = Color.Honeydew;
            tb_valor.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_valor.Location = new Point(269, 156);
            tb_valor.Name = "tb_valor";
            tb_valor.ReadOnly = true;
            tb_valor.Size = new Size(96, 26);
            tb_valor.TabIndex = 79;
            // 
            // tb_confirm_consulta
            // 
            tb_confirm_consulta.BackColor = Color.White;
            tb_confirm_consulta.BorderStyle = BorderStyle.FixedSingle;
            tb_confirm_consulta.Font = new Font("Segoe UI", 9.75F);
            tb_confirm_consulta.Location = new Point(107, 343);
            tb_confirm_consulta.Name = "tb_confirm_consulta";
            tb_confirm_consulta.Size = new Size(514, 103);
            tb_confirm_consulta.TabIndex = 90;
            tb_confirm_consulta.Text = "";
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderColor = Color.White;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(4, 49);
            button5.Name = "button5";
            button5.Size = new Size(57, 54);
            button5.TabIndex = 89;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Consulage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(738, 498);
            Controls.Add(panel_consulage);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1032);
            MinimumSize = new Size(190, 40);
            Name = "Consulage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulage";
            panel_consulage.ResumeLayout(false);
            panel_consulage.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.Button bt_confirmar_vet;
        private ReaLTaiizor.Controls.Button bt_cancelar_vet;
        private ReaLTaiizor.Controls.Button bt_agendamento_vet;
        private ReaLTaiizor.Controls.Button bt_limpar_vet;
        private ReaLTaiizor.Controls.SkyLabel skyLabel4;
        private ReaLTaiizor.Controls.SkyLabel lb_veterinário;
        private ReaLTaiizor.Controls.SkyLabel skyLabel2;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private ReaLTaiizor.Controls.PoisonDateTime dt_agendamento;
        private ReaLTaiizor.Controls.SkyComboBox cb_vet_responsavel;
        private ReaLTaiizor.Controls.SkyComboBox cb_motivo_consulta;
        private MaskedTextBox tb_valor;
        private RichTextBox tb_confirm_consulta;
        private Button button5;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel3;
        private Panel panel1;
        private ReaLTaiizor.Controls.SkyLabel skyLabel5;
        public Panel panel_consulage;
        public Panel panel3;
        public TextBox tb_numero_registro;
        private Label label1;
    }
}