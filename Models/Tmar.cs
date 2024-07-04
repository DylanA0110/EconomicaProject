using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Tmar
    {
        [Required]
        [Range(0, 100, ErrorMessage = "La tasa libre de riesgo debe estar entre 0 y 100.")]
        public decimal TasaLibreDeRiesgo { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "La prima de riesgo debe estar entre 0 y 100.")]
        public decimal PrimaDeRiesgo { get; set; }
    }
}
