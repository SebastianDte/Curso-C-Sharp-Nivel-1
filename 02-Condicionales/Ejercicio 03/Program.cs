using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa para ingresar dos números y que luego emita por pantalla
         //el mayor de ellos o un cartel aclaratorio “Son iguales” en el caso de que así sea.

         int a, b;

         Console.WriteLine("Ingrese un valor para A y un valor para B:");
         a = int.Parse(Console.ReadLine());
         b = int.Parse(Console.ReadLine());

         if (a == b)
            Console.WriteLine("A y B son iguales");
         else if (a>b)
            Console.WriteLine("A es mayor que B");
         else
            Console.WriteLine("B es mayor que A");

         Console.ReadKey();
      }
   }
}
