namespace EconomicaForm
{
    partial class FrmAnualidades
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtTasaVP = new TextBox();
            label2 = new Label();
            txtMontoVP = new TextBox();
            label3 = new Label();
            btnCalVPVencida = new Button();
            groupBox1 = new GroupBox();
            txtPeriodoVP = new TextBox();
            label4 = new Label();
            label9 = new Label();
            txtVPResultado = new TextBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            btnCalVFVencida = new Button();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            pictureBox6 = new PictureBox();
            label27 = new Label();
            pictureBox2 = new PictureBox();
            label10 = new Label();
            groupBox3 = new GroupBox();
            pictureBox3 = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label13 = new Label();
            button1 = new Button();
            textBox7 = new TextBox();
            label14 = new Label();
            textBox8 = new TextBox();
            label15 = new Label();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            label16 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(4, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(875, 562);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(867, 533);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Anualidad Vencida";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(867, 533);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Anualidad Anticipada";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(867, 534);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Anualidad Diferida";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 63, 172);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(874, 53);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dinero;
            pictureBox1.Location = new Point(308, 6);
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
            label1.Location = new Point(355, 6);
            label1.Name = "label1";
            label1.Size = new Size(269, 32);
            label1.TabIndex = 1;
            label1.Text = "Anualidad Vencida";
            // 
            // txtTasaVP
            // 
            txtTasaVP.Font = new Font("Century", 12F, FontStyle.Bold);
            txtTasaVP.Location = new Point(169, 27);
            txtTasaVP.Name = "txtTasaVP";
            txtTasaVP.Size = new Size(135, 27);
            txtTasaVP.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Bold);
            label2.Location = new Point(27, 30);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 7;
            label2.Text = "Tasa interes:";
            // 
            // txtMontoVP
            // 
            txtMontoVP.Font = new Font("Century", 12F, FontStyle.Bold);
            txtMontoVP.Location = new Point(392, 23);
            txtMontoVP.Name = "txtMontoVP";
            txtMontoVP.Size = new Size(135, 27);
            txtMontoVP.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 12F, FontStyle.Bold);
            label3.Location = new Point(320, 27);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 9;
            label3.Text = "Monto:";
            // 
            // btnCalVPVencida
            // 
            btnCalVPVencida.FlatAppearance.BorderColor = Color.White;
            btnCalVPVencida.FlatAppearance.MouseDownBackColor = Color.White;
            btnCalVPVencida.FlatAppearance.MouseOverBackColor = Color.White;
            btnCalVPVencida.FlatStyle = FlatStyle.Flat;
            btnCalVPVencida.Image = Properties.Resources.calculadora;
            btnCalVPVencida.Location = new Point(27, 113);
            btnCalVPVencida.Name = "btnCalVPVencida";
            btnCalVPVencida.Size = new Size(193, 66);
            btnCalVPVencida.TabIndex = 10;
            btnCalVPVencida.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(label27);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtVPResultado);
            groupBox1.Controls.Add(txtPeriodoVP);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnCalVPVencida);
            groupBox1.Controls.Add(txtMontoVP);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTasaVP);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(15, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(784, 203);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Anualidad Vencida VP";
            // 
            // txtPeriodoVP
            // 
            txtPeriodoVP.Font = new Font("Century", 12F, FontStyle.Bold);
            txtPeriodoVP.Location = new Point(631, 23);
            txtPeriodoVP.Name = "txtPeriodoVP";
            txtPeriodoVP.Size = new Size(135, 27);
            txtPeriodoVP.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 12F, FontStyle.Bold);
            label4.Location = new Point(545, 26);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 12;
            label4.Text = "Periodos:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 12F, FontStyle.Bold);
            label9.Location = new Point(237, 135);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 14;
            label9.Text = "Resultado:";
            // 
            // txtVPResultado
            // 
            txtVPResultado.Font = new Font("Century", 12F, FontStyle.Bold);
            txtVPResultado.Location = new Point(340, 131);
            txtVPResultado.Name = "txtVPResultado";
            txtVPResultado.ReadOnly = true;
            txtVPResultado.Size = new Size(135, 27);
            txtVPResultado.TabIndex = 13;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnCalVFVencida);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(15, 298);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(784, 203);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Anualidad Vencida VF";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 12F, FontStyle.Bold);
            label5.Location = new Point(237, 135);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 14;
            label5.Text = "Resultado:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century", 12F, FontStyle.Bold);
            textBox3.Location = new Point(340, 131);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(135, 27);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Century", 12F, FontStyle.Bold);
            textBox4.Location = new Point(631, 23);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(135, 27);
            textBox4.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 12F, FontStyle.Bold);
            label6.Location = new Point(545, 26);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 12;
            label6.Text = "Periodos:";
            // 
            // btnCalVFVencida
            // 
            btnCalVFVencida.FlatAppearance.BorderColor = Color.White;
            btnCalVFVencida.FlatAppearance.MouseDownBackColor = Color.White;
            btnCalVFVencida.FlatAppearance.MouseOverBackColor = Color.White;
            btnCalVFVencida.FlatStyle = FlatStyle.Flat;
            btnCalVFVencida.Image = Properties.Resources.calculadora;
            btnCalVFVencida.Location = new Point(27, 113);
            btnCalVFVencida.Name = "btnCalVFVencida";
            btnCalVFVencida.Size = new Size(193, 66);
            btnCalVFVencida.TabIndex = 10;
            btnCalVFVencida.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Century", 12F, FontStyle.Bold);
            textBox5.Location = new Point(392, 23);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(135, 27);
            textBox5.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 12F, FontStyle.Bold);
            label7.Location = new Point(320, 27);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 9;
            label7.Text = "Monto:";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Century", 12F, FontStyle.Bold);
            textBox6.Location = new Point(169, 27);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(135, 27);
            textBox6.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 12F, FontStyle.Bold);
            label8.Location = new Point(27, 30);
            label8.Name = "label8";
            label8.Size = new Size(117, 20);
            label8.TabIndex = 7;
            label8.Text = "Tasa interes:";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.AAsdsssss;
            pictureBox6.Location = new Point(570, 118);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(159, 47);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Century", 12F, FontStyle.Bold);
            label27.Location = new Point(570, 95);
            label27.Name = "label27";
            label27.Size = new Size(139, 20);
            label27.TabIndex = 15;
            label27.Text = "Formula usada:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_2024_07_04_190836;
            pictureBox2.Location = new Point(570, 136);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(159, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 12F, FontStyle.Bold);
            label10.Location = new Point(570, 113);
            label10.Name = "label10";
            label10.Size = new Size(139, 20);
            label10.TabIndex = 17;
            label10.Text = "Formula usada:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox3);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(label15);
            groupBox3.Font = new Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(15, 70);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(784, 203);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Anualidad Vencia VP";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.AAsdsssss;
            pictureBox3.Location = new Point(570, 118);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(159, 47);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century", 12F, FontStyle.Bold);
            label11.Location = new Point(570, 95);
            label11.Name = "label11";
            label11.Size = new Size(139, 20);
            label11.TabIndex = 15;
            label11.Text = "Formula usada:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century", 12F, FontStyle.Bold);
            label12.Location = new Point(237, 135);
            label12.Name = "label12";
            label12.Size = new Size(97, 20);
            label12.TabIndex = 14;
            label12.Text = "Resultado:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century", 12F, FontStyle.Bold);
            textBox1.Location = new Point(340, 131);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(135, 27);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century", 12F, FontStyle.Bold);
            textBox2.Location = new Point(631, 23);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(135, 27);
            textBox2.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century", 12F, FontStyle.Bold);
            label13.Location = new Point(545, 26);
            label13.Name = "label13";
            label13.Size = new Size(85, 20);
            label13.TabIndex = 12;
            label13.Text = "Periodos:";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.calculadora;
            button1.Location = new Point(27, 113);
            button1.Name = "button1";
            button1.Size = new Size(193, 66);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Century", 12F, FontStyle.Bold);
            textBox7.Location = new Point(392, 23);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(135, 27);
            textBox7.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century", 12F, FontStyle.Bold);
            label14.Location = new Point(320, 27);
            label14.Name = "label14";
            label14.Size = new Size(66, 20);
            label14.TabIndex = 9;
            label14.Text = "Monto:";
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Century", 12F, FontStyle.Bold);
            textBox8.Location = new Point(169, 27);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(135, 27);
            textBox8.TabIndex = 6;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century", 12F, FontStyle.Bold);
            label15.Location = new Point(27, 30);
            label15.Name = "label15";
            label15.Size = new Size(117, 20);
            label15.TabIndex = 7;
            label15.Text = "Tasa interes:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 63, 172);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label16);
            panel2.Location = new Point(0, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(874, 53);
            panel2.TabIndex = 12;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.dinero;
            pictureBox4.Location = new Point(308, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 35);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(355, 6);
            label16.Name = "label16";
            label16.Size = new Size(303, 32);
            label16.TabIndex = 1;
            label16.Text = "Anualidad Anticipada";
            // 
            // FrmAnualidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 590);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAnualidades";
            Text = "FrmAnualidades";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtTasaVP;
        private Label label2;
        private TextBox txtMontoVP;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnCalVPVencida;
        private TextBox txtPeriodoVP;
        private Label label4;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private Button btnCalVFVencida;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private Label label9;
        private TextBox txtVPResultado;
        private PictureBox pictureBox2;
        private Label label10;
        private PictureBox pictureBox6;
        private Label label27;
        private GroupBox groupBox3;
        private PictureBox pictureBox3;
        private Label label11;
        private Label label12;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label13;
        private Button button1;
        private TextBox textBox7;
        private Label label14;
        private TextBox textBox8;
        private Label label15;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Label label16;
    }
}