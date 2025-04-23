namespace projeto_sala_petshop
{
    partial class Gerenciar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerenciar));
            headerLabel3 = new ReaLTaiizor.Controls.HeaderLabel();
            panel2 = new Panel();
            panel_gerenciar_usuarios = new Panel();
            label1 = new Label();
            label3 = new Label();
            bt_registro_usuarios = new Button();
            bt_cadastro_usuarios = new Button();
            panel_gerenciar_usuarios.SuspendLayout();
            SuspendLayout();
            // 
            // headerLabel3
            // 
            headerLabel3.AutoSize = true;
            headerLabel3.BackColor = Color.Transparent;
            headerLabel3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel3.ForeColor = Color.Black;
            headerLabel3.Location = new Point(13, 8);
            headerLabel3.Name = "headerLabel3";
            headerLabel3.Size = new Size(146, 18);
            headerLabel3.TabIndex = 42;
            headerLabel3.Text = "Gerenciar Usuários";
            // 
            // panel2
            // 
            panel2.BackColor = Color.NavajoWhite;
            panel2.Location = new Point(-22, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(767, 10);
            panel2.TabIndex = 43;
            panel2.UseWaitCursor = true;
            // 
            // panel_gerenciar_usuarios
            // 
            panel_gerenciar_usuarios.Controls.Add(label1);
            panel_gerenciar_usuarios.Controls.Add(label3);
            panel_gerenciar_usuarios.Controls.Add(bt_registro_usuarios);
            panel_gerenciar_usuarios.Controls.Add(bt_cadastro_usuarios);
            panel_gerenciar_usuarios.Controls.Add(headerLabel3);
            panel_gerenciar_usuarios.Controls.Add(panel2);
            panel_gerenciar_usuarios.Location = new Point(-1, 1);
            panel_gerenciar_usuarios.Name = "panel_gerenciar_usuarios";
            panel_gerenciar_usuarios.Size = new Size(736, 496);
            panel_gerenciar_usuarios.TabIndex = 184;
            // 
            // label1
            // 
            label1.BackColor = Color.CornflowerBlue;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(391, 274);
            label1.Name = "label1";
            label1.Size = new Size(124, 26);
            label1.TabIndex = 186;
            label1.Text = "Registro de Usuários";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.CornflowerBlue;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(177, 274);
            label3.Name = "label3";
            label3.Size = new Size(124, 26);
            label3.TabIndex = 185;
            label3.Text = "Cadastro de Usuários";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bt_registro_usuarios
            // 
            bt_registro_usuarios.Cursor = Cursors.Hand;
            bt_registro_usuarios.Image = (Image)resources.GetObject("bt_registro_usuarios.Image");
            bt_registro_usuarios.Location = new Point(391, 178);
            bt_registro_usuarios.Name = "bt_registro_usuarios";
            bt_registro_usuarios.Size = new Size(124, 122);
            bt_registro_usuarios.TabIndex = 184;
            bt_registro_usuarios.UseVisualStyleBackColor = true;
            bt_registro_usuarios.Click += bt_registro_usuarios_Click;
            // 
            // bt_cadastro_usuarios
            // 
            bt_cadastro_usuarios.Cursor = Cursors.Hand;
            bt_cadastro_usuarios.Image = (Image)resources.GetObject("bt_cadastro_usuarios.Image");
            bt_cadastro_usuarios.Location = new Point(177, 178);
            bt_cadastro_usuarios.Name = "bt_cadastro_usuarios";
            bt_cadastro_usuarios.Size = new Size(124, 122);
            bt_cadastro_usuarios.TabIndex = 45;
            bt_cadastro_usuarios.UseVisualStyleBackColor = true;
            bt_cadastro_usuarios.Click += bt_cadastro_usuarios_Click;
            // 
            // Gerenciar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(736, 498);
            Controls.Add(panel_gerenciar_usuarios);
            Name = "Gerenciar";
            Text = "Gerenciar";
            panel_gerenciar_usuarios.ResumeLayout(false);
            panel_gerenciar_usuarios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HeaderLabel headerLabel3;
        private Panel panel2;
        private Panel panel_gerenciar_usuarios;
        private Button bt_registro_usuarios;
        private Button bt_cadastro_usuarios;
        private Label label1;
        private Label label3;
    }
}