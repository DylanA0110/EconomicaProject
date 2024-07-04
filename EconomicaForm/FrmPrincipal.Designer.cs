namespace EconomicaForm
{
    partial class FrmPrincipal
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
            panel1 = new Panel();
            btnHome = new Button();
            btnCalendario = new Button();
            btnIE = new Button();
            btnAnualidad = new Button();
            btnIC = new Button();
            btnIS = new Button();
            pictureBox1 = new PictureBox();
            panelContenedor = new Panel();
            PBMinimizar = new PictureBox();
            PBCerrar = new PictureBox();
            btnConversor = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCerrar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 52, 145);
            panel1.Controls.Add(btnConversor);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnCalendario);
            panel1.Controls.Add(btnIE);
            panel1.Controls.Add(btnAnualidad);
            panel1.Controls.Add(btnIC);
            panel1.Controls.Add(btnIS);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(144, 590);
            panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(17, 53, 149);
            btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 106, 148);
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 106, 148);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Image = Properties.Resources.retirement_home;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 119);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(144, 31);
            btnHome.TabIndex = 6;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnCalendario
            // 
            btnCalendario.FlatAppearance.BorderColor = Color.FromArgb(17, 53, 149);
            btnCalendario.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 106, 148);
            btnCalendario.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 106, 148);
            btnCalendario.FlatStyle = FlatStyle.Flat;
            btnCalendario.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalendario.ForeColor = Color.White;
            btnCalendario.Image = Properties.Resources.calendario;
            btnCalendario.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalendario.Location = new Point(0, 458);
            btnCalendario.Name = "btnCalendario";
            btnCalendario.Size = new Size(144, 55);
            btnCalendario.TabIndex = 5;
            btnCalendario.Text = "Calendario de pagos";
            btnCalendario.UseVisualStyleBackColor = true;
            // 
            // btnIE
            // 
            btnIE.FlatAppearance.BorderColor = Color.FromArgb(17, 53, 149);
            btnIE.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 106, 148);
            btnIE.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 106, 148);
            btnIE.FlatStyle = FlatStyle.Flat;
            btnIE.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIE.ForeColor = Color.White;
            btnIE.Image = Properties.Resources.signo_de_dolar;
            btnIE.ImageAlign = ContentAlignment.MiddleLeft;
            btnIE.Location = new Point(-3, 378);
            btnIE.Name = "btnIE";
            btnIE.Size = new Size(144, 49);
            btnIE.TabIndex = 4;
            btnIE.Text = "Indicadores Economicos";
            btnIE.UseVisualStyleBackColor = true;
            // 
            // btnAnualidad
            // 
            btnAnualidad.FlatAppearance.BorderColor = Color.FromArgb(17, 53, 149);
            btnAnualidad.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 106, 148);
            btnAnualidad.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 106, 148);
            btnAnualidad.FlatStyle = FlatStyle.Flat;
            btnAnualidad.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnualidad.ForeColor = Color.White;
            btnAnualidad.Image = Properties.Resources.signo_de_dolar;
            btnAnualidad.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnualidad.Location = new Point(0, 303);
            btnAnualidad.Name = "btnAnualidad";
            btnAnualidad.Size = new Size(144, 31);
            btnAnualidad.TabIndex = 3;
            btnAnualidad.Text = "Anualidades";
            btnAnualidad.UseVisualStyleBackColor = true;
            // 
            // btnIC
            // 
            btnIC.FlatAppearance.BorderColor = Color.FromArgb(17, 53, 149);
            btnIC.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 106, 148);
            btnIC.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 106, 148);
            btnIC.FlatStyle = FlatStyle.Flat;
            btnIC.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIC.ForeColor = Color.White;
            btnIC.Image = Properties.Resources.signo_de_dolar;
            btnIC.ImageAlign = ContentAlignment.MiddleLeft;
            btnIC.Location = new Point(-3, 234);
            btnIC.Name = "btnIC";
            btnIC.Size = new Size(147, 31);
            btnIC.TabIndex = 2;
            btnIC.Text = "Interes Compuesto";
            btnIC.UseVisualStyleBackColor = true;
            // 
            // btnIS
            // 
            btnIS.FlatAppearance.BorderColor = Color.FromArgb(17, 53, 149);
            btnIS.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 106, 148);
            btnIS.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 106, 148);
            btnIS.FlatStyle = FlatStyle.Flat;
            btnIS.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIS.ForeColor = Color.White;
            btnIS.Image = Properties.Resources.signo_de_dolar;
            btnIS.ImageAlign = ContentAlignment.MiddleLeft;
            btnIS.Location = new Point(0, 169);
            btnIS.Name = "btnIS";
            btnIS.Size = new Size(144, 31);
            btnIS.TabIndex = 1;
            btnIS.Text = "Interes Simple";
            btnIS.UseVisualStyleBackColor = true;
            btnIS.Click += btnIS_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(-3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(PBMinimizar);
            panelContenedor.Controls.Add(PBCerrar);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(144, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(875, 590);
            panelContenedor.TabIndex = 1;
            // 
            // PBMinimizar
            // 
            PBMinimizar.Image = Properties.Resources.minimizar_signo;
            PBMinimizar.Location = new Point(796, 3);
            PBMinimizar.Name = "PBMinimizar";
            PBMinimizar.Size = new Size(38, 30);
            PBMinimizar.TabIndex = 1;
            PBMinimizar.TabStop = false;
            // 
            // PBCerrar
            // 
            PBCerrar.Image = Properties.Resources.borrar__1_;
            PBCerrar.Location = new Point(840, 3);
            PBCerrar.Name = "PBCerrar";
            PBCerrar.Size = new Size(35, 30);
            PBCerrar.TabIndex = 0;
            PBCerrar.TabStop = false;
            // 
            // btnConversor
            // 
            btnConversor.FlatAppearance.BorderColor = Color.FromArgb(17, 53, 149);
            btnConversor.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 106, 148);
            btnConversor.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 106, 148);
            btnConversor.FlatStyle = FlatStyle.Flat;
            btnConversor.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConversor.ForeColor = Color.White;
            btnConversor.Image = Properties.Resources.signo_de_dolar;
            btnConversor.ImageAlign = ContentAlignment.MiddleLeft;
            btnConversor.Location = new Point(0, 529);
            btnConversor.Name = "btnConversor";
            btnConversor.Size = new Size(153, 31);
            btnConversor.TabIndex = 7;
            btnConversor.Text = "Conversor tasas";
            btnConversor.UseVisualStyleBackColor = true;
            btnConversor.Click += btnConversor_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1019, 590);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnIS;
        private Button btnCalendario;
        private Button btnIE;
        private Button btnAnualidad;
        private Button btnIC;
        private Button btnHome;
        private Panel panelContenedor;
        private PictureBox PBCerrar;
        private PictureBox PBMinimizar;
        private Button btnConversor;
    }
}