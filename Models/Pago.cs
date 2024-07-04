using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pago
    {
        public int Periodo { get; set; }
        public decimal Principal { get; set; }
        public decimal Interes { get; set; }
        public decimal Cuota { get; set; }
        public decimal Saldo { get; set; }
    }

}
