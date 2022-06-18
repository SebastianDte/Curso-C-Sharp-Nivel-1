using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

         int a, b, c, d, menor;

         Console.WriteLine("Ingrese un valor para A, B,C y D:");

         a = int.Parse(Console.ReadLine());
         b = int.Parse(Console.ReadLine());
         c = int.Parse(Console.ReadLine());
         d = int.Parse(Console.ReadLine());

         if (a < b)
            menor = a;
         else
            menor = b;
         if (c < menor)
            menor = c;
         if (d < menor)
            menor = d;

         Console.WriteLine("El número de menor valor es: {0}", menor);

         Console.ReadKey();
      }
   }
}
