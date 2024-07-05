using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace EconomicaForm
{
    public partial class FrmInteresCompuesto : Form
    {
        private CalculationService _service;
        public FrmInteresCompuesto()
        {
            InitializeComponent();
            _service = new CalculationService();
        }
        private void btnCalVF_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(VFtxtVP.Text, out decimal presente) ||
              !decimal.TryParse(VFtxtTI.Text, out decimal tasaInteres) ||
              !decimal.TryParse(VFtxtPeriodo.Text, out decimal periodo))
            {
                MessageBox.Show("Por favor, ingrese valores válidos en todos los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var VF = new Interes()
            {
                Presente = presente,
                TasaInteres = tasaInteres,
                Periodo = periodo
            };

            List<string> errores = Validation.ValidarModelo(VF);
            if (errores.Count != 0)
            {
                string mensajeErrores = string.Join(Environment.NewLine, errores);
                MessageBox.Show("Errores de validación:" + Environment.NewLine + mensajeErrores, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal resultado = _service.CalcularICValorFuturo(VF);
                VFtxtResultado.Text = resultado.ToString();
            }

        }
        private void ClearVF()
        {
            VFtxtVP.Clear();
            VFtxtTI.Clear();
            VFtxtPeriodo.Clear();
            VFtxtResultado.Clear();
        }

        private void btnClearVF_Click(object sender, EventArgs e)
        {
            ClearVF();
        }
        private void btnCalVP_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(VPtxtVF.Text, out decimal futuro) ||
               !decimal.TryParse(VPtxtTI.Text, out decimal tasaInteres) ||
               !decimal.TryParse(VPtxtP.Text, out decimal periodo))
            {
                MessageBox.Show("Por favor, ingrese valores válidos en todos los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var VP = new Interes()
            {
                Futuro = futuro,
                TasaInteres = tasaInteres,
                Periodo = periodo
            };

            List<string> errores = Validation.ValidarModelo(VP);
            if (errores.Count != 0)
            {
                string mensajeErrores = string.Join(Environment.NewLine, errores);
                MessageBox.Show("Errores de validación:" + Environment.NewLine + mensajeErrores, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                decimal resultado = _service.CalcularICValorPresente(VP);
                VPtxtResultado.Text = resultado.ToString();
            }
        }
        private void ClearVP()
        {
            VPtxtVF.Clear();
            VPtxtTI.Clear();
            VPtxtP.Clear();
            VPtxtResultado.Clear();
        }

        private void btnClearVP_Click(object sender, EventArgs e)
        {
            ClearVP();
        }
        private void btnCalInteres_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(ItxtVP.Text, out decimal presente) ||
                !decimal.TryParse(ItxtVF.Text, out decimal futuro))
            {
                MessageBox.Show("Por favor, ingrese valores válidos en todos los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var interes = new Interes()
            {
                Presente = presente,
                Futuro = futuro,
            };

            List<string> errores = Validation.ValidarModelo(interes);
            if (errores.Count != 0)
            {
                string mensajeErrores = string.Join(Environment.NewLine, errores);
                MessageBox.Show("Errores de validación:" + Environment.NewLine + mensajeErrores, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                decimal resultado = _service.CalcularICInteres(interes);
                ItxtResultado.Text = resultado.ToString();
            }
        }
        private void ClearInteres()
        {
            ItxtVP.Clear();
            ItxtVF.Clear();
            ItxtP.Clear();
            ItxtResultado.Clear();
        }

        private void btnClearInteres_Click(object sender, EventArgs e)
        {
            ClearInteres();
        }
        private void btnCalPeriodo_Click(object sender, EventArgs e)
        {

            if (!decimal.TryParse(PtxtVP.Text, out decimal presente) ||
                !decimal.TryParse(PtxtTI.Text, out decimal tasaInteres) ||
                !decimal.TryParse(PtxtVF.Text, out decimal futuro))
            {
                MessageBox.Show("Por favor, ingrese valores válidos en todos los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var periodo = new Interes()
            {
                Presente = presente,
                TasaInteres = tasaInteres,
                Futuro = futuro
            };

            List<string> errores = Validation.ValidarModelo(periodo);
            if (errores.Count != 0)
            {
                string mensajeErrores = string.Join(Environment.NewLine, errores);
                MessageBox.Show("Errores de validación:" + Environment.NewLine + mensajeErrores, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                decimal resultado = _service.CalcularICTPeriodo(periodo);
                PtxtResultado.Text = resultado.ToString();
            }
        }
        private void ClearPeriodo()
        {
            PtxtVP.Clear();
            PtxtTI.Clear();
            PtxtVF.Clear();
            PtxtResultado.Clear();
        }

        private void btnClearPeriodo_Click(object sender, EventArgs e)
        {
            ClearPeriodo();
        }
    }
}
