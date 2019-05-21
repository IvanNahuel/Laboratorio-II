using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartas
{
    public class Carta
    {
        private int numero;
        
        private string tipo;

        public Carta (int numero, string tipo)
        {
            this.Numero = numero;
            this.Tipo = tipo;
        }
        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }
        public string Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
    }
}
