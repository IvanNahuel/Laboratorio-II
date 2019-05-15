using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Herencia
{
  class Enemigo : Personaje
  {
    int id;

    public Enemigo(int vida, string nombre, int daño, int ataque,int id) : base(vida, nombre, daño, ataque)
    {
      this.id = id;
    }

    public override string Personajes()
    {
      return this.nombre;
    }

    public override string Nombre
    {
      get
      {
        return this.nombre;
      }
    }

    public override int Vida
    {
      get
      {
        return this.vida;
      }
    }

    public override int Daño
    {
      get
      {
        return this.daño;
      }
    }
  }
}
