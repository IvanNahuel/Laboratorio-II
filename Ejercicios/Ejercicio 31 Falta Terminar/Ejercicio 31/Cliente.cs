using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
  class Cliente
  {
    string nombre;
    int numero;

    public string Nombre
    {
      get
      {
        return nombre;
      }
      set
      {
        this.nombre = value;
      }
    }

    public int Numero
    {
      get
      {
        return numero;
      }
    }
    //constructor de CLIENTE tiene como constructor un entero llamado numero (int numero)
    //
    public Cliente(int numero)
    {
      this.numero = numero;
    }

    public Cliente(int numero, string nombre)
    {
      Nombre = nombre;
      this.numero = numero;
    }

    public static bool operator ==(Cliente c1, Cliente c2)
    {
      return c1 == c2;
    }

    public static bool operator !=(Cliente c1, Cliente c2)
    {
      return !(c1 == c2);
    }
  }
}
