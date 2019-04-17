using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{

  public enum Puesto
  {
    caja1,
    caja2
  }

  class PuestoAtencion
  {
    static int numeroActual;
    Puesto puesto;

    public int NumeroActual
    {
      get
      {
        return numeroActual++;
      }
    }
    public bool Atender(Cliente cli)
    {
      if (cli != null)
      {
        System.Threading.Thread.Sleep(1000);
        return true;
      }

      return false;
    }
    public PuestoAtencion(Puesto puesto)
    {
      this.puesto = puesto;
    }

    public PuestoAtencion()
    {
      PuestoAtencion.numeroActual = 0;
    }
  }
}
