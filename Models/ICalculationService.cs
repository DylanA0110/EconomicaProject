using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface ICalculationService
    {
        decimal CalcularISValorFuturo(Interes interes);
        decimal CalcularISValorPresente(Interes interes);
        decimal CalcularISInteres(Interes interes);
        decimal CalcularISTPeriodo(Interes interes);
        decimal CalcularICValorFuturo(Interes interes);
        decimal CalcularICValorPresente(Interes interes);
        decimal CalcularICInteres(Interes interes);
        decimal CalcularICTPeriodo(Interes interes);
        decimal AnualidadVencidaVP(Anualidad anualidad);
        decimal AnualidadVencidaVF(Anualidad anualidad);
        decimal AnualidadAnticipadaVP(Anualidad anualidad);
        decimal AnualidadAnticipadaVF(Anualidad anualidad);
        decimal AnualidadDiferidaVP(AnualidadDiferida anualidadDiferida);
        decimal AnualidadDiferidaVF(AnualidadDiferida anualidadDiferida);
        decimal CalcularTMAR(Tmar tmar);
        decimal CalcularTIR(Inversion inversion);
        decimal CalcularVPN(Inversion inversion);
        List<Pago> GenerarCalendarioDePagos(Prestamo prestamo);
    }
}
