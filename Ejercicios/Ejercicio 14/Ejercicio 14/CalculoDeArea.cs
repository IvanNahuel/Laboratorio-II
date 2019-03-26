using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_14
{
    public class CalculoDeArea
    {/*
        14. Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase(estáticos) que realicen el
        cálculo del área que corresponda:
        a. double CalcularCuadrado(double)
        b. double CalcularTriangulo(double, double)
        c. double CalcularCirculo(double)
        El ingreso de los datos como la visualización se deberán realizar desde el método Main() */

        public static double CalcularCuadrado(double lado1)
        {
            double l1;

            l1 = ElevadoAlCuadrado(lado1);

            return l1;
        }
        private static double ElevadoAlCuadrado(double elevacion)
        {
            double acomulador = 0;

            acomulador = elevacion * elevacion;
            return acomulador;
        }

        public static double CalcularAreaTriangulo(double lado1, double lado2)
        {
            double retorno = 0;

            retorno = (lado1 * lado2) / 2;

            return retorno;
        }
        public static double CalcularAreaCirculo(double diametro)
        {
            double retorno = 0;

            retorno = (diametro * diametro) * 0.7854;

            return retorno;
        }





    }
}
