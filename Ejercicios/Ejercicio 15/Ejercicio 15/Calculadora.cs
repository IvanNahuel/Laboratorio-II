using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_15
{
    class Calculadora
    {
        public static float Calcular(float numero1, float numero2, string operacion)
        {
            float retorno = 0;
            //hacer el caculo aca y dependiendo de el simbolo hacer un if comparando los operadores aritmeticos
            if (operacion == "+")
            {
                retorno = numero1 + numero2;
            }
            else if (operacion == "-")
            {
                retorno = numero1 - numero2;
            }
            else if (operacion == "*")
            {
                retorno = numero1 * numero2;
            }
            else if (operacion == "/" && validar(numero2))
            {
                retorno = numero1 / numero2;
            }

            return retorno;
        }
        static bool validar(float numero)
        {
            bool retorno = false;
            if (numero != 0)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
