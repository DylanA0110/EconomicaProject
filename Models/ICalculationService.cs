using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface ICalculationService
    {
        decimal CalcularISValorFuturo(decimal presente, decimal Tasainteres);
        decimal CalcularISValorPresente(decimal futuro, decimal tasaInteres);
        decimal CalcularISInteres(decimal presente, decimal  tasaInteres, decimal periodo);
        decimal CalcularISTPeriodo(decimal futuro, decimal presente, decimal Tasainteres);
        decimal calcularICValorFuturo(decimal tasaInteres, decimal presente, decimal periodo);
        decimal CalcularICValorPresente(decimal futuro, decimal tasaInteres, decimal periodo);
        decimal CalcularICInteres(decimal perodo, decimal futuro, decimal presente);
        decimal CalcularICTPeriodo(decimal futuro, decimal presente, decimal interes);
        decimal AnualidadVencidaVP(decimal R, decimal tasaInteres, decimal n);
        decimal AnualidadVencidaVF(decimal R, decimal tasaInteres, decimal n);
        decimal AnualidadAnticipadaVP(decimal R, decimal tasaInteres, decimal n);
        decimal AnualidadAnticipadaVF(decimal R, decimal tasaInteres, decimal n);
        decimal AnualidadDiferidaVP(decimal R, decimal tasaInteres, decimal n, decimal m);
        decimal AnualidadDiferidaVF(decimal R, decimal tasaInteres, decimal n, decimal m);
        decimal CalcularTMAR(decimal tasaLibreDeRiesgo, decimal primaDeRiesgo);
        decimal CalcularTIR(decimal inversionInicial, decimal[] flujosDeCaja);
        decimal CalcularVPN(decimal inversionInicial, decimal[] flujosDeCaja, decimal tasaDescuento);
        List<Pago> GenerarCalendarioDePagos(decimal montoPrestamo, decimal tasaInteresAnual, int numeroPeriodos);
    }
}
