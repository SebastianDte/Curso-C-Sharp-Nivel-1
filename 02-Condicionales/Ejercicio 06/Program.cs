using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
   class Program
   {
      static void Main(string[] args)
      {
         //Una casa de video juegos otorga un descuento dependiendo del importe de la
         //compra realizada según los siguientes valores:
         //   • Si el importe es menor a ARS 1000, no hay descuento.
         //   • Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10 %.
         //   • Si el importe es ARS 5000 o más, aplica un descuento del 18 %.

         double importe, compra;

         Console.WriteLine("Ingrese el valor de la compra:");
         importe = double.Parse(Console.ReadLine());

         if (importe >= 5000) 
         {
            compra = importe * 0.82;
            Console.WriteLine("Se aplicó un descuento del 18%, el valor final es de: ${0}", compra); 
         }
         else if (importe >= 1000) 
         { 
            compra = importe * 0.90;
         Console.WriteLine("Se aplicó un descuento del 10%, el valor final es de: ${0}", compra); 
         }
         else
            Console.WriteLine("No se aplicó ningún descuento, el valor final es de: ${0}", importe);

         Console.ReadKey();
      }
   }
}
