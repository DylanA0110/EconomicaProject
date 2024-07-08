using System;
using System.Windows.Forms;
using Models;
using Models.Models; // Asegúrate de tener la referencia correcta al proyecto Models donde está definida CalculationService

namespace EconomicaForm
{
    public partial class FrmAnualidades : Form
    {
        private readonly CalculationService _calculationService;

        public FrmAnualidades()
        {
            InitializeComponent();
            _calculationService = new CalculationService(); // Instancia de CalculationService
        }
        private bool ValidateInputs(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                if (!decimal.TryParse(textBox.Text, out _))
                {
                    MessageBox.Show($"Please enter a valid number in {textBox.Name.Substring(3)}.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void btnCalVPVencida_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(VtxtTasaVP, VtxtMontoVP, VtxtPeriodoVP))
                return;

            var anualidad = new Anualidad
            {
                Monto = decimal.Parse(VtxtMontoVP.Text),
                TasaInteres = decimal.Parse(VtxtTasaVP.Text),
                Periodos = int.Parse(VtxtPeriodoVP.Text),
                TieneGradiente = chkGradienteVP.Checked
            };
            if (chkGradienteVP.Checked)
            {
                if (!ValidateInputs(VtxtGradienteVP))
                {
                    MessageBox.Show("Por favor, complete el campo Gradiente.", "Campo Gradiente Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    VtxtGradienteVP.Focus();
                    return;
                }

                anualidad.Gradiente = decimal.Parse(VtxtGradienteVP.Text);
            }
            else
            {
                anualidad.Gradiente = 0; // O puede ser un valor por defecto si es necesario.
            }

            decimal valorPresente = _calculationService.AnualidadVencidaVP(anualidad);
            VtxtVPResultado.Text = valorPresente.ToString("G");
        }

        private void btnCalVFVencida_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(VtxtTasaVF, VtxtMontoVF, VtxtPeriodoVF))
                return;

            var anualidad = new Anualidad
            {
                Monto = decimal.Parse(VtxtMontoVF.Text),
                TasaInteres = decimal.Parse(VtxtTasaVF.Text),
                Periodos = int.Parse(VtxtPeriodoVF.Text),
                TieneGradiente = chkGradienteVF.Checked

            };
            if (chkGradienteVF.Checked)
            {
                if (!ValidateInputs(VtxtGradienteVF))
                {
                    MessageBox.Show("Por favor, complete el campo Gradiente.", "Campo Gradiente Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    VtxtGradienteVF.Focus();
                    return;
                }

                anualidad.Gradiente = decimal.Parse(VtxtGradienteVF.Text);
            }
            else
            {
                anualidad.Gradiente = 0; // O puede ser un valor por defecto si es necesario.
            }
            decimal valorFuturo = _calculationService.AnualidadVencidaVF(anualidad);
            vTxtResultadoVF.Text = valorFuturo.ToString("G");
        }

        private void BtnCalVPAnticipada_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(AtxtTasaVP, AtxtMontoVP, AtxtPeriodoVP))
                return;

            var anualidad = new Anualidad
            {
                Monto = decimal.Parse(AtxtMontoVP.Text),
                TasaInteres = decimal.Parse(AtxtTasaVP.Text),
                Periodos = int.Parse(AtxtPeriodoVP.Text),
                TieneGradiente = AChkConGradienteVP.Checked
            };
            if (anualidad.TieneGradiente)
            {
                if (!ValidateInputs(AtxtGradienteVP))
                {
                    MessageBox.Show("Por favor, complete el campo Gradiente.", "Campo Gradiente Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    AtxtGradienteVP.Focus();
                    return;
                }

                anualidad.Gradiente = decimal.Parse(AtxtGradienteVP.Text);
            }
            else
            {
                anualidad.Gradiente = 0; // O puede ser un valor por defecto si es necesario.
            }

            decimal valorPresente = _calculationService.AnualidadAnticipadaVP(anualidad);
            AtxtResultado.Text = valorPresente.ToString("G");
        }

        private void btnCalVFAnticipada_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(AtxtTasaVF, AtxtMontoVF, AtxtPeriodoVF))
                return;

            var anualidad = new Anualidad
            {
                Monto = decimal.Parse(AtxtMontoVF.Text),
                TasaInteres = decimal.Parse(AtxtTasaVF.Text),
                Periodos = int.Parse(AtxtPeriodoVF.Text),
                TieneGradiente = AChkConGradienteVF.Checked
            };
            if (anualidad.TieneGradiente)
            {
                if (!ValidateInputs(AtxtGradienteVF))
                {
                    MessageBox.Show("Por favor, complete el campo Gradiente.", "Campo Gradiente Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    AtxtGradienteVF.Focus();
                    return;
                }

                anualidad.Gradiente = decimal.Parse(AtxtGradienteVF.Text);
            }
            else
            {
                anualidad.Gradiente = 0; // O puede ser un valor por defecto si es necesario.
            }

            decimal valorFuturo = _calculationService.AnualidadAnticipadaVF(anualidad);
            AtxtResultadoVF.Text = valorFuturo.ToString("G");
        }

        private void btnCalcularDiferidaVP_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(DtxtTasaVP, DtxtMontoVP, DtxtPeriodoMVP, DtxtPeriodoNVP))
                return;

            var anualidadDiferida = new AnualidadDiferida
            {
                Monto = decimal.Parse(DtxtMontoVP.Text),
                TasaInteres = decimal.Parse(DtxtTasaVP.Text),
                Periodos = int.Parse(DtxtPeriodoNVP.Text),
                PeriodosDiferimiento = int.Parse(DtxtPeriodoMVP.Text),
                TieneGradiente = DchkGradienteVP.Checked
            };
            if (anualidadDiferida.TieneGradiente)
            {
                if (!ValidateInputs(DtxtGradienteVP))
                {
                    MessageBox.Show("Por favor, complete el campo Gradiente.", "Campo Gradiente Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DtxtGradienteVP.Focus();
                    return;
                }

                anualidadDiferida.Gradiente = decimal.Parse(DtxtGradienteVP.Text);
            }
            else
            {
                anualidadDiferida.Gradiente = 0; // O puede ser un valor por defecto si es necesario.
            }


                decimal valorPresente = _calculationService.AnualidadDiferidaVP(anualidadDiferida);
            DtxtResultadoVP.Text = valorPresente.ToString("G");
        }

        private void btnCalcularVFDiferida_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(DtxtTasaVF, DtxtMontoVF, DtxtPeriodoMVF, DtxtPeriodoNVF))
                return;

            var anualidadDiferida = new AnualidadDiferida
            {
                Monto = decimal.Parse(DtxtMontoVF.Text),
                TasaInteres = decimal.Parse(DtxtTasaVF.Text),
                Periodos = int.Parse(DtxtPeriodoNVF.Text),
                PeriodosDiferimiento = int.Parse(DtxtPeriodoMVF.Text),
                TieneGradiente = DchkGradienteVF.Checked
            };
            if (anualidadDiferida.TieneGradiente)
            {
                if (!ValidateInputs(DtxtGradienteVF))
                {
                    MessageBox.Show("Por favor, complete el campo Gradiente.", "Campo Gradiente Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DtxtGradienteVF.Focus();
                    return;
                }

                anualidadDiferida.Gradiente = decimal.Parse(DtxtGradienteVF.Text);
            }
            else
            {
                anualidadDiferida.Gradiente = 0; // O puede ser un valor por defecto si es necesario.
            }

            decimal valorFuturo = _calculationService.AnualidadDiferidaVF(anualidadDiferida);
            DtxtResultadoVF.Text = valorFuturo.ToString("G");
        }

        private void btnClearVencida_Click(object sender, EventArgs e)
        {
            VtxtTasaVP.Clear();
            VtxtMontoVP.Clear();
            VtxtPeriodoVP.Clear();
            VtxtVPResultado.Clear();
            VtxtTasaVF.Clear();
            VtxtMontoVF.Clear();
            VtxtPeriodoVF.Clear();
            vTxtResultadoVF.Clear();
            VtxtGradienteVP.Clear();
            VtxtGradienteVF.Clear();
        }

        private void btnClearAnticipada_Click(object sender, EventArgs e)
        {
            AtxtTasaVP.Clear();
            AtxtMontoVP.Clear();
            AtxtPeriodoVP.Clear();
            AtxtResultado.Clear();
            AtxtTasaVF.Clear();
            AtxtMontoVF.Clear();
            AtxtPeriodoVF.Clear();
            AtxtResultadoVF.Clear();
            AtxtGradienteVP.Clear();
            AtxtGradienteVF.Clear();
        }

        private void btnClearDiferida_Click(object sender, EventArgs e)
        {
            DtxtTasaVP.Clear();
            DtxtMontoVP.Clear();
            DtxtPeriodoMVP.Clear();
            DtxtPeriodoNVP.Clear();
            DtxtResultadoVP.Clear();
            DtxtTasaVF.Clear();
            DtxtMontoVF.Clear();
            DtxtPeriodoMVF.Clear();
            DtxtPeriodoNVF.Clear();
            DtxtResultadoVF.Clear();
            DtxtGradienteVP.Clear();
            DtxtGradienteVF.Clear();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFormulas.Checked)
            {
                pbFormula2VF.Visible = true;
                pbFormula2VP.Visible = true;
            }
            else
            {
                pbFormula2VF.Visible = false;
                pbFormula2VP.Visible = false;
            }
        }

        private void AChckFormulasVer_CheckedChanged(object sender, EventArgs e)
        {
            if (AChckFormulasVer.Checked)
            {
                APbFormula2VP.Visible = true;
                APbFormula2VF.Visible = true;
            }
            else
            {
                APbFormula2VF.Visible = false;
                APbFormula2VP.Visible = false;
            }
        }

        private void DChckFormulasVer_CheckedChanged(object sender, EventArgs e)
        {
            if (DChckFormulasVer.Checked)
            {
                DPbFormula2VP.Visible = true;
                DPbFormula2VF.Visible = true;
            }
            else
            {
                DPbFormula2VF.Visible = false;
                DPbFormula2VP.Visible = false;
            }

        }

        private void chkGradienteVP_CheckedChanged(object sender, EventArgs e)
        {
            VtxtGradienteVP.Enabled = true;
        }

        private void chkGradienteVF_CheckedChanged(object sender, EventArgs e)
        {
            VtxtGradienteVF.Enabled = true;
        }

        private void AChkConGradienteVP_CheckedChanged(object sender, EventArgs e)
        {
            AtxtGradienteVP.Enabled = true;
        }

        private void AChkConGradienteVF_CheckedChanged(object sender, EventArgs e)
        {
            AtxtGradienteVF.Enabled = true;
        }

        private void DchkGradienteVP_CheckedChanged(object sender, EventArgs e)
        {
            DtxtGradienteVP.Enabled = true;
        }

        private void DchkGradienteVF_CheckedChanged(object sender, EventArgs e)
        {
            DtxtGradienteVF.Enabled = true;
        }
    }
}
