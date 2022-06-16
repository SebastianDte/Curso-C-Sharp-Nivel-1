using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

         int a, b, c, d;

         Console.WriteLine("Ingrese un valor para A, B,C y D:");

         a = int.Parse(Console.ReadLine());
         b = int.Parse(Console.ReadLine());
         c = int.Parse(Console.ReadLine());
         d = int.Parse(Console.ReadLine());

         if(a>100)
            Console.WriteLine(a);
         if (b > 100)
            Console.WriteLine(b);
         if (c > 100)
            Console.WriteLine(c);
         if (d > 100)
            Console.WriteLine(d);

         Console.ReadKey();
      }
   }
}
