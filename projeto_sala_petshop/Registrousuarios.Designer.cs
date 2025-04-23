namespace projeto_sala_petshop
{
    partial class Registrousuarios
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
            panel_cadastro_func = new Panel();
            panel2 = new Panel();
            headerLabel3 = new ReaLTaiizor.Controls.HeaderLabel();
            cb_nivel_acesso = new ReaLTaiizor.Controls.DungeonComboBox();
            lb_nivel_acesso = new ReaLTaiizor.Controls.SkyLabel();
            bt_salvar_regis_func = new ReaLTaiizor.Controls.Button();
            dataGridViewRegisFunc = new DataGridView();
            bt_excluir_regis_func = new ReaLTaiizor.Controls.Button();
            bt_limpar_regis_func = new ReaLTaiizor.Controls.Button();
            bt_busca_registro = new ReaLTaiizor.Controls.CyberButton();
            panel_cadastro_func.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRegisFunc).BeginInit();
            SuspendLayout();
            // 
            // panel_cadastro_func
            // 
            panel_cadastro_func.BackColor = Color.White;
            panel_cadastro_func.Controls.Add(panel2);
            panel_cadastro_func.Controls.Add(headerLabel3);
            panel_cadastro_func.Controls.Add(cb_nivel_acesso);
            panel_cadastro_func.Controls.Add(lb_nivel_acesso);
            panel_cadastro_func.Controls.Add(bt_salvar_regis_func);
            panel_cadastro_func.Controls.Add(dataGridViewRegisFunc);
            panel_cadastro_func.Controls.Add(bt_excluir_regis_func);
            panel_cadastro_func.Controls.Add(bt_limpar_regis_func);
            panel_cadastro_func.Controls.Add(bt_busca_registro);
            panel_cadastro_func.Location = new Point(2, 1);
            panel_cadastro_func.Name = "panel_cadastro_func";
            panel_cadastro_func.Size = new Size(668, 496);
            panel_cadastro_func.TabIndex = 0;
            panel_cadastro_func.Paint += panel_cadastro_func_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.NavajoWhite;
            panel2.Location = new Point(-13, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(687, 10);
            panel2.TabIndex = 188;
            panel2.UseWaitCursor = true;
            // 
            // headerLabel3
            // 
            headerLabel3.AutoSize = true;
            headerLabel3.BackColor = Color.Transparent;
            headerLabel3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel3.ForeColor = Color.Black;
            headerLabel3.Location = new Point(25, 8);
            headerLabel3.Name = "headerLabel3";
            headerLabel3.Size = new Size(187, 18);
            headerLabel3.TabIndex = 187;
            headerLabel3.Text = "Registro de Funcionários";
            headerLabel3.Click += headerLabel3_Click;
            // 
            // cb_nivel_acesso
            // 
            cb_nivel_acesso.BackColor = Color.White;
            cb_nivel_acesso.ColorA = Color.Tomato;
            cb_nivel_acesso.ColorB = Color.Tomato;
            cb_nivel_acesso.ColorC = Color.FromArgb(29, 200, 238);
            cb_nivel_acesso.ColorD = Color.White;
            cb_nivel_acesso.ColorE = Color.White;
            cb_nivel_acesso.ColorF = Color.FromArgb(29, 200, 238);
            cb_nivel_acesso.ColorG = Color.FromArgb(29, 200, 238);
            cb_nivel_acesso.ColorH = Color.FromArgb(29, 200, 238);
            cb_nivel_acesso.ColorI = Color.White;
            cb_nivel_acesso.DrawMode = DrawMode.OwnerDrawFixed;
            cb_nivel_acesso.DropDownHeight = 100;
            cb_nivel_acesso.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_nivel_acesso.Font = new Font("Segoe UI", 10F);
            cb_nivel_acesso.ForeColor = Color.Black;
            cb_nivel_acesso.FormattingEnabled = true;
            cb_nivel_acesso.HoverSelectionColor = Color.Empty;
            cb_nivel_acesso.IntegralHeight = false;
            cb_nivel_acesso.ItemHeight = 20;
            cb_nivel_acesso.Items.AddRange(new object[] { "", "Comum", "Admin" });
            cb_nivel_acesso.Location = new Point(218, 55);
            cb_nivel_acesso.Name = "cb_nivel_acesso";
            cb_nivel_acesso.Size = new Size(132, 26);
            cb_nivel_acesso.StartIndex = 0;
            cb_nivel_acesso.TabIndex = 216;
            // 
            // lb_nivel_acesso
            // 
            lb_nivel_acesso.AutoSize = true;
            lb_nivel_acesso.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_nivel_acesso.ForeColor = Color.Navy;
            lb_nivel_acesso.Location = new Point(101, 59);
            lb_nivel_acesso.Name = "lb_nivel_acesso";
            lb_nivel_acesso.Size = new Size(111, 16);
            lb_nivel_acesso.TabIndex = 215;
            lb_nivel_acesso.Text = "Nível de Acesso:";
            // 
            // bt_salvar_regis_func
            // 
            bt_salvar_regis_func.BackColor = Color.Transparent;
            bt_salvar_regis_func.BorderColor = Color.FromArgb(32, 34, 37);
            bt_salvar_regis_func.Cursor = Cursors.Hand;
            bt_salvar_regis_func.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            bt_salvar_regis_func.EnteredColor = Color.FromArgb(32, 34, 37);
            bt_salvar_regis_func.Font = new Font("Microsoft Sans Serif", 12F);
            bt_salvar_regis_func.Image = null;
            bt_salvar_regis_func.ImageAlign = ContentAlignment.MiddleLeft;
            bt_salvar_regis_func.InactiveColor = Color.Green;
            bt_salvar_regis_func.Location = new Point(457, 438);
            bt_salvar_regis_func.Name = "bt_salvar_regis_func";
            bt_salvar_regis_func.PressedBorderColor = Color.FromArgb(165, 37, 37);
            bt_salvar_regis_func.PressedColor = Color.FromArgb(165, 37, 37);
            bt_salvar_regis_func.Size = new Size(90, 30);
            bt_salvar_regis_func.TabIndex = 214;
            bt_salvar_regis_func.Text = "Salvar";
            bt_salvar_regis_func.TextAlignment = StringAlignment.Center;
            bt_salvar_regis_func.Click += bt_salvar_regis_func_Click;
            // 
            // dataGridViewRegisFunc
            // 
            dataGridViewRegisFunc.BackgroundColor = Color.Azure;
            dataGridViewRegisFunc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRegisFunc.GridColor = SystemColors.InactiveCaption;
            dataGridViewRegisFunc.Location = new Point(96, 92);
            dataGridViewRegisFunc.Name = "dataGridViewRegisFunc";
            dataGridViewRegisFunc.Size = new Size(440, 322);
            dataGridViewRegisFunc.TabIndex = 213;
            // 
            // bt_excluir_regis_func
            // 
            bt_excluir_regis_func.BackColor = Color.Transparent;
            bt_excluir_regis_func.BorderColor = Color.FromArgb(32, 34, 37);
            bt_excluir_regis_func.Cursor = Cursors.Hand;
            bt_excluir_regis_func.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            bt_excluir_regis_func.EnteredColor = Color.FromArgb(32, 34, 37);
            bt_excluir_regis_func.Font = new Font("Microsoft Sans Serif", 12F);
            bt_excluir_regis_func.Image = null;
            bt_excluir_regis_func.ImageAlign = ContentAlignment.MiddleLeft;
            bt_excluir_regis_func.InactiveColor = Color.DarkRed;
            bt_excluir_regis_func.Location = new Point(287, 438);
            bt_excluir_regis_func.Name = "bt_excluir_regis_func";
            bt_excluir_regis_func.PressedBorderColor = Color.FromArgb(165, 37, 37);
            bt_excluir_regis_func.PressedColor = Color.FromArgb(165, 37, 37);
            bt_excluir_regis_func.Size = new Size(90, 30);
            bt_excluir_regis_func.TabIndex = 212;
            bt_excluir_regis_func.Text = "Excluir";
            bt_excluir_regis_func.TextAlignment = StringAlignment.Center;
            bt_excluir_regis_func.Click += bt_excluir_regis_func_Click;
            // 
            // bt_limpar_regis_func
            // 
            bt_limpar_regis_func.BackColor = Color.Transparent;
            bt_limpar_regis_func.BorderColor = Color.FromArgb(32, 34, 37);
            bt_limpar_regis_func.Cursor = Cursors.Hand;
            bt_limpar_regis_func.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            bt_limpar_regis_func.EnteredColor = Color.FromArgb(32, 34, 37);
            bt_limpar_regis_func.Font = new Font("Microsoft Sans Serif", 12F);
            bt_limpar_regis_func.Image = null;
            bt_limpar_regis_func.ImageAlign = ContentAlignment.MiddleLeft;
            bt_limpar_regis_func.InactiveColor = Color.DarkGray;
            bt_limpar_regis_func.Location = new Point(109, 438);
            bt_limpar_regis_func.Name = "bt_limpar_regis_func";
            bt_limpar_regis_func.PressedBorderColor = Color.FromArgb(165, 37, 37);
            bt_limpar_regis_func.PressedColor = Color.FromArgb(165, 37, 37);
            bt_limpar_regis_func.Size = new Size(90, 30);
            bt_limpar_regis_func.TabIndex = 211;
            bt_limpar_regis_func.Text = "Limpar";
            bt_limpar_regis_func.TextAlignment = StringAlignment.Center;
            bt_limpar_regis_func.Click += bt_limpar_regis_func_Click;
            // 
            // bt_busca_registro
            // 
            bt_busca_registro.Alpha = 20;
            bt_busca_registro.BackColor = Color.Transparent;
            bt_busca_registro.Background = true;
            bt_busca_registro.Background_WidthPen = 4F;
            bt_busca_registro.BackgroundPen = true;
            bt_busca_registro.ColorBackground = Color.DarkGray;
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
            bt_busca_registro.Location = new Point(417, 55);
            bt_busca_registro.Name = "bt_busca_registro";
            bt_busca_registro.PenWidth = 15;
            bt_busca_registro.Rounding = true;
            bt_busca_registro.RoundingInt = 70;
            bt_busca_registro.Size = new Size(119, 26);
            bt_busca_registro.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            bt_busca_registro.TabIndex = 210;
            bt_busca_registro.Tag = "Cyber";
            bt_busca_registro.TextButton = "Buscar";
            bt_busca_registro.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            bt_busca_registro.Timer_Effect_1 = 5;
            bt_busca_registro.Timer_RGB = 300;
            bt_busca_registro.Click += bt_busca_registro_Click;
            // 
            // Registrousuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(668, 498);
            Controls.Add(panel_cadastro_func);
            Name = "Registrousuarios";
            Text = "Registrousuarios";
            panel_cadastro_func.ResumeLayout(false);
            panel_cadastro_func.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRegisFunc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_cadastro_func;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel3;
        private Panel panel2;
        private ReaLTaiizor.Controls.SkyLabel lb_nivel_acesso;
        private ReaLTaiizor.Controls.Button bt_salvar_regis_func;
        private DataGridView dataGridViewRegisFunc;
        private ReaLTaiizor.Controls.Button bt_excluir_regis_func;
        private ReaLTaiizor.Controls.Button bt_limpar_regis_func;
        private ReaLTaiizor.Controls.CyberButton bt_busca_registro;
        private ReaLTaiizor.Controls.DungeonComboBox cb_nivel_acesso;
    }
}