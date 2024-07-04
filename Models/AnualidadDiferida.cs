using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AnualidadDiferida : Anualidad
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "El número de periodos de diferimiento debe ser mayor o igual a 1.")]
        public decimal PeriodosDiferimiento { get; set; }
    }

}
