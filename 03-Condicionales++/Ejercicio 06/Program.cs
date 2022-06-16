using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar por teclado la longitud de los tres lados de un
            //triángulo y que luego determine e informe con un cartel aclaratorio a qué tipo
            //de triángulo corresponde:
            //a.Equilátero: cuando los tres lados sean iguales.
            //b.Isósceles: cuando dos de los tres lados sean iguales.
            //c.Escaleno: cuando todos los lados sean distintos.

            double n1, n2, n3;

            Console.WriteLine("Ingrese el primer valor");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el seungdo valor");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer valor");
            n3 = double.Parse(Console.ReadLine());

            if (n1 == n2 && n2 == n3)
                Console.WriteLine("Equilatero");
            else if (n1 != n2 && n2 != n3)
                Console.WriteLine("Escaleno");
            else
                Console.WriteLine("isoceles");
            Console.ReadKey();
        }
    }
}
