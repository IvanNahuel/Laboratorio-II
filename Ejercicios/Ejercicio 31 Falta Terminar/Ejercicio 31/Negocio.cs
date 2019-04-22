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
    public Queue<Cliente> clientes;
    string nombre;      //nombre del negocio

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
    public int ClientesPendientes
    {
      get
      {
        return clientes.Count;      //contador de clientes que esperan ser atendidos
      }
    }
    public Negocio()
    {
      this.clientes = new Queue<Cliente>();
      this.caja = new PuestoAtencion(Puesto.caja1);
    }

        //tengo que usar esta sobracarga de operador para añadir un cliente a la lista
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

    public static bool operator ~(Negocio n)
    {
      Cliente cliente = n.Clientes;   //al utilizar el get, estoy accediendo a la propiedad y retorna el cliente des-encolado
      return n.caja.Atender(cliente); //le pasa el cliente des-encolado, que lo hicimos a travez del GET, retornara TRUE si se
                                                                                                        //realiza la operacion
    }
  }
}
