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

            //Cliente cliente1 = new Cliente(0, "Juan");
            Negocio negocio = new Negocio();    //inicializamos el negocio
                                                //ahora dentro de negocio necesitamos añadir clientes
            Cliente clienteAux = new Cliente(1, "Juan");

            bool v = negocio + clienteAux;   //quiro añadir a la cola 

            Console.WriteLine(negocio.Clientes.Nombre);





        }
    }
}
