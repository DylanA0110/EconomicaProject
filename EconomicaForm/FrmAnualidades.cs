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
                Periodos = decimal.Parse(VtxtPeriodoVP.Text)
            };

            decimal valorPresente = _calculationService.AnualidadVencidaVP(anualidad);
            VtxtVPResultado.Text = valorPresente.ToString("F2");
        }

        private void btnCalVFVencida_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(VtxtTasaVF, VtxtMontoVF, VtxtPeriodoVF))
                return;

            var anualidad = new Anualidad
            {
                Monto = decimal.Parse(VtxtMontoVF.Text),
                TasaInteres = decimal.Parse(VtxtTasaVF.Text),
                Periodos = decimal.Parse(VtxtPeriodoVF.Text)
            };

            decimal valorFuturo = _calculationService.AnualidadVencidaVF(anualidad);
            vTxtResultadoVF.Text = valorFuturo.ToString("F2");
        }

        private void BtnCalVPAnticipada_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(AtxtTasaVP, AtxtMontoVP, AtxtPeriodoVP))
                return;

            var anualidad = new Anualidad
            {
                Monto = decimal.Parse(AtxtMontoVP.Text),
                TasaInteres = decimal.Parse(AtxtTasaVP.Text),
                Periodos = decimal.Parse(AtxtPeriodoVP.Text)
            };

            decimal valorPresente = _calculationService.AnualidadAnticipadaVP(anualidad);
            AtxtResultado.Text = valorPresente.ToString("F2");
        }

        private void btnCalVFAnticipada_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(AtxtTasaVF, AtxtMontoVF, AtxtPeriodoVF))
                return;

            var anualidad = new Anualidad
            {
                Monto = decimal.Parse(AtxtMontoVF.Text),
                TasaInteres = decimal.Parse(AtxtTasaVF.Text),
                Periodos = decimal.Parse(AtxtPeriodoVF.Text)
            };

            decimal valorFuturo = _calculationService.AnualidadAnticipadaVF(anualidad);
            AtxtResultadoVF.Text = valorFuturo.ToString("F2");
        }

        private void btnCalcularDiferidaVP_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(DtxtTasaVP, DtxtMontoVP, DtxtPeriodoMVP, DtxtPeriodoNVP))
                return;

            var anualidadDiferida = new AnualidadDiferida
            {
                Monto = decimal.Parse(DtxtMontoVP.Text),
                TasaInteres = decimal.Parse(DtxtTasaVP.Text),
                Periodos = decimal.Parse(DtxtPeriodoNVP.Text),
                PeriodosDiferimiento = decimal.Parse(DtxtPeriodoMVP.Text)
            };

            decimal valorPresente = _calculationService.AnualidadDiferidaVP(anualidadDiferida);
            DtxtResultadoVP.Text = valorPresente.ToString("F2");
        }

        private void btnCalcularVFDiferida_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(DtxtTasaVF, DtxtMontoVF, DtxtPeriodoMVF, DtxtPeriodoNVF))
                return;

            var anualidadDiferida = new AnualidadDiferida
            {
                Monto = decimal.Parse(DtxtMontoVF.Text),
                TasaInteres = decimal.Parse(DtxtTasaVF.Text),
                Periodos = decimal.Parse(DtxtPeriodoNVF.Text),
                PeriodosDiferimiento = decimal.Parse(DtxtPeriodoMVF.Text)
            };

            decimal valorFuturo = _calculationService.AnualidadDiferidaVF(anualidadDiferida);
            DtxtResultadoVF.Text = valorFuturo.ToString("F2");
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
        }
    }
}
