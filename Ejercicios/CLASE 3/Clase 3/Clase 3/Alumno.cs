using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    class Alumno
    {
        byte nota1;
        byte nota2;
        int notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        public static string colegio;
        static Random rnd;

        public Alumno(string apellido, string nombre)
        {
            this.nombre = nombre;
            this.apellido = apellido;   //this hace referencia a la clase
        }
        static Alumno()
        {
            colegio = "UTN";
            rnd = new Random();
        }
        void CalcularFinal()
        {
            if (this.nota1 > 3 && this.nota2 > 3)
            {
                this.notaFinal = rnd.Next(1, 6);
            }
            else
                this.notaFinal = -1;
        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        public string Mostrar()
        {
            //CONDICION?VERDADERO: FALSE;
            return this.legajo.ToString() + " " + this.apellido + " " + this.nombre + " " + colegio + " " +
            (this.notaFinal == -1 ? "Desaprovado" : this.notaFinal.ToString());
        }
    }
}
