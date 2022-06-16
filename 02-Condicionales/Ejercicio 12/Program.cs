using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa para ingresar un valor que estará expresado en minutos. Si
         //los minutos superan los 60, pasar el valor a horas, de lo contrario dejarlo en
         //minutos.Mostrar el resultado en pantalla aclarando si se muestran minutos u horas.

         double minutos, hora;

         Console.WriteLine("Ingrese la cantidad de minutos para saber la hora:");

         minutos = double.Parse(Console.ReadLine());

         if (minutos > 60)
         {
            hora = minutos / 60;
            Console.WriteLine("Horas: {0}", hora);
         }
         else
            Console.WriteLine("Minutos: {0}", minutos);

         Console.ReadKey();

      }
   }
}
