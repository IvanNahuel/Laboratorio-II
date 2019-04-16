using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
  class Negocio
  {
    PuestoAtencion caja;
    Queue<Cliente> clientes;
    string nombre;

    public Cliente Clientes
    {
      get
      {
        return clientes.Dequeue();
      }
      set
      {
        bool var = this + value;
      }
    }
    private Negocio()
    {
      this.clientes = new Queue<Cliente>();
      this.caja = new PuestoAtencion(Puesto.caja1);
    }

    public static bool operator +(Negocio n, Cliente c)
    {
      if (n != c)
      {
        n.clientes.Enqueue(c);    //el cliente recibido por parametro añadimelo a la cola
        return true;              //corta la operacion y retorname true
      }
      return false;
    }
    public static bool operator ==(Negocio n, Cliente c)
    {
      //recorrer la lista y comparar si son iguales 
      foreach (Cliente AlgunCliente in n.clientes)
      {
        if (AlgunCliente == c)
        {
          return true;
        }
      }
      return false;
    }
    public static bool operator !=(Negocio n, Cliente c)
    {
      return (!(n == c));
    }
  }
}
