using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP
{
  class EmisorDeEmails : Emisor
  {
    string email;
    bool enviado;

    public EmisorDeEmails (string mensaje, EProducto producto,string email) : base(mensaje, producto)
    {
      this.email = email;
      enviado = false;
    }
    /* POBLEMAS CON OPERADORES EXPLICITOS :c
    public static operator explicit (EmisorDeEmails emisor)
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(emisor.email);

      return sb.ToString();
    }
    */
    public string EnviarMensaje()
    {
      enviado = true;

    }




  }
}
