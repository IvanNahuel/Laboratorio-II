using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
  public class Personas
  {
    string nombre;
    string apellido;
    string dni;
    string numeroTarjeta;

    public static bool operator +(List<Personas> lp, Personas p)
    {
      lp.Add(p);
      return true;
    }
    public string Nombre
    {
      get
      {
        return this.nombre;
      }
      set
      {
        this.nombre = value;
      }
    }
    public string Apellido
    {
      get
      {
        return this.apellido;
      }
      set
      {
        this.apellido = value;
      }
    }
    public string Dni
    {
      get
      {
        return this.dni;
      }
      set
      {
        this.dni = value;
      }
    }

    //metodos de mostrar tarjeta y setear tarjeta


  }
}
