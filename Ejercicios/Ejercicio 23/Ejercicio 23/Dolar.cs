using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_23
{
    public class Dolar
    {
        static Dolar()
        {
            cotizRespectoDolar = 1f;
        }

        double cantidad;
        static float cotizRespectoDolar;

       public static float operator+(Dolar d,Pesos p)
        {
            return (d + p) * Pesos.GetCotizacion();
        }

        public static float operator +(Dolar d, Euro e)
        {
            return (d + e) * Euro.GetCotizacion();
        }

        public static bool operator ==(Dolar d,Euro e)
        {
            return d.GetCantidad() == e.GetCantidad();
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return (!(d==e));
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            return d.GetCantidad() == p.GetCantidad();
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return (!(d == p));
        }

        public static bool operator ==(Dolar d, Dolar x)
        {
            return d.GetCantidad() == x.GetCantidad();
        }

        public static bool operator !=(Dolar d, Dolar x)
        {
            return (!(d == x));
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
