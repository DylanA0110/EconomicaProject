using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pago
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "El período debe ser un número entero positivo.")]
        public int Periodo { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "El principal debe ser positivo.")]
        public decimal Principal { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "El interés debe ser positivo.")]
        public decimal Interes { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "La cuota debe ser positiva.")]
        public decimal Cuota { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "El saldo debe ser positivo.")]
        public decimal Saldo { get; set; }
    }

}
