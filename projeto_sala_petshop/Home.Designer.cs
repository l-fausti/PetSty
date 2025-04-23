namespace projeto_sala_petshop
{
    partial class Home
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
            panel_home = new Panel();
            foxBigLabel1 = new ReaLTaiizor.Controls.FoxBigLabel();
            pb_5 = new PictureBox();
            panel_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_5).BeginInit();
            SuspendLayout();
            // 
            // panel_home
            // 
            panel_home.BackColor = Color.WhiteSmoke;
            panel_home.Controls.Add(foxBigLabel1);
            panel_home.Controls.Add(pb_5);
            panel_home.Location = new Point(-18, -1);
            panel_home.Name = "panel_home";
            panel_home.Size = new Size(814, 519);
            panel_home.TabIndex = 9;
            panel_home.Paint += panel_home_Paint;
            // 
            // foxBigLabel1
            // 
            foxBigLabel1.BackColor = Color.Transparent;
            foxBigLabel1.Font = new Font("Segoe UI Semibold", 20F);
            foxBigLabel1.ForeColor = Color.FromArgb(76, 88, 100);
            foxBigLabel1.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            foxBigLabel1.LineColor = Color.FromArgb(200, 200, 200);
            foxBigLabel1.Location = new Point(214, 265);
            foxBigLabel1.Name = "foxBigLabel1";
            foxBigLabel1.Size = new Size(240, 41);
            foxBigLabel1.TabIndex = 3;
            // 
            // pb_5
            // 
            pb_5.AccessibleDescription = "";
            pb_5.AccessibleName = "";
            pb_5.Location = new Point(253, 95);
            pb_5.Name = "pb_5";
            pb_5.Size = new Size(165, 145);
            pb_5.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_5.TabIndex = 2;
            pb_5.TabStop = false;
            pb_5.UseWaitCursor = true;
            pb_5.Click += pb_5_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 498);
            Controls.Add(panel_home);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            panel_home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_home;
        public PictureBox pb_5;
        private ReaLTaiizor.Controls.FoxBigLabel foxBigLabel1;
    }
}