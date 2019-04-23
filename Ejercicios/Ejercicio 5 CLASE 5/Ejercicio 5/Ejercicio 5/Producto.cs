using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_5
{
    class Producto
    {
        string codigoDeBarras;
        string marca;
        float precio;

        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public Producto(string marca, string codigo, float precio)
        {
            this.codigoDeBarras = codigo;
            this.marca = marca;
            this.precio = precio;
        }
        public static string MostrarProducto(Producto p)
        {
            return p.codigoDeBarras + p.marca + p.precio.ToString();
        }

        public static explicit operator string (Producto p)
        {
            return p.codigoDeBarras;
        }
        //Igualdad (Producto, Producto). Retornará true, si las marcas y códigos de 
        //barras son iguales, false, caso contrario
        public static bool operator ==(Producto p, Producto p2)
        {
            if (p is null)
            {
                Console.WriteLine("p es nulo y no se por que");
            }

            return p == p2;
        }
        public static bool operator !=(Producto p, Producto p2)
        {
            return !(p == p2);
        }
        //Igualdad (Producto, string). Retornará true, si la marca del producto coincide con la cadena
        //pasada por parámetro, false, caso contrario.
        public static bool operator ==(Producto p, string marca)
        {
            return p.marca == marca;
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p.marca == marca);
        }


    }
}
