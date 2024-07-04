using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconomicaForm
{
    public partial class FrmConversorTasas : Form
    {
        private ConversorTasas _conversor;
        public FrmConversorTasas()
        {
            InitializeComponent();
            _conversor = new ConversorTasas();
        }

        private void FrmConversorTasas_Load(object sender, EventArgs e)
        {
            cmbOp1.Items.AddRange(new string[] { "Anual", "Semestral", "Trimestral", "Mensual" });
            cmbOp2.Items.AddRange(new string[] { "Anual", "Semestral", "Trimestral", "Mensual" });
            cmbTipo.Items.AddRange(new string[] { "Nominal", "Efectiva" });

            // Selecciona un valor por defecto
            cmbOp1.SelectedIndex = 0;
            cmbOp2.SelectedIndex = 1;
            cmbTipo.SelectedIndex = 0;

            txtResultado.ReadOnly = true;
        }

        private void btnCalcularTasa_Click(object sender, EventArgs e)
        {
            {
                // Obtiene los valores del formulario
                decimal tasa = decimal.Parse(txtTasa.Text);
                string periodoActual = cmbOp1.SelectedItem.ToString();
                string periodoObjetivo = cmbOp2.SelectedItem.ToString();
                TipoTasa tipoTasa = cmbTipo.SelectedItem.ToString() == "Nominal" ? TipoTasa.Nominal : TipoTasa.Efectiva;

                // Convierte la tasa
                decimal tasaConvertida = _conversor.ConvertirTasa(tasa, periodoActual, periodoObjetivo, tipoTasa);
                txtResultado.Text = tasaConvertida.ToString("F2") + "%";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese una tasa válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopiarTasa_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si hay texto en txtResultado
                if (string.IsNullOrWhiteSpace(txtResultado.Text))
                {
                    MessageBox.Show("No hay ningún resultado para copiar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Copia el resultado al portapapeles
                Clipboard.SetText(txtResultado.Text);
                MessageBox.Show("Resultado copiado al portapapeles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir
                MessageBox.Show($"Ocurrió un error al copiar el resultado al portapapeles.\nDetalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
