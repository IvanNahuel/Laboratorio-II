using System;
using System.Collections.Generic;
using System.Text;

namespace Central_Telefonica
{
    public enum Franja
    {
        franja_1,
        franja_2,
        franja_3
    }


    class Provincial : Llamada
    {
        protected Franja franjaHoraria;


    }
}
