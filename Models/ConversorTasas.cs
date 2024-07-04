using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum TipoTasa
    {
        Nominal,
        Efectiva
    }

    public class ConversorTasas
    {
        public decimal ConvertirTasa(decimal tasa, string periodoActual, string periodoObjetivo, TipoTasa tipoTasa)
        {
            if (tipoTasa == TipoTasa.Efectiva)
            {
                return ConvertirTasaEfectiva(tasa, periodoActual, periodoObjetivo);
            }
            else
            {
                return ConvertirTasaNominal(tasa, periodoActual, periodoObjetivo);
            }
        }

        private decimal ConvertirTasaEfectiva(decimal tasa, string periodoActual, string periodoObjetivo)
        {
            if (periodoActual == "Anual" && periodoObjetivo == "Mensual")
                return (decimal)(Math.Pow((double)(1 + tasa / 100), 1.0 / 12.0) - 1) * 100;

            if (periodoActual == "Mensual" && periodoObjetivo == "Anual")
                return (decimal)(Math.Pow((double)(1 + tasa / 100 / 100), 12.0) - 1) * 100;

            if (periodoActual == "Anual" && periodoObjetivo == "Semestral")
                return (decimal)(Math.Pow((double)(1 + tasa / 100), 1.0 / 2.0) - 1) * 100;

            if (periodoActual == "Semestral" && periodoObjetivo == "Anual")
                return (decimal)(Math.Pow((double)(1 + tasa / 100 / 100), 2.0) - 1) * 100;

            if (periodoActual == "Anual" && periodoObjetivo == "Trimestral")
                return (decimal)(Math.Pow((double)(1 + tasa / 100), 1.0 / 4.0) - 1) * 100;

            if (periodoActual == "Trimestral" && periodoObjetivo == "Anual")
                return (decimal)(Math.Pow((double)(1 + tasa / 100 / 100), 4.0) - 1) * 100;

            if (periodoActual == "Semestral" && periodoObjetivo == "Trimestral")
                return (decimal)(Math.Pow((double)(1 + tasa / 100 / 100), 2.0 / 3.0) - 1) * 100;

            if (periodoActual == "Trimestral" && periodoObjetivo == "Semestral")
                return (decimal)(Math.Pow((double)(1 + tasa / 100 / 100), 3.0 / 2.0) - 1) * 100;

            if (periodoActual == "Trimestral" && periodoObjetivo == "Mensual")
                return (decimal)(Math.Pow((double)(1 + tasa / 100 / 100), 1.0 / 3.0) - 1) * 100;

            if (periodoActual == "Mensual" && periodoObjetivo == "Trimestral")
                return (decimal)(Math.Pow((double)(1 + tasa / 100 / 100), 3.0) - 1) * 100;

            return tasa;
        }

        private decimal ConvertirTasaNominal(decimal tasa, string periodoActual, string periodoObjetivo)
        {
            if (periodoActual == "Anual" && periodoObjetivo == "Mensual")
                return tasa / 12;

            if (periodoActual == "Mensual" && periodoObjetivo == "Anual")
                return tasa * 12;

            if (periodoActual == "Anual" && periodoObjetivo == "Semestral")
                return tasa / 2;

            if (periodoActual == "Semestral" && periodoObjetivo == "Anual")
                return tasa * 2;

            if (periodoActual == "Anual" && periodoObjetivo == "Trimestral")
                return tasa / 4;

            if (periodoActual == "Trimestral" && periodoObjetivo == "Anual")
                return tasa * 4;

            if (periodoActual == "Semestral" && periodoObjetivo == "Trimestral")
                return tasa / 2;

            if (periodoActual == "Trimestral" && periodoObjetivo == "Semestral")
                return tasa * 2;

            if (periodoActual == "Trimestral" && periodoObjetivo == "Mensual")
                return tasa / 3;

            if (periodoActual == "Mensual" && periodoObjetivo == "Trimestral")
                return tasa * 3;

            return tasa;
        }
    }
}
