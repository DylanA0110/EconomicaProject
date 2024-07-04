namespace EconomicaForm
{
    partial class FrmHome
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
            label1 = new Label();
            LOGO = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)LOGO).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(364, 20);
            label1.Name = "label1";
            label1.Size = new Size(93, 32);
            label1.TabIndex = 0;
            label1.Text = "HOME";
            // 
            // LOGO
            // 
            LOGO.Image = Properties.Resources.carrito_de_pasteles;
            LOGO.Location = new Point(171, 50);
            LOGO.Name = "LOGO";
            LOGO.Size = new Size(532, 490);
            LOGO.SizeMode = PictureBoxSizeMode.StretchImage;
            LOGO.TabIndex = 3;
            LOGO.TabStop = false;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(875, 590);
            Controls.Add(LOGO);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHome";
            Text = "FrmHome";
            ((System.ComponentModel.ISupportInitialize)LOGO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox LOGO;
    }
}