using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_5
{
    class Estante
    {
        Producto[] productos;
        int ubicacionEstante;

        //4) El constructor de instancia privado será el único que inicializará el array. La sobrecarga
        //pública del constructor inicializará la
        //ubicación del estante, recibiendo como parámetro capacidad y ubicación.Reutilizar código.

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        //5) El método público GetProductos, retornará el array de productos.
        public Producto[] GetProductos()
        {
            return productos;
        }
        //6) El método público de clase MostrarEstante, retornará una cadena con toda la información del
        //estante, incluyendo el detalle de cada uno de sus productos.Reutilizar código.

        public static string MostrarEstante(Estante e)
        {
            string retorno;
            retorno = e.ubicacionEstante.ToString() + " " ;

            foreach (Producto producto in e.productos)
            {
                if (!(e.productos is null)) //si es verdadero
                {
                    retorno += Producto.MostrarProducto(producto);
                }
            }
            return retorno;
        }

        /*
        Igualdad, retornará true, si es que el producto ya se encuentra en el estante, false, caso contrario.
        +Adición, retornará true y agregará el producto si el estante posee capacidad de almacenar al menos un producto más y
        dicho producto no se encuentra en él; false, caso contrario. Reutilizar código.
        -Sustracción (Estante, Producto), retornará un estante sin el producto, siempre y cuando el producto se encuentre en el
        listado. Reutilizar código
        */

        //operador MAS
        public static bool operator +(Estante e, Producto p)
        {
            //true: agregara el producto, si el estante posee la capacidad de almacenar un elemento
            //y ademas ese producto no tiene que existr.
            if (e != p)
            {
                Console.WriteLine("no existe ningun producto en el estante  ");
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos is null)
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
           for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p)
                {
                    e.productos[i] = null;
                    break;
                }
            }
            return e;
        }

        public static bool operator ==(Estante e, Producto p)
        {
            foreach (Producto producto in e.productos)
            {
                if (producto == p)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

     




    }
}
