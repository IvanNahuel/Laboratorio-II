using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_23
{
    /*
    e.Los constructores estáticos le darán una cotización respecto del dólar por defecto a las
clases.*/
    public class Euro
    {
        static Euro()
        {
            cotizRespectoDolar = 1.13f;
        }
        double cantidad;
        static float cotizRespectoDolar;

        public static float operator +(Euro e, Dolar d)
        {
            return (d + e) * cotizRespectoDolar;
        }

        public static float operator +(Euro e, Pesos p)
        {
            return (e + p) * Pesos.GetCotizacion();
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return e.GetCantidad() == d.GetCantidad();
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return (!(e == d));
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            return p.GetCantidad() == e.GetCantidad();
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return (!(e == p));
        }

        public static bool operator ==(Euro e, Euro x)
        {
            return x.GetCantidad() == e.GetCantidad();
        }

        public static bool operator !=(Euro e, Euro x)
        {
            return (!(e == x));
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

    }
}



