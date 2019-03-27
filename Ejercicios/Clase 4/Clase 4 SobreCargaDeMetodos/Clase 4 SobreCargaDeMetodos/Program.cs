using System;

namespace Clase_4_SobreCargaDeMetodos
{
  class Program
  {
    static void Main(string[] args)
    {
      long a;


      //Ejercicio 19
      Sumador sumador = new Sumador();
      //Sumador sumador = new Sumador(1);  //usaremos el constructor que pide como argumento solo un entero

      //Console.WriteLine(sumador.cantidadDeSumas);

      Console.WriteLine(Sumador.sumar(10,10));
      Console.WriteLine(Sumador.sumar("Hola ","Mundo"));





      Console.ReadKey();
    }
  }
}
