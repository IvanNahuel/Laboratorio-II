using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Persona> personas = new Queue<Persona>();
            personas.Enqueue(new Persona { edad = 1, nombre = "Pepe" });
            personas.Enqueue(new Persona { edad = 10, nombre = "carlos" });
            personas.Enqueue(new Persona { edad = 11, nombre = "Fede" });
            personas.Enqueue(new Persona { edad = 4, nombre = "Damian" });

            foreach (Persona personitas in personas)
            {
                Console.WriteLine(personitas.nombre);
            }

            Console.WriteLine("Siguiente.......");

            System.Threading.Thread.Sleep(3000);

            personas.Dequeue();

            foreach (Persona personitas in personas)
            {
                Console.WriteLine(personitas.nombre);
            }

            Console.ReadKey();
        }

        public class Persona
        {
            public int edad;

            public string nombre;
        }

        public void MostrarPersonas(Persona p)
        {

        }



    }
}
