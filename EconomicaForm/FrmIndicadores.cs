using Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
            dataGridView2.Rows.Add(0, 0);
            dataGridView2.Columns[0].Width = 200;
            dataGridView2.Columns[1].DefaultCellStyle.Format = "N2";

            // Hacer que las celdas sean editables
            dataGridView2.Columns[1].CellTemplate.Style.BackColor = System.Drawing.Color.White;
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Año", "Año");
            dataGridView1.Columns.Add("Flujo", "Flujo de Caja");

            // Agregar una fila inicial
            dataGridView1.Rows.Add(0, 0);
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].DefaultCellStyle.Format = "N2";

            // Hacer que las celdas sean editables
            dataGridView1.Columns[1].CellTemplate.Style.BackColor = System.Drawing.Color.White;
        }

        private void btnAgregarFlujos1_Click(object sender, EventArgs e)
        {
            if (ValidateTextBox(txtFlujo1, out decimal flujo))
            {
                int numeroDeAños = dataGridView1.Rows.Count;
                dataGridView1.Rows.Add(numeroDeAños, flujo);

                // Actualiza los años en las filas después de agregar una nueva
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i; // Actualiza el año de la fila
                }

                txtFlujo1.Clear();
            }
        }

        private void btnAgregarFlujos2_Click(object sender, EventArgs e)
        {
            if (ValidateTextBox(txtFlujo2, out decimal flujo))
            {
                int numeroDeAños = dataGridView2.Rows.Count;
                dataGridView2.Rows.Add(numeroDeAños, flujo);

                // Actualiza los años en las filas después de agregar una nueva
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    dataGridView2.Rows[i].Cells[0].Value = i; // Actualiza el año de la fila
                }

                txtFlujo2.Clear();
            }
        }

        private void btnAgregarFlujoIndividual_Click(object sender, EventArgs e)
        {
            if (ValidateTextBox(txtFlujo1, out decimal flujo))
            {
                int numeroDeAños = dataGridView1.Rows.Count;
                dataGridView1.Rows.Add(numeroDeAños, flujo);

                // Actualiza los años en las filas después de agregar una nueva
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i; // Actualiza el año de la fila
                }

                txtFlujo1.Clear();
            }
        }

        private void btnAgregarFlujo1_Click(object sender, EventArgs e)
        {
            int numeroDeAños = dataGridView1.Rows.Count;
            dataGridView1.Rows.Add(numeroDeAños, 0);

            // Actualiza los años en las filas después de agregar una nueva
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i; // Actualiza el año de la fila
            }
        }

        private void btnEliminarFlujo1_Click(object sender, EventArgs e)
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

        private void btnCalTMAR_Click(object sender, EventArgs e)
        {
            if (ValidateInputs(tmarTxtPrima, tmarTxtTasa))
            {
                decimal prima = decimal.Parse(tmarTxtPrima.Text, NumberStyles.Number, CultureInfo.InvariantCulture);
                decimal tasa = decimal.Parse(tmarTxtTasa.Text, NumberStyles.Number, CultureInfo.InvariantCulture);
                Tmar tmar = new Tmar()
                {
                    TasaLibreDeRiesgo = tasa,
                    PrimaDeRiesgo = prima
                };
                decimal resultado = _calculationService.CalcularTMAR(tmar);
                tmarTxtResultado.Text = resultado.ToString("N2");
            }
        }

        private void btnCalTIR_Click(object sender, EventArgs e)
        {
            if (ValidateInputs(tirtxtInversion, tirTxtTasa) && ValidateDataGridView(dataGridView1, out decimal[] flujosDeCaja))
            {
                Inversion inversion = new Inversion
                {
                    InversionInicial = decimal.Parse(tirtxtInversion.Text, NumberStyles.Number, CultureInfo.InvariantCulture),
                    TasaDescuento = decimal.Parse(tirTxtTasa.Text, NumberStyles.Number, CultureInfo.InvariantCulture) / 100, // Convertir a decimal entre 0 y 1
                    FlujosDeCaja = flujosDeCaja
                };

                if (inversion.TasaDescuento < 0 || inversion.TasaDescuento > 1)
                {
                    MessageBox.Show("La tasa de descuento debe estar entre 0 y 1 (en formato decimal).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    decimal tir = _calculationService.CalcularTIR(inversion);
                    txtTIR.Text = tir.ToString("N2") + "%";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al calcular TIR: " + ex.Message);
                }
            }
        }

        private void btnCalcularVPN_Click(object sender, EventArgs e)
        {

            if (ValidateInputs(VPNtxtInvesion, VPNtxtTasa) && ValidateDataGridView(dataGridView2, out decimal[] flujosDeCaja))
            {
                Inversion inversion = new Inversion
                {
                    InversionInicial = decimal.Parse(VPNtxtInvesion.Text, NumberStyles.Number, CultureInfo.InvariantCulture),
                    TasaDescuento = decimal.Parse(VPNtxtTasa.Text, NumberStyles.Number, CultureInfo.InvariantCulture) / 100, // Convertir a decimal entre 0 y 1
                    FlujosDeCaja = flujosDeCaja
                };

                try
                {
                    // Calculamos el VPN
                    decimal vpn = _calculationService.CalcularVPN(inversion);
                    txtVPN.Text = vpn.ToString("N2");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al calcular VPN: " + ex.Message);
                }
            }
        }

        private void ClearTMAR()
        {
            tmarTxtPrima.Clear();
            tmarTxtTasa.Clear();
            tmarTxtResultado.Clear();
        }

        private void ClearTIR()
        {
            tirtxtInversion.Clear();
            tirTxtTasa.Clear();
            txtTIR.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(0, 0); // Fila inicial
        }

        private void ClearVPN()
        {
            VPNtxtInvesion.Clear();
            VPNtxtTasa.Clear();
            txtVPN.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(0, 0); // Fila inicial
        }
        private bool ValidateTextBox(TextBox textBox, out decimal value)
        {
            if (string.IsNullOrEmpty(textBox.Text) || !decimal.TryParse(textBox.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out value))
            {
                MessageBox.Show("El valor ingresado no es un número decimal válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = 0;
                return false;
            }
            return true;
        }

        private bool ValidateInputs(TextBox txtPrima, TextBox txtTasa)
        {
            if (string.IsNullOrEmpty(txtPrima.Text) || !decimal.TryParse(txtPrima.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out _))
            {
                MessageBox.Show("El valor ingresado en Prima no es un número decimal válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtTasa.Text) || !decimal.TryParse(txtTasa.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out _))
            {
                MessageBox.Show("El valor ingresado en Tasa no es un número decimal válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidateDataGridView(DataGridView dgv, out decimal[] flujosDeCaja)
        {
            List<decimal> flujos = new List<decimal>();
            bool isFirstRow = true;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells[1].Value != null && decimal.TryParse(row.Cells[1].Value.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal flujo))
                {
                    if (isFirstRow && flujo == 0)
                    {
                        // Permitir que el primer flujo de caja sea 0 como valor inicial
                        isFirstRow = false;
                    }
                    else if (flujo != 0)
                    {
                        // Asegurarse de que el flujo no sea 0 para filas posteriores
                        flujos.Add(flujo);
                    }
                    else
                    {
                        MessageBox.Show("Los flujos de caja no pueden ser 0, excepto el inicial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flujosDeCaja = new decimal[0];
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Uno o más valores en el flujo de caja no son números decimales válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flujosDeCaja = new decimal[0];
                    return false;
                }
            }

            flujosDeCaja = flujos.ToArray();
            return flujos.Count > 0; // Asegurarse de que haya al menos un flujo de caja válido
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateTextBox(txtFlujo2, out decimal flujo))
            {
                int numeroDeAños = dataGridView1.Rows.Count;
                dataGridView2.Rows.Add(numeroDeAños, flujo);

                // Actualiza los años en las filas después de agregar una nueva
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    dataGridView2.Rows[i].Cells[0].Value = i; // Actualiza el año de la fila
                }

                txtFlujo2.Clear();
            }
        }

        private void btnClearTMAR_Click(object sender, EventArgs e)
        {
            ClearTMAR();
        }

        private void btnClearTIR_Click(object sender, EventArgs e)
        {
            ClearTIR();
        }

        private void btnClearVPN_Click(object sender, EventArgs e)
        {
            ClearVPN();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
