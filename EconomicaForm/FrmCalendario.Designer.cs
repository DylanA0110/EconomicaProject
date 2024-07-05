namespace EconomicaForm
{
    partial class FrmCalendario
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
            btnGenerarCalendario = new Button();
            dataGridView1 = new DataGridView();
            txtMonto = new TextBox();
            label6 = new Label();
            txtTasa = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtPeriodos = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGenerarCalendario
            // 
            btnGenerarCalendario.FlatAppearance.BorderColor = Color.White;
            btnGenerarCalendario.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnGenerarCalendario.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnGenerarCalendario.FlatStyle = FlatStyle.Flat;
            btnGenerarCalendario.Image = Properties.Resources.calendario__2_;
            btnGenerarCalendario.Location = new Point(743, 128);
            btnGenerarCalendario.Name = "btnGenerarCalendario";
            btnGenerarCalendario.Size = new Size(95, 44);
            btnGenerarCalendario.TabIndex = 40;
            btnGenerarCalendario.UseVisualStyleBackColor = true;
            btnGenerarCalendario.Click += btnGenerarCalendario_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 214);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(824, 259);
            dataGridView1.TabIndex = 37;
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Century", 12F, FontStyle.Bold);
            txtMonto.Location = new Point(446, 73);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(135, 27);
            txtMonto.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 12F, FontStyle.Bold);
            label6.Location = new Point(374, 76);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 34;
            label6.Text = "Monto:";
            // 
            // txtTasa
            // 
            txtTasa.Font = new Font("Century", 12F, FontStyle.Bold);
            txtTasa.Location = new Point(215, 73);
            txtTasa.Name = "txtTasa";
            txtTasa.Size = new Size(135, 27);
            txtTasa.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 12F, FontStyle.Bold);
            label5.Location = new Point(25, 76);
            label5.Name = "label5";
            label5.Size = new Size(185, 20);
            label5.TabIndex = 30;
            label5.Text = "Tasa interes (Anual):";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(871, 52);
            panel1.TabIndex = 41;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calendario__1_;
            pictureBox1.Location = new Point(214, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 35);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(279, 9);
            label1.Name = "label1";
            label1.Size = new Size(411, 32);
            label1.TabIndex = 1;
            label1.Text = "Generar Calendario de pagos";
            // 
            // txtPeriodos
            // 
            txtPeriodos.Font = new Font("Century", 12F, FontStyle.Bold);
            txtPeriodos.Location = new Point(743, 69);
            txtPeriodos.Name = "txtPeriodos";
            txtPeriodos.Size = new Size(120, 27);
            txtPeriodos.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Bold);
            label2.Location = new Point(587, 73);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 43;
            label2.Text = "Numero periodos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 12F, FontStyle.Bold);
            label3.Location = new Point(574, 139);
            label3.Name = "label3";
            label3.Size = new Size(179, 20);
            label3.TabIndex = 44;
            label3.Text = "Generar Calendario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 12F, FontStyle.Bold);
            label4.Location = new Point(329, 180);
            label4.Name = "label4";
            label4.Size = new Size(177, 20);
            label4.TabIndex = 45;
            label4.Text = "Calendario de pagos";
            // 
            // FrmCalendario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(875, 590);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPeriodos);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnGenerarCalendario);
            Controls.Add(dataGridView1);
            Controls.Add(txtMonto);
            Controls.Add(label6);
            Controls.Add(txtTasa);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCalendario";
            Text = "FrmCalendario";
            Load += FrmCalendario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerarCalendario;
        private DataGridView dataGridView1;
        private TextBox txtMonto;
        private Label label6;
        private TextBox txtTasa;
        private Label label5;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtPeriodos;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}