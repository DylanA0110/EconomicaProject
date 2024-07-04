using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Interes
    {
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "El valor presente debe ser positivo.")]
        public decimal Presente { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "La tasa de interés debe estar entre 0 y 100.")]
        public decimal TasaInteres { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "El período debe ser positivo.")]
        public decimal Periodo { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "El valor futuro debe ser positivo.")]
        public decimal Futuro { get; set; }
    }
}
