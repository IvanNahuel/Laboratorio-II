using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
  class Program
  {
    static void Main(string[] args)
    {
      int acum = 0;
      int contador = 0;
      int i = 6;

      do
      {
        for (int j = 1; j < i; j++)
        {
          if (i % j == 0)
          {
            acum += j;
          }
        }
        if (acum == i)            //si la suma de las acomulaciones es igual a acum 
        {
          Console.WriteLine(i);
          contador++;
        }
        if (contador == 4)
        {
          break;
        }
        acum = 0;
        i++;
      }
      while (contador != 4);
 
     // Console.WriteLine("Termino");
      Console.ReadKey();   
    }
  }
}
