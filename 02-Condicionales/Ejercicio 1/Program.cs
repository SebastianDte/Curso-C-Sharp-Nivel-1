using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa para ingresar un número y luego se emita por pantalla un
         //cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.

         int n;

         Console.WriteLine("Ingrese un valor:");
         n = int.Parse(Console.ReadLine());

         if (n > 10)
            Console.WriteLine("{0} es mayor a 10.", n);
         else
            Console.WriteLine("No es mayor a 10.");

         Console.ReadKey();
      }
   }
}
