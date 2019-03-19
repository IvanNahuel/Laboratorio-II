using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto2
{
    class Program
    {
        static int A = 2;
        static int B = 2;
        static int Respuesta;

        static string lectura;
        static int miValor; 

        static void Main(string[] args)
        {
            System.Console.WriteLine("ingrese Valor de A");
            int.TryParse(Console.ReadLine(), out A);        //en el primer argumento pido el primer dato y lo guardo en A
            System.Console.WriteLine("ingrese Valor de B");
            int.TryParse(Console.ReadLine(), out B);        //en el primer argumento pido el primer dato y lo guardo en B

            System.Console.WriteLine("Ingrese opcion");
            System.Console.WriteLine("1-Sumar A+B");
            System.Console.WriteLine("2-Restar A-B");

            lectura = Console.ReadLine();
            int.TryParse(lectura, out miValor);

            Selector(miValor);

            Console.ReadKey();
        }

        static void Selector(int valor)
        {
            switch (valor)
            {
                case 1:
                    //System.Console.WriteLine(A+B);
                    Respuesta = A + B;
                    break;
                case 2:
                    //System.Console.WriteLine(A-B);
                    Respuesta = A - B;
                    break;
            }
            System.Console.WriteLine("Su resultado es ");
            System.Console.WriteLine(Respuesta);
        }
    }
}