using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Inversion
    {
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "La inversión inicial debe ser mayor o igual a 0.")]
        public decimal InversionInicial { get; set; }

        [Required]
        public decimal[] FlujosDeCaja { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "La tasa de descuento debe estar entre 0 y 100.")]
        public decimal TasaDescuento { get; set; }
        public int T => FlujosDeCaja.Length - 1;
    }
}
