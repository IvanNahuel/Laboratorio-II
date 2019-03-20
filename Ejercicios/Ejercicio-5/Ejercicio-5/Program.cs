using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
  class Program
  {
    static void Main(string[] args)
    {
      int añoInicio;
      int añoFin;
      bool pasar = true;

      System.Console.WriteLine("Ingrese año de inicio");
      int.TryParse(Console.ReadLine(), out añoInicio);
      System.Console.WriteLine("Ingrese año de fin");
      int.TryParse(Console.ReadLine(), out añoFin);

      if (añoInicio < añoFin)
      {
        for (int i = añoInicio; i < añoFin; i++)
        {
          if (i % 4 == 0)       //si la posicion actual es divisible por 4 
          {
            if (i % 100 == 0 && i % 400 == 0)       //si la posicion actual es divisible por 100 y ademas por 400
            {
              System.Console.WriteLine("es año biciesto el: " + i);   
              pasar = false;
            }
            if (pasar)      
            {
              System.Console.WriteLine("es año biciesto el: " + i);
            }
          }
          pasar = true;
        }
      }
      else
      {
        System.Console.WriteLine("Error el año inicio no deberia ser mayor a el año de fin");
      }

      Console.ReadKey();
    }
  }
}
