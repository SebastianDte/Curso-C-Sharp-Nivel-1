using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa para ingresar dos números distintos y luego se muestre por
         //pantalla el menor de ellos.

         int a, b;

         Console.WriteLine("Ingrese un valor para A y un valor distinto para B:");
         a = int.Parse(Console.ReadLine());
         b = int.Parse(Console.ReadLine());

         if(a>b)
            Console.WriteLine("El menor es B");
         else 
            Console.WriteLine("El menor es A");

         Console.ReadKey();
      }
   }
}
