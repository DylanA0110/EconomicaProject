using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CalculationService : ICalculationService
    {
        public decimal AnualidadAnticipadaVF(decimal R, decimal tasaInteres, decimal n)
        {
            throw new NotImplementedException();
        }

        public decimal AnualidadAnticipadaVP(decimal R, decimal tasaInteres, decimal n)
        {
            throw new NotImplementedException();
        }

        public decimal AnualidadDiferidaVF(decimal R, decimal tasaInteres, decimal n, decimal m)
        {
            throw new NotImplementedException();
        }

        public decimal AnualidadDiferidaVP(decimal R, decimal tasaInteres, decimal n, decimal m)
        {
            throw new NotImplementedException();
        }

        public decimal AnualidadVencidaVF(decimal R, decimal tasaInteres, decimal n)
        {
            throw new NotImplementedException();
        }

        public decimal AnualidadVencidaVP(decimal R, decimal tasaInteres, decimal n)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularICInteres(decimal perodo, decimal futuro, decimal presente)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularICTPeriodo(decimal futuro, decimal presente, decimal interes)
        {
            throw new NotImplementedException();
        }

        public decimal calcularICValorFuturo(decimal tasaInteres, decimal presente, decimal periodo)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularICValorPresente(decimal futuro, decimal tasaInteres, decimal periodo)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularISInteres(decimal presente, decimal tasaInteres, decimal periodo)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularISTPeriodo(decimal futuro, decimal presente, decimal Tasainteres)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularISValorFuturo(decimal presente, decimal Tasainteres)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularISValorPresente(decimal futuro, decimal tasaInteres)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularTIR(decimal inversionInicial, decimal[] flujosDeCaja)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularTMAR(decimal tasaLibreDeRiesgo, decimal primaDeRiesgo)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularVPN(decimal inversionInicial, decimal[] flujosDeCaja, decimal tasaDescuento)
        {
            throw new NotImplementedException();
        }

        public List<Pago> GenerarCalendarioDePagos(decimal montoPrestamo, decimal tasaInteresAnual, int numeroPeriodos)
        {
            throw new NotImplementedException();
        }
    }
}
