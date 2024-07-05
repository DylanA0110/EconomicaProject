using Models.Models;
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
            return interes.Futuro - interes.Presente;
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
            // Tasa de interés periódica (mensual en este caso)
            decimal tasaInteresPeriodica = anualidad.TasaInteres / 100 / 12;

            // Verificar que no sea cero para evitar división por cero
            if (tasaInteresPeriodica == 0)
            {
                // Si la tasa es 0%, el valor presente es simplemente el monto multiplicado por el número de períodos
                return anualidad.Monto * anualidad.Periodos * (1 + tasaInteresPeriodica);
            }

            // Fórmula completa: VP_antic = R * [1 - (1 + i)^-n] / i * (1 + i)
            double tasaInteresDouble = (double)tasaInteresPeriodica;
            double factor = 1 - Math.Pow(1 + tasaInteresDouble, (double)-anualidad.Periodos);
            return anualidad.Monto * (decimal)(factor / tasaInteresDouble * (1 + tasaInteresDouble));
        }


        public decimal AnualidadAnticipadaVF(Anualidad anualidad)
        {
            // Fórmula: VF_antic = R * [(1 + i)^n - 1] / i * (1 + i)
            // Tasa de interés periódica (mensual en este caso)
            decimal tasaInteresPeriodica = anualidad.TasaInteres / 100 / 12;

            // Verificar que no sea cero para evitar división por cero
            if (tasaInteresPeriodica == 0)
            {
                // Si la tasa es 0%, el valor futuro es simplemente el monto multiplicado por el número de períodos
                return anualidad.Monto * anualidad.Periodos * (1 + tasaInteresPeriodica);
            }

            // Fórmula completa: VF_antic = R * [(1 + i)^n - 1] / i * (1 + i)
            double tasaInteresDouble = (double)tasaInteresPeriodica;
            double factor = Math.Pow(1 + tasaInteresDouble, (double)anualidad.Periodos) - 1;
            return anualidad.Monto * (decimal)(factor / tasaInteresDouble * (1 + tasaInteresDouble));
        }

        public decimal AnualidadDiferidaVP(AnualidadDiferida anualidadDiferida)
        {
            // Fórmula: VP_diferido = R * [1 - (1 + i)^-n] / i / (1 + i)^d
            // Tasa de interés periódica (mensual en este caso)
            decimal tasaInteresPeriodica = anualidadDiferida.TasaInteres / 100 / 12;

            // Verificar que no sea cero para evitar división por cero
            if (tasaInteresPeriodica == 0)
            {
                // Si la tasa es 0%, el valor presente es simplemente el monto multiplicado por el número de períodos
                return anualidadDiferida.Monto * anualidadDiferida.Periodos / (1 + anualidadDiferida.TasaInteres / 100 / 12);
            }

            // Fórmula completa: VP_diferido = R * [1 - (1 + i)^-n] / i / (1 + i)^d
            double tasaInteresDouble = (double)tasaInteresPeriodica;
            double factor = 1 - Math.Pow(1 + tasaInteresDouble, (double)-anualidadDiferida.Periodos);
            double descuento = Math.Pow(1 + tasaInteresDouble, (double)anualidadDiferida.PeriodosDiferimiento);
            return anualidadDiferida.Monto * (decimal)(factor / tasaInteresDouble / descuento);
        }


        public decimal AnualidadDiferidaVF(AnualidadDiferida anualidadDiferida)
        {
            // Fórmula: VF_diferido = R * [(1 + i)^n - 1] / i / (1 + i)^d
            // Tasa de interés periódica (mensual en este caso)
            decimal tasaInteresPeriodica = anualidadDiferida.TasaInteres / 100 / 12;

            // Verificar que no sea cero para evitar división por cero
            if (tasaInteresPeriodica == 0)
            {
                // Si la tasa es 0%, el valor futuro es simplemente el monto multiplicado por el número de períodos
                return anualidadDiferida.Monto * anualidadDiferida.Periodos / (1 + anualidadDiferida.TasaInteres / 100 / 12);
            }

            // Fórmula completa: VF_diferido = R * [(1 + i)^n - 1] / i / (1 + i)^d
            double tasaInteresDouble = (double)tasaInteresPeriodica;
            double factor = Math.Pow(1 + tasaInteresDouble, (double)anualidadDiferida.Periodos) - 1;
            double descuento = Math.Pow(1 + tasaInteresDouble, (double)anualidadDiferida.PeriodosDiferimiento);
            return anualidadDiferida.Monto * (decimal)(factor / tasaInteresDouble / descuento);
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
            if (inversion.FlujosDeCaja == null || inversion.FlujosDeCaja.Length == 0)
            {
                throw new ArgumentException("Debe proporcionar al menos un flujo de caja.");
            }

            decimal[] flujosDeCaja = inversion.FlujosDeCaja;
            decimal inversionInicial = inversion.InversionInicial;
            decimal tasaDescuento = inversion.TasaDescuento;

            decimal CalcularValorPresente(decimal tasa)
            {
                decimal resultado = -inversionInicial;
                for (int i = 0; i < flujosDeCaja.Length; i++)
                {
                    resultado += flujosDeCaja[i] / (decimal)Math.Pow((double)(1 + tasa), i + 1);
                }
                return resultado;
            }

            // Método de bisección para encontrar la TIR
            decimal tasaInferior = 0.0m;
            decimal tasaSuperior = 1.0m;
            decimal TIR = 0.0m;
            int maxIteraciones = 1000;
            decimal tolerancia = 0.0001m;

            for (int i = 0; i < maxIteraciones; i++)
            {
                TIR = (tasaInferior + tasaSuperior) / 2;
                decimal valorPresenteNeto = CalcularValorPresente(TIR);

                if (Math.Abs(valorPresenteNeto) < tolerancia)
                {
                    break;
                }
                else if (valorPresenteNeto > 0)
                {
                    tasaInferior = TIR;
                }
                else
                {
                    tasaSuperior = TIR;
                }
            }

            return TIR * 100;
        }


        // Valor Presente Neto (VPN)

        public decimal CalcularVPN(Inversion inversion)
        {
            if (inversion.FlujosDeCaja == null || inversion.FlujosDeCaja.Length == 0)
            {
                throw new ArgumentException("Debe proporcionar al menos un flujo de caja.");
            }

            decimal[] flujosDeCaja = inversion.FlujosDeCaja;
            decimal inversionInicial = inversion.InversionInicial;
            decimal tasaDescuento = inversion.TasaDescuento;

            decimal vpn = -inversionInicial;

            for (int i = 0; i < flujosDeCaja.Length; i++)
            {
                vpn += flujosDeCaja[i] / (decimal)Math.Pow((double)(1 + tasaDescuento), i + 1);
            }

            return vpn;
        }

        // Generación de Calendario de Pagos de un Préstamo

        public List<Pago> GenerarCalendarioDePagos(Prestamo prestamo)
        {
            List<Pago> calendario = new List<Pago>();
            decimal tasaInteresMensual = prestamo.TasaInteresAnual / 12 / 100;
            decimal pagoMensual = prestamo.Monto * tasaInteresMensual / (1 - (decimal)Math.Pow((double)(1 + tasaInteresMensual), -prestamo.NumeroPeriodos));
            decimal saldo = prestamo.Monto;

            // Agregar el período 0 con todos los valores en cero excepto el saldo original
            calendario.Add(new Pago { Periodo = 0, Interes = 0, Principal = 0, Cuota = 0, Saldo = prestamo.Monto });

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
