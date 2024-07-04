using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class CalculationService : ICalculationService
    {
        // Interés Simple

        public decimal CalcularISValorFuturo(Interes interes)
        {
            // Fórmula: VF = VP * (1 + i * n)
            return interes.Presente * (1 + (interes.TasaInteres / 100) * interes.Periodo);
        }

        public decimal CalcularISValorPresente(Interes interes)
        {
            // Fórmula: VP = VF / (1 + i * n)
            return interes.Futuro / (1 + (interes.TasaInteres / 100) * interes.Periodo);
        }

        public decimal CalcularISInteres(Interes interes)
        {
            // Fórmula: I = VP * i * n
            return interes.Presente * (interes.TasaInteres / 100) * interes.Periodo;
        }

        public decimal CalcularISTPeriodo(Interes interes)
        {
            // Fórmula: n = (VF / VP - 1) / i
            return (interes.Futuro / interes.Presente - 1) / (interes.TasaInteres / 100);
        }

        // Interés Compuesto

        public decimal CalcularICValorFuturo(Interes interes)
        {
            // Fórmula: VF = VP * (1 + i)^n
            return interes.Presente * (decimal)Math.Pow((double)(1 + (interes.TasaInteres / 100)), (double)interes.Periodo);
        }

        public decimal CalcularICValorPresente(Interes interes)
        {
            // Fórmula: VP = VF / (1 + i)^n
            return interes.Futuro / (decimal)Math.Pow((double)(1 + (interes.TasaInteres / 100)), (double)interes.Periodo);
        }

        public decimal CalcularICInteres(Interes interes)
        {
            // Fórmula: I = VF - VP
            return CalcularICValorFuturo(interes) - interes.Presente;
        }

        public decimal CalcularICTPeriodo(Interes interes)
        {
            // Fórmula: n = log(VF / VP) / log(1 + i)
            return (decimal)(Math.Log((double)(interes.Futuro / interes.Presente)) / Math.Log((double)(1 + (interes.TasaInteres / 100))));
        }

        // Anualidades Vencidas y Anticipadas

        public decimal AnualidadVencidaVP(Anualidad anualidad)
        {
            // Fórmula: VP = R * [1 - (1 + i)^-n] / i
            // Tasa de interés periódica (mensual en este caso)
            decimal tasaInteresPeriodica = anualidad.TasaInteres / 100 / 12;

            // Verificar que no sea cero para evitar división por cero
            if (tasaInteresPeriodica == 0)
            {
                // Si la tasa es 0%, el valor presente es simplemente el monto multiplicado por el número de períodos
                return anualidad.Monto * anualidad.Periodos;
            }

            // Fórmula completa: VP = R * [1 - (1 + i)^-n] / i
            double tasaInteresDouble = (double)tasaInteresPeriodica;
            double factor = 1 - Math.Pow(1 + tasaInteresDouble, (double)-anualidad.Periodos);
            return anualidad.Monto * (decimal)(factor / tasaInteresDouble);
        }

        public decimal AnualidadVencidaVF(Anualidad anualidad)
        {
            // Fórmula: VF = R * [(1 + i)^n - 1] / i
            // Tasa de interés periódica (mensual en este caso)
            decimal tasaInteresPeriodica = anualidad.TasaInteres / 100 / 12;

            // Verificar que no sea cero para evitar división por cero
            if (tasaInteresPeriodica == 0)
            {
                // Si la tasa es 0%, el valor futuro es simplemente el monto multiplicado por el número de períodos
                return anualidad.Monto * anualidad.Periodos;
            }

            // Fórmula completa: VF = R * [(1 + i)^n - 1] / i
            double tasaInteresDouble = (double)tasaInteresPeriodica;
            double factor = Math.Pow(1 + tasaInteresDouble, (double)anualidad.Periodos) - 1;
            return anualidad.Monto * (decimal)(factor / tasaInteresDouble);
        }

        public decimal AnualidadAnticipadaVP(Anualidad anualidad)
        {
            // Fórmula: VP_antic = R * [1 - (1 + i)^-n] / i * (1 + i)
            return AnualidadVencidaVP(anualidad) * (1 + anualidad.TasaInteres / 100);
        }

        public decimal AnualidadAnticipadaVF(Anualidad anualidad)
        {
            // Fórmula: VF_antic = R * [(1 + i)^n - 1] / i * (1 + i)
            return AnualidadVencidaVF(anualidad) * (1 + anualidad.TasaInteres / 100);
        }

        public decimal AnualidadDiferidaVP(AnualidadDiferida anualidadDiferida)
        {
            // Fórmula: VP_diferido = R * [1 - (1 + i)^-n] / i / (1 + i)^d
            return AnualidadVencidaVP(anualidadDiferida) / (decimal)Math.Pow((double)(1 + anualidadDiferida.TasaInteres / 100), (double)anualidadDiferida.PeriodosDiferimiento);
        }

        public decimal AnualidadDiferidaVF(AnualidadDiferida anualidadDiferida)
        {
            // Fórmula: VF_diferido = R * [(1 + i)^n - 1] / i / (1 + i)^d
            return AnualidadVencidaVF(anualidadDiferida) / (decimal)Math.Pow((double)(1 + anualidadDiferida.TasaInteres / 100), (double)anualidadDiferida.PeriodosDiferimiento);
        }

        // Tasa Mínima Aceptable de Rendimiento (TMAR)

        public decimal CalcularTMAR(Tmar tmar)
        {
            // Fórmula: TMAR = i + f + (i * f)
            return tmar.TasaLibreDeRiesgo + tmar.PrimaDeRiesgo + (tmar.TasaLibreDeRiesgo * tmar.PrimaDeRiesgo);
        }

        // Tasa Interna de Retorno (TIR)

        public decimal CalcularTIR(Inversion inversion)
        {
            // Fórmula: Se usa el método de Newton-Raphson para resolver la ecuación NPV = 0
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

        // Valor Presente Neto (VPN)

        public decimal CalcularVPN(Inversion inversion)
        {
            // Fórmula: VPN = I_0 + Σ(CF_t / (1 + i)^t)
            return inversion.InversionInicial + inversion.FlujosDeCaja.Select((cashflow, t) => cashflow / (decimal)Math.Pow((double)(1 + inversion.TasaDescuento / 100), t + 1)).Sum();
        }

        // Generación de Calendario de Pagos de un Préstamo

        public List<Pago> GenerarCalendarioDePagos(Prestamo prestamo)
        {
            // Fórmulas:
            // 1. Pago Mensual: PMT = P * i_m / (1 - (1 + i_m)^-n)
            // 2. Interés: I_t = S_{t-1} * i_m
            // 3. Principal: Principal = PMT - I_t
            // 4. Saldo: S_t = S_{t-1} - Principal

            List<Pago> calendario = new List<Pago>();
            decimal tasaInteresMensual = prestamo.TasaInteresAnual / 12 / 100;
            decimal pagoMensual = prestamo.Monto * tasaInteresMensual / (1 - (decimal)Math.Pow((double)(1 + tasaInteresMensual), -prestamo.NumeroPeriodos));
            decimal saldo = prestamo.Monto;

            for (int i = 1; i <= prestamo.NumeroPeriodos; i++)
            {
                decimal interes = saldo * tasaInteresMensual;
                decimal principal = pagoMensual - interes;
                saldo -= principal;

                // Asegurarse de que el saldo final sea cero para el último periodo
                if (i == prestamo.NumeroPeriodos)
                {
                    principal += saldo; // Ajustar el principal para que el saldo sea cero
                    saldo = 0;
                }

                calendario.Add(new Pago { Periodo = i, Interes = interes, Principal = principal, Cuota = pagoMensual, Saldo = saldo });
            }

            return calendario;
        }
    }
}
