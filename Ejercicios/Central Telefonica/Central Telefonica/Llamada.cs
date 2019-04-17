using System;
using System.Collections.Generic;
using System.Text;

namespace Central_Telefonica
{
    class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public enum TipoLlamada
        {
            local,
            provincial,
            todas
        }

        public float Duracion
        {
            get
            {
                return duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return nroDestino;
            }
        }
        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1 !=null && llamada2 != null)
            {
                //ordenamos por duracion de forma ascendente, de mayor a menor
                



            }
        }
        public string mostrar()
        {
        return StringBuilder sb = (Duracion.ToString(), NroDestino, NroOrigen);
        }




    }
}
