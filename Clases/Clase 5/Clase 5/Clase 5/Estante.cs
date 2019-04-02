using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5
{
  public class Estante
  {
    /*4) El constructor de instancia privado será el único que inicializará el array. La sobrecarga pública del constructor
     * inicializará la ubicación del estante, recibiendo como parámetro capacidad y ubicación. Reutilizar código. */

    Producto[] productos;
    int estanteriaUbicacion;

    private Estante(int capacidad)
    {
      this.productos = new Producto[capacidad];
    }

    public Estante(int capacidad, int ubicacion) : this(capacidad)   //cuando se llama a este construcctor, se llama al private
    {                                                             //consctructor, y se inicializa el array :this(capacidad)
      this.estanteriaUbicacion = ubicacion;
    }
    public Producto[] GetProducto()
    {
      return this.productos;
    }
    public static string MostrarEstante(Estante e)
    {
      string salida = e.estanteriaUbicacion.ToString();

      foreach (Producto producto in e.productos)
      {
        if (!(producto is null))
          salida += Producto.MostrarProducto(producto);
      }
      /*
      for (int i = 0; i < e.productos.Length; i++)
      {
        Producto producto = e.productos[i];
      }*/
      return salida;
    }

    public static bool operator ==(Estante e, Producto p)
    {
      foreach (Producto producto in e.productos)
      {
        if (producto == p)
          return true;
      }
      return false;
    }
    public static bool operator !=(Estante e, Producto p)
    {
      return !(e == p);
    }
    public static bool operator +(Estante e, Producto p)
    {

      if (e != p)
      {
        for (int i = 0; i < e.productos.Length; i++)
        {
          if (e.productos[i] is null)   //recorrer hasta buscar un lugar libre
          {
            e.productos[i] = p;   //añade
            return true;
          }
        }
      }
      return false;
    }

    public static Estante operator -(Estante e, Producto p)
    {
      for (int i = 0; i < e.productos.Length; i++)
      {
        if (e.productos[i] == p)  //si es igual 
        {
          e.productos[i] = null;  //lo libera
          break;                  //y sale del for
        }
      }
      return e;
    }






  }
}
