﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Especificaciones
{
    public class RealizarCalculo
    {
        public Numero OperadorBinario (char elOperador, Numero elPrimerNumero, Numero elSegundoNumero)
        {
            Numero elResultado = null;
            switch (elOperador)
            {
                case '+': var accionSuma = new Acciones.Suma();
                    elResultado = accionSuma.Operar(elPrimerNumero, elSegundoNumero);
                    break;
            
                case '*': var accionMultiplicacion = new Acciones.Multiplicacion();
            elResultado = accionMultiplicacion.Operar(elPrimerNumero, elSegundoNumero);
            break;

                case '/':
                    var accionDivision = new Acciones.Division();
                    elResultado = accionDivision.Operar(elPrimerNumero, elSegundoNumero);
                    break;
            }
            return (elResultado);
        }
    }
}
