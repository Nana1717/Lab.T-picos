using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Acciones
{
    class Multiplicacion
    {
        public Numero Operar(Numero elPrimerNumero, Numero elSegundoNumero)
        {
            Numero resultado = null;
            var validarBases = new Validaciones.ValidarBase();
            if (validarBases.LasDosBasesSonIguales(elPrimerNumero, elSegundoNumero))
            {
                object elResultadoNumerico = (elPrimerNumero.elNumeroEnDecimal * elSegundoNumero.elNumeroEnDecimal);
                //Esta operación debe de realizarse con los números en base 10
                resultado = new Numero(elResultadoNumerico.ToString(), elPrimerNumero.laBase);
            }
            return (resultado);

        }
    }
}
