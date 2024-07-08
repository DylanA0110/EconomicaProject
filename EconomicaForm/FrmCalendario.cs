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
    public partial class FrmCalendario : Form
    {
        private readonly CalculationService _calculationService;
        public FrmCalendario()
        {
            InitializeComponent();
            _calculationService = new CalculationService();
        }
        private void ConfigurarDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Periodo", "Periodo");
            dataGridView1.Columns.Add("Principal", "Principal");
            dataGridView1.Columns.Add("Interes", "Interés");
            dataGridView1.Columns.Add("Cuota", "Cuota");
            dataGridView1.Columns.Add("Saldo", "Saldo");
        }

        private void FrmCalendario_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
        }

        private void btnGenerarCalendario_Click(object sender, EventArgs e)
        {
            try
            {
                decimal monto = decimal.Parse(txtMonto.Text);
                decimal tasaInteresAnual = decimal.Parse(txtTasa.Text);
                int numeroPeriodos = int.Parse(txtPeriodos.Text);

                Prestamo prestamo = new Prestamo
                {
                    Monto = monto,
                    TasaInteresAnual = tasaInteresAnual,
                    NumeroPeriodos = numeroPeriodos
                };

                List<Pago> calendarioDePagos = _calculationService.GenerarCalendarioDePagos(prestamo);

                // Limpiar el DataGridView antes de agregar nuevos datos
                dataGridView1.Rows.Clear();

                foreach (var pago in calendarioDePagos)
                {
                    dataGridView1.Rows.Add(pago.Periodo, pago.Principal.ToString("G"), pago.Interes.ToString("G"), pago.Cuota.ToString("G"), pago.Saldo.ToString("G"));
                }
                if (calendarioDePagos[0].Periodo == 0)
                {
                    Console.WriteLine("Period 0 is correctly added to the list.");
                }
                else
                {
                    Console.WriteLine("Period 0 is missing from the list.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
