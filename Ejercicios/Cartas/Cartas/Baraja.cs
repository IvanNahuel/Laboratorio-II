using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartas
{
    //pedir carta y que vaya quitando cartas de la lista de cartas
    public class Baraja<T> where T: class
    {      
        List<T> cartas = new List<T>();
        T retorno;

        public T PedirCarta()   //retornaria la clase que tendria en su lista
        {
            Random rnd = new Random();

            retorno = this.cartas.ElementAt(rnd.Next(1, this.cartas.Count));

            return retorno;
        }
        public void AñadirCarta(T cartita)  //añadiria la clase que le pases por parametro
        {
            this.cartas.Add(cartita);
        }
    }
}
