using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa para ingresar un número y luego se emita un cartel por
         //pantalla “Positivo” si el número es mayor a cero, “Negativo” si el número es
         //menor a cero o “Cero” si el número es igual a cero.

         int a;

         Console.WriteLine("Ingrese un valor para A:");

         a = int.Parse(Console.ReadLine());

         if(a==0)
            Console.WriteLine("El número es cero.");
         else if (a > 0)
            Console.WriteLine("El número es positivo.");
         else
            Console.WriteLine("El número es negativo.");
         
         Console.ReadKey();
      }
   }
}
