using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar 4 números.Luego analizar e informar por
            //pantalla si los mismos se encuentran ordenados de forma decreciente.

            int n1, n2, n3, n4;
            Console.WriteLine("Ingrese el primer valor");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer valor");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto valor");
            n4 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n2 > n3 && n3 > n4)
                Console.WriteLine("Estan ordenados");
            else
                Console.WriteLine("No estan ordenados");
            Console.ReadKey();
        }
    }
}
