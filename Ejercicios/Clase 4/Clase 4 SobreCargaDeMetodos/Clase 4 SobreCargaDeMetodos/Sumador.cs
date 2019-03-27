using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_4_SobreCargaDeMetodos
{
    class Sumador
    {
    public int cantidadDeSumas;

    public Sumador()
    {
      cantidadDeSumas = 0;
    }
    public Sumador(int cantidadSumas)
    {
        cantidadDeSumas = cantidadSumas;
    }
    public static long sumar(long a, long b)
    {
      return a + b;
    }
    public static string sumar(string a,string b){
      return a + b;
    }
    



  }
}
