using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para mostrar los números del 10 al 1.No se debe realizar
            //ningún pedido de datos.USANDO WHILE.

            int n = 10;

            while (n >= 1)
            {
                Console.Write(n + ",");
                n--;
            }
            Console.ReadKey();
        }
    }
}
