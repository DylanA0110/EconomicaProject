using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconomicaForm
{
    public partial class FrmIndicadores : Form
    {
        private readonly CalculationService _calculationService;
        public FrmIndicadores()
        {
            InitializeComponent();
            _calculationService = new CalculationService();
            ConfigurarDataGridView();
            ConfigurarDataGridView2();
        }
        private void ConfigurarDataGridView2()
        {
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("Año", "Año");
            dataGridView2.Columns.Add("Flujo", "Flujo de Caja");

            // Agregar una fila inicial
            dataGridView1.Rows.Add(0, 0);
        }
        private void ConfigurarDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Año", "Año");
            dataGridView1.Columns.Add("Flujo", "Flujo de Caja");

            // Agregar una fila inicial
            dataGridView1.Rows.Add(0, 0);
        }

        private void btnCalTMAR_Click(object sender, EventArgs e)
        {
            if (TryGetDecimalValues(out decimal[] valores, tmarTxtPrima, tmarTxtTasa))
            {
                decimal prima = valores[0];
                decimal tasa = valores[1];
                Tmar tmar = new Tmar()
                {
                    TasaLibreDeRiesgo = tasa,
                    PrimaDeRiesgo = prima
                };
                decimal resultado = _calculationService.CalcularTMAR(tmar);
                tmarTxtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Uno o más campos no contienen números decimales válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalTIR_Click(object sender, EventArgs e)
        {
            // Usa el método TryGetDecimalValues para validar los TextBox y obtener los valores decimales
            if (TryGetDecimalValues(out decimal[] valores, tirtxtInversion, tirTxtTasa))
            {
                // Captura los datos de flujo de caja desde el DataGridView
                decimal[] flujosDeCaja = new decimal[dataGridView1.Rows.Count];
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (decimal.TryParse(dataGridView1.Rows[i].Cells[1].Value?.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal flujo))
                    {
                        flujosDeCaja[i] = flujo;
                    }
                    else
                    {
                        MessageBox.Show("Uno o más valores en el flujo de caja no son números decimales válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Salir del método si hay un error en los datos de flujo de caja
                    }
                }

                // Crea una instancia de Inversion con los valores obtenidos
                Inversion inversion = new Inversion
                {
                    InversionInicial = valores[0],
                    TasaDescuento = valores[1],
                    FlujosDeCaja = flujosDeCaja
                };

                // Calcula la TIR usando la clase CalculationService
                decimal tir = _calculationService.CalcularTIR(inversion);
                txtTIR.Text = tir.ToString("N2") + "%";
            }
            else
            {
                MessageBox.Show("Uno o más campos no contienen números decimales válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcularVPN_Click(object sender, EventArgs e)
        {
            if (TryGetDecimalValuesAndFlujos(out decimal inversionInicial, out decimal tasaDescuento, out decimal[] flujosDeCaja, VPNtxtInvesion, VPNtxtTasa, dataGridView2))
            {
                Inversion inversion = new Inversion
                {
                    InversionInicial = inversionInicial,
                    TasaDescuento = tasaDescuento,
                    FlujosDeCaja = flujosDeCaja
                };

                try
                {
                    // Calcula el VPN usando la clase CalculationService
                    decimal vpn = _calculationService.CalcularVPN(inversion);
                    txtVPN.Text = vpn.ToString("N2");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al calcular TIR o VPN: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Uno o más campos o valores en el flujo de caja no son números decimales válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool TryGetDecimalValues(out decimal[] values, params TextBox[] textBoxes)
        {
            values = new decimal[textBoxes.Length];
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (!decimal.TryParse(textBoxes[i].Text, NumberStyles.Number, CultureInfo.InvariantCulture, out values[i]))
                {
                    return false; // Si uno de los TextBox no es un decimal válido, devuelve false
                }
            }
            return true; // Todos los TextBox son decimales válidos
        }

        private void btnAgregarFlujo_Click(object sender, EventArgs e)
        {
            int numeroDeAños = dataGridView1.Rows.Count;
            dataGridView1.Rows.Add(numeroDeAños, 0);

            // Actualiza los años en las filas después de agregar una nueva
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i; // Actualiza el año de la fila
            }
        }

        private void btnEliminarFlujo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                // Actualiza los años en las filas después de eliminar una
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i; // Actualiza el año de la fila
                }
            }
            else
            {
                MessageBox.Show("Debe haber al menos una fila.");
            }
        }
        public bool TryGetDecimalValuesAndFlujos(out decimal inversionInicial, out decimal tasaDescuento, out decimal[] flujosDeCaja, TextBox tbInversionInicial, TextBox tbTasaDescuento, DataGridView dgvFlujosDeCaja)
        {
            // Inicializa los valores de salida
            inversionInicial = 0;
            tasaDescuento = 0;
            flujosDeCaja = null;

            // Verifica si los valores de los TextBox son decimales válidos
            if (decimal.TryParse(tbInversionInicial.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out inversionInicial) &&
                decimal.TryParse(tbTasaDescuento.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out tasaDescuento))
            {
                // Verifica si los valores en el DataGridView son decimales válidos
                flujosDeCaja = new decimal[dgvFlujosDeCaja.Rows.Count];
                for (int i = 0; i < dgvFlujosDeCaja.Rows.Count; i++)
                {
                    if (decimal.TryParse(dgvFlujosDeCaja.Rows[i].Cells[1].Value?.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal flujo))
                    {
                        flujosDeCaja[i] = flujo;
                    }
                    else
                    {
                        // Si hay un valor inválido en el DataGridView, devuelve false
                        return false;
                    }
                }
                // Todos los TextBox y DataGridView son decimales válidos
                return true;
            }
            else
            {
                // Si hay un error en los TextBox, devuelve false y establece tasaDescuento en 0
                tasaDescuento = 0;
                return false;
            }
        }

        private void btnAgregarFlujo2_Click(object sender, EventArgs e)
        {
            int numeroDeAños = dataGridView2.Rows.Count;
            dataGridView2.Rows.Add(numeroDeAños, 0);

            // Actualiza los años en las filas después de agregar una nueva
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = i; // Actualiza el año de la fila
            }
        }

        private void btnEliminarFlujo2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 1)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);

                // Actualiza los años en las filas después de eliminar una
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    dataGridView2.Rows[i].Cells[0].Value = i; // Actualiza el año de la fila
                }
            }
            else
            {
                MessageBox.Show("Debe haber al menos una fila.");
            }
        }
    }
}
