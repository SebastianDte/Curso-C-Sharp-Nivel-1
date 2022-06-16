using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si
            //la suma de los dos primeros es mayor al producto del segundo con el tercero.

            int n1, n2, n3, r1, r2;
            Console.WriteLine("Ingrese el primer valor");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer valor");
            n3 = int.Parse(Console.ReadLine());

            r1 = n1 + n2;
            r2 = n2 * n3;
            if (r1 > r2)
                Console.WriteLine("Es mayor la suma");
            Console.ReadKey();
        }
    }
}
