namespace projeto_sala_petshop
{
    partial class Adocao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adocao));
            label12 = new Label();
            label13 = new Label();
            bt_adote_agora = new Button();
            bt_cad_pets = new Button();
            pn_adocao = new Panel();
            panel5 = new Panel();
            headerLabel4 = new ReaLTaiizor.Controls.HeaderLabel();
            pn_adocao.SuspendLayout();
            SuspendLayout();
            // 
            // label12
            // 
            label12.BackColor = Color.CornflowerBlue;
            label12.Cursor = Cursors.Hand;
            label12.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(172, 262);
            label12.Name = "label12";
            label12.Size = new Size(124, 35);
            label12.TabIndex = 59;
            label12.Text = "Adote agora";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.BackColor = Color.CornflowerBlue;
            label13.Cursor = Cursors.Hand;
            label13.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(350, 262);
            label13.Name = "label13";
            label13.Size = new Size(124, 35);
            label13.TabIndex = 58;
            label13.Text = "Cadastro de Pets Adotivos";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bt_adote_agora
            // 
            bt_adote_agora.Cursor = Cursors.Hand;
            bt_adote_agora.Image = (Image)resources.GetObject("bt_adote_agora.Image");
            bt_adote_agora.Location = new Point(172, 175);
            bt_adote_agora.Name = "bt_adote_agora";
            bt_adote_agora.Size = new Size(124, 122);
            bt_adote_agora.TabIndex = 57;
            bt_adote_agora.UseVisualStyleBackColor = true;
            bt_adote_agora.Click += bt_adote_agora_Click;
            // 
            // bt_cad_pets
            // 
            bt_cad_pets.Cursor = Cursors.Hand;
            bt_cad_pets.Image = (Image)resources.GetObject("bt_cad_pets.Image");
            bt_cad_pets.Location = new Point(350, 175);
            bt_cad_pets.Name = "bt_cad_pets";
            bt_cad_pets.Size = new Size(124, 122);
            bt_cad_pets.TabIndex = 56;
            bt_cad_pets.UseVisualStyleBackColor = true;
            bt_cad_pets.Click += bt_cad_pets_Click;
            // 
            // pn_adocao
            // 
            pn_adocao.Controls.Add(panel5);
            pn_adocao.Controls.Add(label12);
            pn_adocao.Controls.Add(headerLabel4);
            pn_adocao.Controls.Add(bt_adote_agora);
            pn_adocao.Controls.Add(label13);
            pn_adocao.Controls.Add(bt_cad_pets);
            pn_adocao.Location = new Point(0, 2);
            pn_adocao.Name = "pn_adocao";
            pn_adocao.Size = new Size(761, 501);
            pn_adocao.TabIndex = 60;
            pn_adocao.Paint += pn_adocao_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.NavajoWhite;
            panel5.Location = new Point(-21, 28);
            panel5.Name = "panel5";
            panel5.Size = new Size(1071, 12);
            panel5.TabIndex = 58;
            panel5.UseWaitCursor = true;
            // 
            // headerLabel4
            // 
            headerLabel4.AutoSize = true;
            headerLabel4.BackColor = Color.Transparent;
            headerLabel4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel4.ForeColor = Color.Black;
            headerLabel4.Location = new Point(12, 7);
            headerLabel4.Name = "headerLabel4";
            headerLabel4.Size = new Size(63, 18);
            headerLabel4.TabIndex = 57;
            headerLabel4.Text = " Adoção";
            // 
            // Adocao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(761, 501);
            Controls.Add(pn_adocao);
            Name = "Adocao";
            Text = "Adocao";
            pn_adocao.ResumeLayout(false);
            pn_adocao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label12;
        private Label label13;
        private Button bt_adote_agora;
        private Button bt_cad_pets;
        private Panel pn_adocao;
        private Panel panel5;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel4;
    }
}