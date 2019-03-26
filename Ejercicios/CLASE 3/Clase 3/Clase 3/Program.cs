using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio 16


            Alumno alumnoUno = new Alumno("Oggioni","Ezequiel");
            Alumno alumnoDos = new Alumno("Dillon", "Horacio");
            Alumno alumnoTres = new Alumno("Davila", "Federico");

            alumnoUno.Estudiar(10, 10);
            alumnoDos.Estudiar(7, 8);
            alumnoTres.Estudiar(6, 7);

            Console.WriteLine(alumnoUno.Mostrar());
            Console.WriteLine(alumnoDos.Mostrar());
            Console.WriteLine(alumnoTres.Mostrar());


            Console.ReadKey();
        }
    }
}
