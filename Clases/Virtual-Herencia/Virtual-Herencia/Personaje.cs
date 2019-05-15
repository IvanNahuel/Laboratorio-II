using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Herencia
{
  abstract class Personaje
  {
    internal int vida;
    internal string nombre;
    internal int daño;
    int ataque;

    public Personaje(int vida, string nombre, int daño, int ataque)
    {
      this.vida = vida;
      this.nombre = nombre;
      this.daño = daño;
      this.ataque = ataque;
    }
    public virtual string Personajes()
    {
      return this.nombre;
    }
    public static Personaje operator +(Personaje x, Personaje y)
    {
      //retornara el personaje ganador ya sea aliado o enemigo
      int auxVida;
      int auxDaño;

      Personaje auxPersonaje;

      auxVida = x - y;
      auxDaño = x.daño - y.daño;

      if (x.vida > y.vida)
      {
        auxPersonaje = x;
        auxPersonaje.vida = auxVida;
        auxPersonaje.daño = auxDaño;
      }
      else
      {
        auxPersonaje = y;
        auxPersonaje.vida = auxVida;
        auxPersonaje.daño = auxDaño;
      }
      return auxPersonaje;
    }

    public static int operator -(Personaje x, Personaje y)
    {
      if (x.Vida < y.Vida)
        return (x.vida - y.vida) * -1;
      else
        return x.vida - y.vida;
    }

    public virtual string Nombre
    {
      get
      {
        return this.nombre;
      }
    }

    public virtual int Vida
    {
      get
      {
        return this.vida;
      }

    }

    public virtual int Daño
    {
      get
      {
        return this.daño;
      }
    }

    public string MostrarPersonaje(Personaje x)
    {
      StringBuilder aux = new StringBuilder();
      aux.Append("Nombre: " + x.Nombre.ToString() + "\n");
      aux.Append("Vida: " + x.Vida.ToString() + "\n");
      aux.Append("Daño: " + x.Daño.ToString() + "\n");

      return aux.ToString();
    }
  }
}
