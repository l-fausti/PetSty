namespace projeto_sala_petshop
{
    partial class Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            panel2 = new Panel();
            headerLabel2 = new ReaLTaiizor.Controls.HeaderLabel();
            controlBox1 = new ReaLTaiizor.Controls.ControlBox();
            controlBox2 = new ReaLTaiizor.Controls.ControlBox();
            tb_estoque = new TextBox();
            bt_verificar = new Button();
            bt_buscar = new Button();
            label4 = new Label();
            label3 = new Label();
            button4 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.NavajoWhite;
            panel2.Location = new Point(-15, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(768, 10);
            panel2.TabIndex = 40;
            panel2.UseWaitCursor = true;
            // 
            // headerLabel2
            // 
            headerLabel2.AutoSize = true;
            headerLabel2.BackColor = Color.Transparent;
            headerLabel2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel2.ForeColor = Color.Black;
            headerLabel2.Location = new Point(12, 9);
            headerLabel2.Name = "headerLabel2";
            headerLabel2.Size = new Size(73, 18);
            headerLabel2.TabIndex = 39;
            headerLabel2.Text = "Produtos";
            // 
            // controlBox1
            // 
            controlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            controlBox1.BackColor = Color.FromArgb(32, 34, 37);
            controlBox1.CloseHoverColor = Color.FromArgb(230, 17, 35);
            controlBox1.DefaultLocation = true;
            controlBox1.EnableHoverHighlight = true;
            controlBox1.EnableMaximizeButton = true;
            controlBox1.EnableMinimizeButton = true;
            controlBox1.ForeColor = Color.FromArgb(155, 155, 155);
            controlBox1.Location = new Point(656, 18);
            controlBox1.MaximizeHoverColor = Color.FromArgb(74, 74, 74);
            controlBox1.MinimizeHoverColor = Color.FromArgb(63, 63, 65);
            controlBox1.Name = "controlBox1";
            controlBox1.Size = new Size(90, 25);
            controlBox1.TabIndex = 41;
            controlBox1.Text = "controlBox1";
            // 
            // controlBox2
            // 
            controlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            controlBox2.BackColor = Color.FromArgb(32, 34, 37);
            controlBox2.CloseHoverColor = Color.FromArgb(230, 17, 35);
            controlBox2.DefaultLocation = true;
            controlBox2.EnableHoverHighlight = true;
            controlBox2.EnableMaximizeButton = true;
            controlBox2.EnableMinimizeButton = true;
            controlBox2.ForeColor = Color.FromArgb(155, 155, 155);
            controlBox2.Location = new Point(656, 18);
            controlBox2.MaximizeHoverColor = Color.FromArgb(74, 74, 74);
            controlBox2.MinimizeHoverColor = Color.FromArgb(63, 63, 65);
            controlBox2.Name = "controlBox2";
            controlBox2.Size = new Size(90, 25);
            controlBox2.TabIndex = 43;
            controlBox2.Text = "controlBox2";
            // 
            // tb_estoque
            // 
            tb_estoque.Location = new Point(47, 41);
            tb_estoque.Name = "tb_estoque";
            tb_estoque.Size = new Size(289, 23);
            tb_estoque.TabIndex = 44;
            // 
            // bt_verificar
            // 
            bt_verificar.BackColor = SystemColors.GradientActiveCaption;
            bt_verificar.Location = new Point(47, 70);
            bt_verificar.Name = "bt_verificar";
            bt_verificar.Size = new Size(129, 40);
            bt_verificar.TabIndex = 46;
            bt_verificar.Text = "Verificar Estoque";
            bt_verificar.UseVisualStyleBackColor = false;
            // 
            // bt_buscar
            // 
            bt_buscar.BackColor = SystemColors.GradientActiveCaption;
            bt_buscar.Location = new Point(205, 70);
            bt_buscar.Name = "bt_buscar";
            bt_buscar.Size = new Size(131, 40);
            bt_buscar.TabIndex = 47;
            bt_buscar.Text = "Buscar por produto";
            bt_buscar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.BackColor = Color.CornflowerBlue;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(365, 274);
            label4.Name = "label4";
            label4.Size = new Size(124, 26);
            label4.TabIndex = 53;
            label4.Text = "Adicionar Produtos";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.CornflowerBlue;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(193, 274);
            label3.Name = "label3";
            label3.Size = new Size(124, 26);
            label3.TabIndex = 52;
            label3.Text = "Buscar Produtos";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(365, 178);
            button4.Name = "button4";
            button4.Size = new Size(124, 122);
            button4.TabIndex = 51;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(193, 178);
            button3.Name = "button3";
            button3.Size = new Size(124, 122);
            button3.TabIndex = 50;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(672, 618);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(panel2);
            Controls.Add(headerLabel2);
            Name = "Produtos";
            Text = "Produtos";
            Load += Produtos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel2;
        private ReaLTaiizor.Controls.ControlBox controlBox1;
        private ReaLTaiizor.Controls.ControlBox controlBox2;
        private TextBox tb_estoque;
        private Button bt_verificar;
        private Button bt_buscar;
        private Label label4;
        private Label label3;
        private Button button4;
        private Button button3;
    }
}