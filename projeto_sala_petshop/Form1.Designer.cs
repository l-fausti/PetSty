namespace projeto_sala_petshop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tb_nome = new TextBox();
            tb_email = new TextBox();
            tb_senha = new TextBox();
            tb_conf_senha = new TextBox();
            bt_cadastrar = new Button();
            panel3 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            tb_acesso = new TextBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            bt_login = new Button();
            tb_senha_log = new TextBox();
            tb_email_login = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(261, 132);
            tb_nome.Name = "tb_nome";
            tb_nome.PlaceholderText = "Nome";
            tb_nome.Size = new Size(213, 23);
            tb_nome.TabIndex = 0;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(42, 161);
            tb_email.Name = "tb_email";
            tb_email.PlaceholderText = "Email";
            tb_email.Size = new Size(213, 23);
            tb_email.TabIndex = 1;
            // 
            // tb_senha
            // 
            tb_senha.Location = new Point(261, 161);
            tb_senha.Name = "tb_senha";
            tb_senha.PlaceholderText = "Senha";
            tb_senha.Size = new Size(213, 23);
            tb_senha.TabIndex = 2;
            // 
            // tb_conf_senha
            // 
            tb_conf_senha.Location = new Point(42, 132);
            tb_conf_senha.Name = "tb_conf_senha";
            tb_conf_senha.PlaceholderText = "Confirmar senha";
            tb_conf_senha.Size = new Size(213, 23);
            tb_conf_senha.TabIndex = 3;
            // 
            // bt_cadastrar
            // 
            bt_cadastrar.Location = new Point(42, 190);
            bt_cadastrar.Name = "bt_cadastrar";
            bt_cadastrar.Size = new Size(75, 23);
            bt_cadastrar.TabIndex = 6;
            bt_cadastrar.Text = "Cadastrar";
            bt_cadastrar.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SkyBlue;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(tb_acesso);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(bt_login);
            panel3.Controls.Add(tb_senha_log);
            panel3.Controls.Add(tb_email_login);
            panel3.Location = new Point(533, 146);
            panel3.Name = "panel3";
            panel3.Size = new Size(322, 317);
            panel3.TabIndex = 20;
            // 
            // pictureBox6
            // 
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(284, 156);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(21, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 43;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(284, 156);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(20, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 42;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // tb_acesso
            // 
            tb_acesso.BackColor = Color.SkyBlue;
            tb_acesso.BorderStyle = BorderStyle.None;
            tb_acesso.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_acesso.Location = new Point(91, 90);
            tb_acesso.Name = "tb_acesso";
            tb_acesso.PlaceholderText = "Usuário ";
            tb_acesso.Size = new Size(159, 19);
            tb_acesso.TabIndex = 41;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PapayaWhip;
            panel2.Location = new Point(48, 196);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 1);
            panel2.TabIndex = 39;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.SkyBlue;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(49, 168);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 38;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PapayaWhip;
            panel1.Location = new Point(49, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            panel1.TabIndex = 37;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.SkyBlue;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(50, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.PapayaWhip;
            label3.Location = new Point(91, 4);
            label3.Name = "label3";
            label3.Size = new Size(131, 45);
            label3.TabIndex = 35;
            label3.Text = "LOG IN";
            // 
            // bt_login
            // 
            bt_login.BackColor = Color.White;
            bt_login.FlatStyle = FlatStyle.Flat;
            bt_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_login.Location = new Point(75, 231);
            bt_login.Name = "bt_login";
            bt_login.Size = new Size(175, 33);
            bt_login.TabIndex = 33;
            bt_login.Text = "Logar";
            bt_login.UseVisualStyleBackColor = false;
            bt_login.Click += bt_login_Click;
            // 
            // tb_senha_log
            // 
            tb_senha_log.BackColor = Color.SkyBlue;
            tb_senha_log.BorderStyle = BorderStyle.None;
            tb_senha_log.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_senha_log.Location = new Point(89, 167);
            tb_senha_log.Name = "tb_senha_log";
            tb_senha_log.PlaceholderText = "Senha";
            tb_senha_log.Size = new Size(181, 19);
            tb_senha_log.TabIndex = 32;
            tb_senha_log.UseSystemPasswordChar = true;
            // 
            // tb_email_login
            // 
            tb_email_login.BackColor = Color.DodgerBlue;
            tb_email_login.BorderStyle = BorderStyle.None;
            tb_email_login.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_email_login.ForeColor = SystemColors.MenuHighlight;
            tb_email_login.Location = new Point(85, 90);
            tb_email_login.Name = "tb_email_login";
            tb_email_login.Size = new Size(0, 17);
            tb_email_login.TabIndex = 31;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(608, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(527, 557);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 35;
            pictureBox4.TabStop = false;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.Black;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.Black;
            nightControlBox1.DisableMinimizeColor = Color.Black;
            nightControlBox1.EnableCloseColor = Color.Black;
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.Black;
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.Black;
            nightControlBox1.Location = new Point(770, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 36;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(893, 556);
            ControlBox = false;
            Controls.Add(nightControlBox1);
            Controls.Add(pictureBox4);
            Controls.Add(tb_conf_senha);
            Controls.Add(tb_nome);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            Controls.Add(tb_email);
            Controls.Add(bt_cadastrar);
            Controls.Add(tb_senha);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_nome;
        private TextBox tb_email;
        private TextBox tb_senha;
        private TextBox tb_conf_senha;
        private Button bt_cadastrar;
        private Panel panel3;
        private TextBox tb_acesso;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label3;
        private Button bt_login;
        private TextBox tb_senha_log;
        private TextBox tb_email_login;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}
