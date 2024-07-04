namespace EconomicaForm
{
    partial class FrmConversorTasas
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
            txtResultado = new TextBox();
            label26 = new Label();
            btnCopiarTasa = new Button();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            btnCalcularTasa = new Button();
            txtTasa = new TextBox();
            cmbOp2 = new ComboBox();
            cmbOp1 = new ComboBox();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            label21 = new Label();
            label1 = new Label();
            cmbTipo = new ComboBox();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(684, 384);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(139, 23);
            txtResultado.TabIndex = 56;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Century", 12F, FontStyle.Bold);
            label26.Location = new Point(525, 386);
            label26.Name = "label26";
            label26.Size = new Size(153, 20);
            label26.TabIndex = 55;
            label26.Text = "Copiar resultado:";
            // 
            // btnCopiarTasa
            // 
            btnCopiarTasa.FlatAppearance.BorderColor = Color.White;
            btnCopiarTasa.FlatAppearance.MouseDownBackColor = Color.White;
            btnCopiarTasa.FlatAppearance.MouseOverBackColor = Color.White;
            btnCopiarTasa.FlatStyle = FlatStyle.Flat;
            btnCopiarTasa.Image = Properties.Resources.copiar_link;
            btnCopiarTasa.Location = new Point(593, 439);
            btnCopiarTasa.Name = "btnCopiarTasa";
            btnCopiarTasa.Size = new Size(193, 66);
            btnCopiarTasa.TabIndex = 54;
            btnCopiarTasa.UseVisualStyleBackColor = true;
            btnCopiarTasa.Click += btnCopiarTasa_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Century", 12F, FontStyle.Bold);
            label25.Location = new Point(552, 80);
            label25.Name = "label25";
            label25.Size = new Size(126, 20);
            label25.TabIndex = 53;
            label25.Text = "Valor tasa(%):";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Century", 12F, FontStyle.Bold);
            label24.Location = new Point(412, 247);
            label24.Name = "label24";
            label24.Size = new Size(22, 20);
            label24.TabIndex = 52;
            label24.Text = "A";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Century", 12F, FontStyle.Bold);
            label23.Location = new Point(525, 220);
            label23.Name = "label23";
            label23.Size = new Size(103, 20);
            label23.TabIndex = 51;
            label23.Text = "Nueva tasa";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Century", 12F, FontStyle.Bold);
            label22.Location = new Point(149, 220);
            label22.Name = "label22";
            label22.Size = new Size(120, 20);
            label22.TabIndex = 50;
            label22.Text = "Tasa original";
            // 
            // btnCalcularTasa
            // 
            btnCalcularTasa.FlatAppearance.BorderColor = Color.White;
            btnCalcularTasa.FlatAppearance.MouseDownBackColor = Color.White;
            btnCalcularTasa.FlatAppearance.MouseOverBackColor = Color.White;
            btnCalcularTasa.FlatStyle = FlatStyle.Flat;
            btnCalcularTasa.Image = Properties.Resources.calculadora;
            btnCalcularTasa.Location = new Point(309, 422);
            btnCalcularTasa.Name = "btnCalcularTasa";
            btnCalcularTasa.Size = new Size(193, 66);
            btnCalcularTasa.TabIndex = 49;
            btnCalcularTasa.UseVisualStyleBackColor = true;
            btnCalcularTasa.Click += btnCalcularTasa_Click;
            // 
            // txtTasa
            // 
            txtTasa.Location = new Point(510, 115);
            txtTasa.Name = "txtTasa";
            txtTasa.Size = new Size(216, 23);
            txtTasa.TabIndex = 48;
            // 
            // cmbOp2
            // 
            cmbOp2.FormattingEnabled = true;
            cmbOp2.Location = new Point(525, 243);
            cmbOp2.Name = "cmbOp2";
            cmbOp2.Size = new Size(182, 23);
            cmbOp2.TabIndex = 47;
            // 
            // cmbOp1
            // 
            cmbOp1.FormattingEnabled = true;
            cmbOp1.Location = new Point(138, 243);
            cmbOp1.Name = "cmbOp1";
            cmbOp1.Size = new Size(182, 23);
            cmbOp1.TabIndex = 46;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkViolet;
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(label21);
            panel5.Location = new Point(1, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(871, 53);
            panel5.TabIndex = 45;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.tasa_de_interes_flotante;
            pictureBox5.Location = new Point(237, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 35);
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.White;
            label21.Location = new Point(307, 6);
            label21.Name = "label21";
            label21.Size = new Size(289, 32);
            label21.TabIndex = 1;
            label21.Text = "Convertidor de Tasas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Bold);
            label1.Location = new Point(200, 91);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 58;
            label1.Text = "Tipo de tasa";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(189, 114);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(182, 23);
            cmbTipo.TabIndex = 57;
            // 
            // FrmConversorTasas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(875, 590);
            Controls.Add(label1);
            Controls.Add(cmbTipo);
            Controls.Add(txtResultado);
            Controls.Add(label26);
            Controls.Add(btnCopiarTasa);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(btnCalcularTasa);
            Controls.Add(txtTasa);
            Controls.Add(cmbOp2);
            Controls.Add(cmbOp1);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConversorTasas";
            Text = "FrmConversorTasas";
            Load += FrmConversorTasas_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Label label26;
        private Button btnCopiarTasa;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Button btnCalcularTasa;
        private TextBox txtTasa;
        private ComboBox cmbOp2;
        private ComboBox cmbOp1;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Label label21;
        private Label label1;
        private ComboBox cmbTipo;
    }
}