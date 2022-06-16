using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “producto” que reciba dos números enteros y que
            //devuelva el producto de ambos. Luego hacer un programa que pida el precio
            //de un artículo y la cantidad vendida y muestre por pantalla el monto total a
            //pagar.Usar la función.

            int n1, n2, r;

            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            n2 = int.Parse(Console.ReadLine());
            r = Producto(n1, n2);


            Console.WriteLine("El resultado es: " + r);
            Console.ReadKey();
        }

        static int Producto(int n1, int n2)
        {
            int r = n1 * n2;
            return r;
            
        }
    }
}
