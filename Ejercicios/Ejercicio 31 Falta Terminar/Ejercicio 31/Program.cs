using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_31
{
  static class Program
  {
        /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());

      //el cliente tiene un numero y un nombre
      //el numero indica su turno, es decir
      //hay una cola de clientes, si los numeros y numero actual coinciden, significa que
      //deberia atender al cliente con ese numero
      //


    }
  }
}
