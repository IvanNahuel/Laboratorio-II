using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
  class Program
  {
    static void Main(string[] args)
    {
      int dia, mes, anio, d, m, a;
      bool pasar = true;
      int contadorDiaBiciesto = 0;
      int diasVividos = 0;

      Console.Write("Ingrese dia: ");
      int.TryParse(Console.ReadLine(), out dia);
      Console.Write("Ingrese mes: ");
      int.TryParse(Console.ReadLine(), out mes);
      Console.Write("Ingrese año: ");
      int.TryParse(Console.ReadLine(), out anio);

      for (int i = anio; i < DateTime.Now.Year; i++)
      {
        if (i % 4 == 0)       //si la posicion actual es divisible por 4 
        {
          if (i % 100 == 0 && i % 400 == 0)       //si la posicion actual es divisible por 100 y ademas por 400
          {
            contadorDiaBiciesto++;
            pasar = false;
          }
          if (pasar)
          {
            contadorDiaBiciesto++;
          }
        }
        pasar = true;
      }
      a = DateTime.Now.Year - anio;
      m = DateTime.Now.Month - mes;
      d = DateTime.Now.Day - dia + contadorDiaBiciesto;
      
      if (m < 0)
      {
        a--;
        m += 12;
      }

      //son dias vividos, entonces se deben sumar todos los años por los 365 dias del año y sumar los dias biciestos

      diasVividos = (a * 365) + contadorDiaBiciesto;
      Console.WriteLine("La cantidad de dias vividos es :"+diasVividos);
      //me faltan sumar los meses y los dias actuales

      /*
      Console.WriteLine("Su edad es: " + a + " años, " + m + " meses, " + d + " días");
      */
      Console.ReadKey();
      
    }
  }
}
