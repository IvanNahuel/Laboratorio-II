using System;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros;
            int acomulador = 0;
            string respuesta;


            do
            {
                Console.WriteLine("Desea ingresar un numero ? S/N");
                respuesta = Console.ReadLine();
                if (ValidarRespuesta.ValidaS_N(respuesta) == false)
                {
                    break;
                }
                Console.WriteLine("Ingrese el numero:");
                numeros = int.Parse(Console.ReadLine());

                acomulador += numeros;

            } while (ValidarRespuesta.ValidaS_N(respuesta) == true);

            Console.WriteLine("El numero acomulado es: "+acomulador);

            Console.ReadKey();
        }
    }
}
