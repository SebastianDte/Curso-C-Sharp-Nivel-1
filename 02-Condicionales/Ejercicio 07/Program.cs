using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el mayor de ellos.

         int a, b, c, d;

         Console.WriteLine("Ingrese un valor para A, B,C y D:");

         a = int.Parse(Console.ReadLine());
         b = int.Parse(Console.ReadLine());
         c = int.Parse(Console.ReadLine());
         d = int.Parse(Console.ReadLine());

         if (a > b && a > c && a > d)
            Console.WriteLine("A es el mayor.");
         else if (b > c && b > d)
            Console.WriteLine("B es el mayor");
         else if (c>d)
            Console.WriteLine("C es el mayor");
         else
            Console.WriteLine("D es el mayor");

         Console.ReadKey();

      }
   }
}
