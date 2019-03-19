using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
  class Program
  {
    static int numero;


    static void Main(string[] args)
    {

      System.Console.WriteLine("ingrese un numero");
      int.TryParse(Console.ReadLine(), out numero);

      if (numero > 0)
      {
        System.Console.WriteLine (Math.Pow(numero,numero));
      }
      else
      {
        System.Console.WriteLine("ERROR. ¡Reingresar número!");
      }


      Console.ReadKey();

    }
  }
}
