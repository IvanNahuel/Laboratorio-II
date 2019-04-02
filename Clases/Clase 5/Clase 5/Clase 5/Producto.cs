using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5
{

  public class Producto
  {
    string codigoDeBarra;
    string marca;
    float precio;

    public Producto(string CodBarra,string marca1, float precio1)
    {
      this.codigoDeBarra = CodBarra;
      this.marca = marca1;
      this.precio = precio1;
    }
    
    public static explicit operator string(Producto producto)  //Sobre carga de operadores explicitos, getter de sobre-Carga de  
    {                                                           //operadores y los comvierte a codigo de barra
      return producto.codigoDeBarra;
    }

    //producto - producto

    public static bool operator ==(Producto p1,Producto p2)
    {
      return p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra;
    }
    public static bool operator !=(Producto p1, Producto p2)
    {
      return !(p1 == p2);
    }
    //producto - cadena
    public static bool operator ==(Producto producto,string cadena)
    {
      return producto.marca == cadena;    //si son iguales retornara true, si no false
    }
    public static bool operator !=(Producto producto, string cadena)
    {
      return !(producto == cadena);       //si son distintos retornara true, si son iguales false
    }
    public string GetMarca()
    {
      return marca;
    }
    public float GetPrecio()
    {
      return precio;
    }
    public string GetCodBarra()
    {
      return codigoDeBarra;
    }
    public static string MostrarProducto(Producto productos)
    {
      string retorno;

      retorno = productos.codigoDeBarra + productos.marca + productos.precio.ToString();

      return retorno;
    }
  }
}
