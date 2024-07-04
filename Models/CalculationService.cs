using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CalculationService : ICalculationService
    {
        public decimal CalcularISValorFuturo(Interes interes)
        {
            return interes.Presente * (1 + (interes.TasaInteres / 100) * interes.Periodo);
        }

        public decimal CalcularISValorPresente(Interes interes)
        {
            return interes.Futuro / (1 + (interes.TasaInteres / 100) * interes.Periodo);
        }

        public decimal CalcularISInteres(Interes interes)
        {
            return interes.Presente * (interes.TasaInteres / 100) * interes.Periodo;
        }

        public decimal CalcularISTPeriodo(Interes interes)
        {
            return (interes.Futuro / interes.Presente - 1) / (interes.TasaInteres / 100);
        }

        public decimal CalcularICValorFuturo(Interes interes)
        {
            return interes.Presente * (decimal)Math.Pow((double)(1 + (interes.TasaInteres / 100)), (double)interes.Periodo);
        }

        public decimal CalcularICValorPresente(Interes interes)
        {
            return interes.Futuro / (decimal)Math.Pow((double)(1 + (interes.TasaInteres / 100)), (double)interes.Periodo);
        }

        public decimal CalcularICInteres(Interes interes)
        {
            return CalcularICValorFuturo(interes) - interes.Presente;
        }

        public decimal CalcularICTPeriodo(Interes interes)
        {
            return (decimal)(Math.Log((double)(interes.Futuro / interes.Presente)) / Math.Log((double)(1 + (interes.TasaInteres / 100))));
        }

        public decimal AnualidadVencidaVP(Anualidad anualidad)
        {
            return anualidad.Monto * (1 - (decimal)Math.Pow((double)(1 + anualidad.TasaInteres / 100), (double)-anualidad.Periodos)) / (anualidad.TasaInteres / 100);
        }

        public decimal AnualidadVencidaVF(Anualidad anualidad)
        {
            return anualidad.Monto * ((decimal)Math.Pow((double)(1 + anualidad.TasaInteres / 100), (double)anualidad.Periodos) - 1) / (anualidad.TasaInteres / 100);
        }

        public decimal AnualidadAnticipadaVP(Anualidad anualidad)
        {
            return AnualidadVencidaVP(anualidad) * (1 + anualidad.TasaInteres / 100);
        }

        public decimal AnualidadAnticipadaVF(Anualidad anualidad)
        {
            return AnualidadVencidaVF(anualidad) * (1 + anualidad.TasaInteres / 100);
        }

        public decimal AnualidadDiferidaVP(AnualidadDiferida anualidadDiferida)
        {
            return AnualidadVencidaVP(anualidadDiferida) / (decimal)Math.Pow((double)(1 + anualidadDiferida.TasaInteres / 100), (double)anualidadDiferida.PeriodosDiferimiento);
        }

        public decimal AnualidadDiferidaVF(AnualidadDiferida anualidadDiferida)
        {
            return AnualidadVencidaVF(anualidadDiferida) / (decimal)Math.Pow((double)(1 + anualidadDiferida.TasaInteres / 100), (double)anualidadDiferida.PeriodosDiferimiento);
        }

        public decimal CalcularTMAR(Tmar tmar)
        {
            return tmar.TasaLibreDeRiesgo + tmar.PrimaDeRiesgo;
        }

        public decimal CalcularTIR(Inversion inversion)
        {
            Func<decimal, decimal> npv = r => inversion.InversionInicial + inversion.FlujosDeCaja.Select((cashflow, t) => cashflow / (decimal)Math.Pow((double)(1 + r), t + 1)).Sum();
            decimal lowerBound = 0m;
            decimal upperBound = 1m;
            while (npv(upperBound) > 0)
            {
                lowerBound = upperBound;
                upperBound *= 2;
            }
            for (int i = 0; i < 100; i++)
            {
                decimal mid = (lowerBound + upperBound) / 2;
                decimal npvMid = npv(mid);
                if (Math.Abs(npvMid) < 0.0001m)
                {
                    return mid * 100;
                }
                if (npvMid > 0)
                {
                    lowerBound = mid;
                }
                else
                {
                    upperBound = mid;
                }
            }
            return lowerBound * 100;
        }

        public decimal CalcularVPN(Inversion inversion)
        {
            return inversion.InversionInicial + inversion.FlujosDeCaja.Select((cashflow, t) => cashflow / (decimal)Math.Pow((double)(1 + inversion.TasaDescuento / 100), t + 1)).Sum();
        }

        public List<Pago> GenerarCalendarioDePagos(Prestamo prestamo)
        {
            List<Pago> calendario = new List<Pago>();
            decimal tasaInteresMensual = prestamo.TasaInteresAnual / 12 / 100;
            decimal pagoMensual = prestamo.Monto * tasaInteresMensual / (1 - (decimal)Math.Pow((double)(1 + tasaInteresMensual), -prestamo.NumeroPeriodos));
            decimal saldo = prestamo.Monto;

            for (int i = 1; i <= prestamo.NumeroPeriodos; i++)
            {
                decimal interes = saldo * tasaInteresMensual;
                decimal principal = pagoMensual - interes;
                saldo -= principal;
                calendario.Add(new Pago { Periodo = i, Interes = interes, Principal = principal, Cuota = pagoMensual, Saldo = saldo });
            }

            return calendario;
        }


    }
}
