using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartas
{
    class Program
    {
        static void Main(string[] args)
        {
            Carta carta1 = new Carta(5, "Palo");
            Carta carta2 = new Carta(6, "Espada");
            Carta carta3 = new Carta(8, "Oro");
            Carta carta4 = new Carta(1, "Espada");
            Carta carta5 = new Carta(1, "Oro");
            Carta carta6 = new Carta(4, "Palo");
            Carta carta7 = new Carta(10, "Oro");
            Carta carta8 = new Carta(12, "Espada");
            Carta carta9 = new Carta(4, "Palo");
            Carta carta10 = new Carta(7, "Espada");

            Baraja<Carta> baraja = new Baraja<Carta>();

            Carta aux;
            baraja.AñadirCarta(carta1);
            baraja.AñadirCarta(carta2);
            baraja.AñadirCarta(carta3);
            baraja.AñadirCarta(carta4);
            baraja.AñadirCarta(carta5);
            baraja.AñadirCarta(carta6);
            baraja.AñadirCarta(carta7);
            baraja.AñadirCarta(carta8);
            baraja.AñadirCarta(carta9);
            baraja.AñadirCarta(carta10);

            aux = baraja.PedirCarta();

            Console.WriteLine(aux.Numero.ToString()+" "+aux.Tipo.ToString());
            Console.ReadKey();
        }
    }
}
