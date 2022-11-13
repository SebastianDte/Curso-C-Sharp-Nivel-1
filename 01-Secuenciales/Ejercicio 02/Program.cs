using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para solicitar por teclado un número y luego devolver su
            //valor elevado al cubo.
            //Nota: no olvides que sólo contamos con las cuatro operaciones básicas.

            int N1, R;

            Console.WriteLine("Ingrese un valor para elevar al cubo");    
            N1 = int.Parse(Console.ReadLine());
            R = N1 * N1 * N1;
            Console.WriteLine("El resultado del numero elevado al cubo es: " + R);
            Console.ReadKey();
        }
    }
}
