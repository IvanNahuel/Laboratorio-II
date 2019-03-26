using System;

namespace Ejercicio_14
{
    public class Program
    {
        static void Main(string[] args)
        {
            double lado1Cuadrado;
            double AreaCuadrado;

            double lado1Triangulo;
            double lado2Triangulo;
            double areaTriangulo;

            double DiametroCirculo;
            double areaCirculo;
        
            
            Console.WriteLine("Ingrese el lado 1 del cuadrado");
            lado1Cuadrado = int.Parse(Console.ReadLine());
            AreaCuadrado = CalculoDeArea.CalcularCuadrado(lado1Cuadrado);
            Console.WriteLine("el area del cuadrado es : "+AreaCuadrado);
            
            Console.WriteLine("Ingrese el lado 1 del triangulo Rectandulo: ");
            lado1Triangulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 2 del triangulo Rectandulo: ");
            lado2Triangulo = int.Parse(Console.ReadLine());
            areaTriangulo = CalculoDeArea.CalcularAreaTriangulo(lado1Triangulo, lado2Triangulo);
            Console.WriteLine("el area del triangulo rectangulo es : " + areaTriangulo+"CM²");
            
            Console.WriteLine("Ingrese el diametro del circulo: ");
            DiametroCirculo = int.Parse(Console.ReadLine());

            areaCirculo = CalculoDeArea.CalcularAreaCirculo(DiametroCirculo);
            Console.WriteLine("el diametro de un cirulo es: "+areaCirculo);

            Console.ReadKey();
        }
    }
}
