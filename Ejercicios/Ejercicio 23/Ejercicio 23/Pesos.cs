using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_23
{
    public class Pesos
    {
        double cantidad;
        static float cotizRespectoDolar = 38.33f;

        public static float operator +(Pesos p, Dolar d)
        {
            return (p + d) * cotizRespectoDolar;    //PERFECTO
        }

        public static float operator +(Pesos p, Euro e)
        {
            return (p + e) * cotizRespectoDolar;
            //EJEMPLO 1 EURO = 1,13 DOLARES
            //1 DOLAR = 0.88 EUROS
            //


        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return p.GetCantidad() == d.GetCantidad();
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return (!(p==d));
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return p.GetCantidad() == e.GetCantidad();
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return (!(p == e));
        }

        public static bool operator ==(Pesos p, Pesos x)
        {
            return p.GetCantidad() == x.GetCantidad();
        }

        public static bool operator !=(Pesos p, Pesos x)
        {
            return (!(p == x));
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
