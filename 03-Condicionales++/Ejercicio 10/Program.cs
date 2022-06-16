using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite cuatro números y emitir un cartel aclaratorio si
            //son todos iguales entre sí, caso contrario, no emitir nada.

            int n1, n2, n3, n4;
            Console.WriteLine("Ingrese el primer valor");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el primer valor");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el primer valor");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el primer valor");
            n4 = int.Parse(Console.ReadLine());

            if (n1 == n2 && n2 == n3 && n3 == n4)
                Console.WriteLine("Son iguales");

            Console.ReadKey();
        }
    }
}
