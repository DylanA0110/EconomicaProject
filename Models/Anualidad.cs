using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Anualidad
    {
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "El monto de la anualidad (R) debe ser mayor o igual a 0.")]
        public decimal Monto { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "La tasa de interés debe estar entre 0 y 100.")]
        public decimal TasaInteres { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "El número de periodos debe ser mayor o igual a 1.")]
        public decimal Periodos { get; set; }
    }
}
