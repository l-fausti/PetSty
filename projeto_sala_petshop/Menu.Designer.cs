namespace projeto_sala_petshop
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panel2 = new Panel();
            dungeonHeaderLabel2 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button14 = new Button();
            button12 = new Button();
            button11 = new Button();
            button5 = new Button();
            button6 = new Button();
            bt_alterar_senha = new Button();
            button7 = new Button();
            panel_home = new Panel();
            lblBemVindo = new ReaLTaiizor.Controls.FoxBigLabel();
            pb_5 = new PictureBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_5).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.NavajoWhite;
            panel2.Controls.Add(dungeonHeaderLabel2);
            panel2.Controls.Add(dungeonHeaderLabel1);
            panel2.Controls.Add(nightControlBox1);
            panel2.Location = new Point(220, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(671, 44);
            panel2.TabIndex = 6;
            // 
            // dungeonHeaderLabel2
            // 
            dungeonHeaderLabel2.AutoSize = true;
            dungeonHeaderLabel2.BackColor = Color.Transparent;
            dungeonHeaderLabel2.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dungeonHeaderLabel2.ForeColor = Color.Black;
            dungeonHeaderLabel2.Location = new Point(78, 14);
            dungeonHeaderLabel2.Name = "dungeonHeaderLabel2";
            dungeonHeaderLabel2.Size = new Size(158, 17);
            dungeonHeaderLabel2.TabIndex = 5;
            dungeonHeaderLabel2.Text = "Seu pet shop favorito";
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Arial", 12.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dungeonHeaderLabel1.ForeColor = Color.Black;
            dungeonHeaderLabel1.Location = new Point(8, 13);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(75, 19);
            dungeonHeaderLabel1.TabIndex = 5;
            dungeonHeaderLabel1.Text = "PetSty - ";
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.Black;
            nightControlBox1.DisableMinimizeColor = Color.Black;
            nightControlBox1.EnableCloseColor = Color.Black;
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.Black;
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.Black;
            nightControlBox1.Location = new Point(532, 0);
            nightControlBox1.MaximizeHoverColor = Color.Black;
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.Black;
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(3, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 101);
            panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, -33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 178);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.NavajoWhite;
            flowLayoutPanel1.Controls.Add(button14);
            flowLayoutPanel1.Controls.Add(button12);
            flowLayoutPanel1.Controls.Add(button11);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(bt_alterar_senha);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Location = new Point(0, 103);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(222, 429);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // button14
            // 
            button14.BackColor = Color.NavajoWhite;
            button14.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button14.Image = (Image)resources.GetObject("button14.Image");
            button14.ImageAlign = ContentAlignment.MiddleLeft;
            button14.Location = new Point(3, 3);
            button14.Name = "button14";
            button14.Padding = new Padding(2, 0, 0, 0);
            button14.Size = new Size(211, 50);
            button14.TabIndex = 7;
            button14.Text = "Home";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.NavajoWhite;
            button12.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.Image = (Image)resources.GetObject("button12.Image");
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(3, 59);
            button12.Name = "button12";
            button12.Padding = new Padding(2, 0, 0, 0);
            button12.Size = new Size(211, 50);
            button12.TabIndex = 8;
            button12.Text = "Serviços";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.NavajoWhite;
            button11.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(3, 115);
            button11.Name = "button11";
            button11.Padding = new Padding(2, 0, 0, 0);
            button11.Size = new Size(211, 50);
            button11.TabIndex = 7;
            button11.Text = "Produtos";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.NavajoWhite;
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 171);
            button5.Name = "button5";
            button5.Padding = new Padding(2, 0, 0, 0);
            button5.Size = new Size(211, 50);
            button5.TabIndex = 6;
            button5.Text = "Gerenciar\r\nUsuarios\r\n";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.NavajoWhite;
            button6.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(3, 227);
            button6.Name = "button6";
            button6.Padding = new Padding(2, 0, 0, 0);
            button6.Size = new Size(211, 50);
            button6.TabIndex = 6;
            button6.Text = "Histórico de\r\n Agendamentos";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // bt_alterar_senha
            // 
            bt_alterar_senha.BackColor = Color.NavajoWhite;
            bt_alterar_senha.FlatAppearance.BorderColor = Color.Black;
            bt_alterar_senha.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_alterar_senha.Image = (Image)resources.GetObject("bt_alterar_senha.Image");
            bt_alterar_senha.ImageAlign = ContentAlignment.MiddleLeft;
            bt_alterar_senha.Location = new Point(3, 283);
            bt_alterar_senha.Name = "bt_alterar_senha";
            bt_alterar_senha.Padding = new Padding(2, 0, 0, 0);
            bt_alterar_senha.Size = new Size(211, 50);
            bt_alterar_senha.TabIndex = 46;
            bt_alterar_senha.Text = "Alterar Senha";
            bt_alterar_senha.UseVisualStyleBackColor = false;
            bt_alterar_senha.Visible = false;
            bt_alterar_senha.Click += bt_alterar_senha_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.NavajoWhite;
            button7.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(3, 339);
            button7.Name = "button7";
            button7.Padding = new Padding(2, 0, 0, 0);
            button7.Size = new Size(211, 50);
            button7.TabIndex = 6;
            button7.Text = "Logout";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // panel_home
            // 
            panel_home.BackColor = Color.WhiteSmoke;
            panel_home.BorderStyle = BorderStyle.Fixed3D;
            panel_home.Controls.Add(lblBemVindo);
            panel_home.Controls.Add(pb_5);
            panel_home.Location = new Point(220, 41);
            panel_home.Margin = new Padding(4);
            panel_home.Name = "panel_home";
            panel_home.Size = new Size(671, 495);
            panel_home.TabIndex = 8;
            // 
            // lblBemVindo
            // 
            lblBemVindo.BackColor = Color.Transparent;
            lblBemVindo.Font = new Font("Segoe UI Semibold", 20F);
            lblBemVindo.ForeColor = Color.FromArgb(76, 88, 100);
            lblBemVindo.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            lblBemVindo.LineColor = Color.FromArgb(200, 200, 200);
            lblBemVindo.Location = new Point(197, 264);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(240, 41);
            lblBemVindo.TabIndex = 4;
            lblBemVindo.Text = "Bem vindo, admin!";
            // 
            // pb_5
            // 
            pb_5.AccessibleDescription = "";
            pb_5.AccessibleName = "";
            pb_5.Image = (Image)resources.GetObject("pb_5.Image");
            pb_5.Location = new Point(238, 100);
            pb_5.Name = "pb_5";
            pb_5.Size = new Size(159, 145);
            pb_5.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_5.TabIndex = 2;
            pb_5.TabStop = false;
            pb_5.UseWaitCursor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(901, 546);
            Controls.Add(panel_home);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            Padding = new Padding(25, 0, 0, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel_home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button12;
        private Button button11;
        private Button button14;
        private Button button5;
        private Button button7;
        //private Panel conteudo;
        private Panel panel3;
        private Panel panel_home;
        public PictureBox pb_5;
        private Button button6;
        private ReaLTaiizor.Controls.FoxBigLabel lblBemVindo;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel2;
        private Button bt_alterar_senha;
        private PictureBox pictureBox2;
        //private Panel conteudo1;
    }
}