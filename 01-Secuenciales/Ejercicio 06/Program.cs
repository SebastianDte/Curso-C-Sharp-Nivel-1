using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar por teclado las tres notas de exámenes de un
            //alumno y luego calcule y emita por pantalla el promedio final.

            double n1,n2,n3,p;

            Console.WriteLine("Ingrese las notas del alumno");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());
            p = (n1+ n2 + n3)/3;

            Console.WriteLine("El promedio del alumno es: " + p);
            Console.ReadKey();

        }
    }
}
