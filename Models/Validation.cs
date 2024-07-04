using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Validation
    {
        public static List<string> ValidarModelo(object usuario)
        {
            var resultadosValidacion = new List<ValidationResult>();
            var contexto = new ValidationContext(usuario, serviceProvider: null, items: null);
            var errores = new List<string>();

            if (!Validator.TryValidateObject(usuario, contexto, resultadosValidacion, validateAllProperties: true))
            {
                foreach (var resultado in resultadosValidacion)
                {
                    errores.Add(resultado.ErrorMessage);
                }
            }

            return errores;
        }
        }
    }
