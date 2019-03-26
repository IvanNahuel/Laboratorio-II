using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_12 {
    class ValidarRespuesta{

        public static bool ValidaS_N(string opciones)
        {
            bool retorno = false;

            if (opciones=="S" || opciones == "s")
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
