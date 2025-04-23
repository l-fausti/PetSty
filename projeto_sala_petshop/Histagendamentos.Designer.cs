namespace projeto_sala_petshop
{
    partial class Consultas
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
            panel1 = new Panel();
            headerLabel1 = new ReaLTaiizor.Controls.HeaderLabel();
            bt_busca_registro = new ReaLTaiizor.Controls.CyberButton();
            bt_excluir_regis = new ReaLTaiizor.Controls.Button();
            bt_limpar_bant = new ReaLTaiizor.Controls.Button();
            dataGridViewHistAgen = new DataGridView();
            bt_salvar_regis = new ReaLTaiizor.Controls.Button();
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            cb_servico = new ReaLTaiizor.Controls.SkyComboBox();
            cb_tipo = new ReaLTaiizor.Controls.SkyComboBox();
            skyLabel2 = new ReaLTaiizor.Controls.SkyLabel();
            cb_profissional_responsavel = new ReaLTaiizor.Controls.SkyComboBox();
            lb_profissional_responsavel = new ReaLTaiizor.Controls.SkyLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistAgen).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.NavajoWhite;
            panel1.Location = new Point(0, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(741, 10);
            panel1.TabIndex = 181;
            panel1.UseWaitCursor = true;
            // 
            // headerLabel1
            // 
            headerLabel1.AutoSize = true;
            headerLabel1.BackColor = Color.Transparent;
            headerLabel1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel1.ForeColor = Color.Black;
            headerLabel1.Location = new Point(12, 9);
            headerLabel1.Name = "headerLabel1";
            headerLabel1.Size = new Size(202, 18);
            headerLabel1.TabIndex = 180;
            headerLabel1.Text = "Histórico de Agendamentos";
            // 
            // bt_busca_registro
            // 
            bt_busca_registro.Alpha = 20;
            bt_busca_registro.BackColor = Color.Transparent;
            bt_busca_registro.Background = true;
            bt_busca_registro.Background_WidthPen = 4F;
            bt_busca_registro.BackgroundPen = true;
            bt_busca_registro.ColorBackground = Color.Black;
            bt_busca_registro.ColorBackground_1 = Color.White;
            bt_busca_registro.ColorBackground_2 = Color.White;
            bt_busca_registro.ColorBackground_Pen = Color.Gold;
            bt_busca_registro.ColorLighting = Color.FromArgb(29, 200, 238);
            bt_busca_registro.ColorPen_1 = Color.White;
            bt_busca_registro.ColorPen_2 = Color.White;
            bt_busca_registro.Cursor = Cursors.Hand;
            bt_busca_registro.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            bt_busca_registro.Effect_1 = true;
            bt_busca_registro.Effect_1_ColorBackground = Color.Black;
            bt_busca_registro.Effect_1_Transparency = 25;
            bt_busca_registro.Effect_2 = true;
            bt_busca_registro.Effect_2_ColorBackground = Color.White;
            bt_busca_registro.Effect_2_Transparency = 20;
            bt_busca_registro.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_busca_registro.ForeColor = Color.White;
            bt_busca_registro.Lighting = false;
            bt_busca_registro.LinearGradient_Background = false;
            bt_busca_registro.LinearGradientPen = false;
            bt_busca_registro.Location = new Point(507, 81);
            bt_busca_registro.Name = "bt_busca_registro";
            bt_busca_registro.PenWidth = 15;
            bt_busca_registro.Rounding = true;
            bt_busca_registro.RoundingInt = 70;
            bt_busca_registro.Size = new Size(142, 26);
            bt_busca_registro.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            bt_busca_registro.TabIndex = 188;
            bt_busca_registro.Tag = "Cyber";
            bt_busca_registro.TextButton = "Buscar";
            bt_busca_registro.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            bt_busca_registro.Timer_Effect_1 = 5;
            bt_busca_registro.Timer_RGB = 300;
            bt_busca_registro.Click += bt_busca_registro_Click;
            // 
            // bt_excluir_regis
            // 
            bt_excluir_regis.BackColor = Color.Transparent;
            bt_excluir_regis.BorderColor = Color.FromArgb(32, 34, 37);
            bt_excluir_regis.Cursor = Cursors.Hand;
            bt_excluir_regis.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            bt_excluir_regis.EnteredColor = Color.FromArgb(32, 34, 37);
            bt_excluir_regis.Font = new Font("Microsoft Sans Serif", 12F);
            bt_excluir_regis.Image = null;
            bt_excluir_regis.ImageAlign = ContentAlignment.MiddleLeft;
            bt_excluir_regis.InactiveColor = Color.DarkRed;
            bt_excluir_regis.Location = new Point(288, 456);
            bt_excluir_regis.Name = "bt_excluir_regis";
            bt_excluir_regis.PressedBorderColor = Color.FromArgb(165, 37, 37);
            bt_excluir_regis.PressedColor = Color.FromArgb(165, 37, 37);
            bt_excluir_regis.Size = new Size(90, 30);
            bt_excluir_regis.TabIndex = 195;
            bt_excluir_regis.Text = "Excluir";
            bt_excluir_regis.TextAlignment = StringAlignment.Center;
            bt_excluir_regis.Click += bt_excluir_regis_Click;
            // 
            // bt_limpar_bant
            // 
            bt_limpar_bant.BackColor = Color.Transparent;
            bt_limpar_bant.BorderColor = Color.FromArgb(32, 34, 37);
            bt_limpar_bant.Cursor = Cursors.Hand;
            bt_limpar_bant.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            bt_limpar_bant.EnteredColor = Color.FromArgb(32, 34, 37);
            bt_limpar_bant.Font = new Font("Microsoft Sans Serif", 12F);
            bt_limpar_bant.Image = null;
            bt_limpar_bant.ImageAlign = ContentAlignment.MiddleLeft;
            bt_limpar_bant.InactiveColor = Color.DarkGray;
            bt_limpar_bant.Location = new Point(79, 456);
            bt_limpar_bant.Name = "bt_limpar_bant";
            bt_limpar_bant.PressedBorderColor = Color.FromArgb(165, 37, 37);
            bt_limpar_bant.PressedColor = Color.FromArgb(165, 37, 37);
            bt_limpar_bant.Size = new Size(90, 30);
            bt_limpar_bant.TabIndex = 194;
            bt_limpar_bant.Text = "Limpar";
            bt_limpar_bant.TextAlignment = StringAlignment.Center;
            bt_limpar_bant.Click += bt_limpar_bant_Click;
            // 
            // dataGridViewHistAgen
            // 
            dataGridViewHistAgen.BackgroundColor = SystemColors.Info;
            dataGridViewHistAgen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistAgen.GridColor = SystemColors.InactiveCaption;
            dataGridViewHistAgen.Location = new Point(22, 113);
            dataGridViewHistAgen.Name = "dataGridViewHistAgen";
            dataGridViewHistAgen.Size = new Size(627, 322);
            dataGridViewHistAgen.TabIndex = 197;
            // 
            // bt_salvar_regis
            // 
            bt_salvar_regis.BackColor = Color.Transparent;
            bt_salvar_regis.BorderColor = Color.FromArgb(32, 34, 37);
            bt_salvar_regis.Cursor = Cursors.Hand;
            bt_salvar_regis.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            bt_salvar_regis.EnteredColor = Color.FromArgb(32, 34, 37);
            bt_salvar_regis.Font = new Font("Microsoft Sans Serif", 12F);
            bt_salvar_regis.Image = null;
            bt_salvar_regis.ImageAlign = ContentAlignment.MiddleLeft;
            bt_salvar_regis.InactiveColor = Color.Green;
            bt_salvar_regis.Location = new Point(507, 456);
            bt_salvar_regis.Name = "bt_salvar_regis";
            bt_salvar_regis.PressedBorderColor = Color.FromArgb(165, 37, 37);
            bt_salvar_regis.PressedColor = Color.FromArgb(165, 37, 37);
            bt_salvar_regis.Size = new Size(90, 30);
            bt_salvar_regis.TabIndex = 198;
            bt_salvar_regis.Text = "Salvar";
            bt_salvar_regis.TextAlignment = StringAlignment.Center;
            bt_salvar_regis.Click += bt_salvar_regis_Click;
            // 
            // skyLabel1
            // 
            skyLabel1.AutoSize = true;
            skyLabel1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            skyLabel1.ForeColor = Color.Navy;
            skyLabel1.Location = new Point(73, 53);
            skyLabel1.Name = "skyLabel1";
            skyLabel1.Size = new Size(65, 16);
            skyLabel1.TabIndex = 203;
            skyLabel1.Text = "Serviços:";
            // 
            // cb_servico
            // 
            cb_servico.BackColor = Color.White;
            cb_servico.BGColorA = Color.White;
            cb_servico.BGColorB = Color.White;
            cb_servico.BorderColorA = Color.DarkKhaki;
            cb_servico.BorderColorB = Color.DarkKhaki;
            cb_servico.BorderColorC = Color.DarkKhaki;
            cb_servico.BorderColorD = Color.Transparent;
            cb_servico.DrawMode = DrawMode.OwnerDrawFixed;
            cb_servico.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_servico.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_servico.ForeColor = Color.FromArgb(27, 94, 137);
            cb_servico.FormattingEnabled = true;
            cb_servico.ItemHeight = 16;
            cb_servico.ItemHighlightColor = Color.DarkKhaki;
            cb_servico.Items.AddRange(new object[] { "", "Consulta Veterinária", "Banho e Tosa", "Adoção", "Passeio de Cães" });
            cb_servico.LineColorA = Color.DarkKhaki;
            cb_servico.LineColorB = Color.DarkKhaki;
            cb_servico.LineColorC = Color.DarkKhaki;
            cb_servico.ListBackColor = SystemColors.GradientInactiveCaption;
            cb_servico.ListBorderColor = SystemColors.GradientInactiveCaption;
            cb_servico.ListDashType = System.Drawing.Drawing2D.DashStyle.Dot;
            cb_servico.ListForeColor = Color.Black;
            cb_servico.ListSelectedBackColorA = Color.CornflowerBlue;
            cb_servico.ListSelectedBackColorB = Color.CornflowerBlue;
            cb_servico.Location = new Point(150, 48);
            cb_servico.Name = "cb_servico";
            cb_servico.Size = new Size(172, 22);
            cb_servico.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cb_servico.StartIndex = 0;
            cb_servico.TabIndex = 205;
            cb_servico.TriangleColorA = Color.DarkKhaki;
            cb_servico.TriangleColorB = Color.DarkKhaki;
            cb_servico.SelectedIndexChanged += cb_servico_SelectedIndexChanged;
            // 
            // cb_tipo
            // 
            cb_tipo.BackColor = Color.White;
            cb_tipo.BGColorA = Color.White;
            cb_tipo.BGColorB = Color.White;
            cb_tipo.BorderColorA = Color.DarkKhaki;
            cb_tipo.BorderColorB = Color.DarkKhaki;
            cb_tipo.BorderColorC = Color.DarkKhaki;
            cb_tipo.BorderColorD = Color.Transparent;
            cb_tipo.DrawMode = DrawMode.OwnerDrawFixed;
            cb_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tipo.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_tipo.ForeColor = Color.FromArgb(27, 94, 137);
            cb_tipo.FormattingEnabled = true;
            cb_tipo.ItemHeight = 16;
            cb_tipo.ItemHighlightColor = Color.DarkKhaki;
            cb_tipo.LineColorA = Color.DarkKhaki;
            cb_tipo.LineColorB = Color.DarkKhaki;
            cb_tipo.LineColorC = Color.DarkKhaki;
            cb_tipo.ListBackColor = SystemColors.GradientInactiveCaption;
            cb_tipo.ListBorderColor = SystemColors.GradientInactiveCaption;
            cb_tipo.ListDashType = System.Drawing.Drawing2D.DashStyle.Dot;
            cb_tipo.ListForeColor = Color.Black;
            cb_tipo.ListSelectedBackColorA = Color.CornflowerBlue;
            cb_tipo.ListSelectedBackColorB = Color.CornflowerBlue;
            cb_tipo.Location = new Point(404, 47);
            cb_tipo.Name = "cb_tipo";
            cb_tipo.Size = new Size(172, 22);
            cb_tipo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cb_tipo.StartIndex = 0;
            cb_tipo.TabIndex = 207;
            cb_tipo.TriangleColorA = Color.DarkKhaki;
            cb_tipo.TriangleColorB = Color.DarkKhaki;
            // 
            // skyLabel2
            // 
            skyLabel2.AutoSize = true;
            skyLabel2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            skyLabel2.ForeColor = Color.Navy;
            skyLabel2.Location = new Point(353, 52);
            skyLabel2.Name = "skyLabel2";
            skyLabel2.Size = new Size(45, 16);
            skyLabel2.TabIndex = 206;
            skyLabel2.Text = "Tipos:";
            // 
            // cb_profissional_responsavel
            // 
            cb_profissional_responsavel.BackColor = Color.White;
            cb_profissional_responsavel.BGColorA = Color.White;
            cb_profissional_responsavel.BGColorB = Color.White;
            cb_profissional_responsavel.BorderColorA = Color.DarkKhaki;
            cb_profissional_responsavel.BorderColorB = Color.DarkKhaki;
            cb_profissional_responsavel.BorderColorC = Color.DarkKhaki;
            cb_profissional_responsavel.BorderColorD = Color.Transparent;
            cb_profissional_responsavel.DrawMode = DrawMode.OwnerDrawFixed;
            cb_profissional_responsavel.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_profissional_responsavel.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_profissional_responsavel.ForeColor = Color.FromArgb(27, 94, 137);
            cb_profissional_responsavel.FormattingEnabled = true;
            cb_profissional_responsavel.ItemHeight = 16;
            cb_profissional_responsavel.ItemHighlightColor = Color.DarkKhaki;
            cb_profissional_responsavel.LineColorA = Color.DarkKhaki;
            cb_profissional_responsavel.LineColorB = Color.DarkKhaki;
            cb_profissional_responsavel.LineColorC = Color.DarkKhaki;
            cb_profissional_responsavel.ListBackColor = SystemColors.GradientInactiveCaption;
            cb_profissional_responsavel.ListBorderColor = SystemColors.GradientInactiveCaption;
            cb_profissional_responsavel.ListDashType = System.Drawing.Drawing2D.DashStyle.Dot;
            cb_profissional_responsavel.ListForeColor = Color.Black;
            cb_profissional_responsavel.ListSelectedBackColorA = Color.CornflowerBlue;
            cb_profissional_responsavel.ListSelectedBackColorB = Color.CornflowerBlue;
            cb_profissional_responsavel.Location = new Point(254, 81);
            cb_profissional_responsavel.Name = "cb_profissional_responsavel";
            cb_profissional_responsavel.Size = new Size(172, 22);
            cb_profissional_responsavel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cb_profissional_responsavel.StartIndex = 0;
            cb_profissional_responsavel.TabIndex = 209;
            cb_profissional_responsavel.TriangleColorA = Color.DarkKhaki;
            cb_profissional_responsavel.TriangleColorB = Color.DarkKhaki;
            // 
            // lb_profissional_responsavel
            // 
            lb_profissional_responsavel.AutoSize = true;
            lb_profissional_responsavel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_profissional_responsavel.ForeColor = Color.Navy;
            lb_profissional_responsavel.Location = new Point(79, 86);
            lb_profissional_responsavel.Name = "lb_profissional_responsavel";
            lb_profissional_responsavel.Size = new Size(169, 16);
            lb_profissional_responsavel.TabIndex = 208;
            lb_profissional_responsavel.Text = "Profissional Responsável:";
            // 
            // Consultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(736, 498);
            Controls.Add(cb_profissional_responsavel);
            Controls.Add(lb_profissional_responsavel);
            Controls.Add(cb_tipo);
            Controls.Add(skyLabel2);
            Controls.Add(cb_servico);
            Controls.Add(skyLabel1);
            Controls.Add(bt_salvar_regis);
            Controls.Add(dataGridViewHistAgen);
            Controls.Add(bt_excluir_regis);
            Controls.Add(bt_limpar_bant);
            Controls.Add(bt_busca_registro);
            Controls.Add(panel1);
            Controls.Add(headerLabel1);
            Name = "Consultas";
            Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistAgen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel1;
        private ReaLTaiizor.Controls.CyberButton bt_busca_registro;
        private ReaLTaiizor.Controls.Button bt_excluir_regis;
        private ReaLTaiizor.Controls.Button bt_limpar_bant;
        private DataGridView dataGridViewHistAgen;
        private ReaLTaiizor.Controls.Button bt_salvar_regis;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private ReaLTaiizor.Controls.SkyComboBox cb_servico;
        private ReaLTaiizor.Controls.SkyComboBox cb_tipo;
        private ReaLTaiizor.Controls.SkyLabel skyLabel2;
        private ReaLTaiizor.Controls.SkyComboBox cb_profissional_responsavel;
        private ReaLTaiizor.Controls.SkyLabel lb_profissional_responsavel;
    }
}