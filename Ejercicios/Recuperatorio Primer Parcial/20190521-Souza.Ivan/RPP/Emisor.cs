using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP
{
  public enum EProducto
  {
    SQLDataBase,
    MonitorinApp,
    AppHosting
  }

  public abstract class Emisor
  {
    string mensaje;
    EProducto producto;

    protected Emisor(string mensaje, EProducto producto)
    {
      this.mensaje = mensaje;
      this.producto = producto;
    }
    
    public abstract string EnviarMensaje();

    public static bool operator ==(Emisor emisor,Emisor emisorDos)
    {
      return emisor.mensaje == emisorDos.mensaje && emisor.producto == emisorDos.producto ;
    }
    public static bool operator !=(Emisor emisor, Emisor emisorDos)
    {
      return !(emisor == emisorDos);
    }
    /* //PENDIENTE NO SE USAR EK STRING FORMAT :c
    public string ToString()
    {
      return string.Format("\n.{producto} \n.{mensaje}")
    }*/
    

  }
}
