using System;

namespace Virtual_Herencia
{
  class Program
  {
    static void Main(string[] args)
    {

      Aliado aliado1 = new Aliado(200, "Soldado1", 50, 2, 0);
      Enemigo enemigo1 = new Enemigo(100, "SoldadoEnemigo", 20, 2, 1);

      Personaje personaje;

      personaje = aliado1 + enemigo1;

      Console.WriteLine(personaje.MostrarPersonaje(personaje));

      Console.ReadKey();
    }
  }
}
