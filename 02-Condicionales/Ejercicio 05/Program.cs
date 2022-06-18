using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa para ingresar un número y mostrar por pantalla un cartel
         //aclaratorio si el mismo es PAR o IMPAR.

         int a;

         Console.WriteLine("Ingrese un valor para A:");
         a = int.Parse(Console.ReadLine());

         if (a%2==0)
            Console.WriteLine("El número es par.");
         else
            Console.WriteLine("El número es impar.");

         Console.ReadKey();
      }
   }
}
