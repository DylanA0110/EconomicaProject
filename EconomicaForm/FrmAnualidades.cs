using System;
using System.Windows.Forms;
using Models; // Asegúrate de tener la referencia correcta al proyecto Models donde está definida CalculationService

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
    }
}
