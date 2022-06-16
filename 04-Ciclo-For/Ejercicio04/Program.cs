using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para mostrar los números del 10 al 1.No se debe realizar
            //ningún pedido de datos.

            for (int x = 10; x >= 1; x--)
            {
                Console.Write(x + ";");

            }
            Console.ReadKey();
        }
    }
}
