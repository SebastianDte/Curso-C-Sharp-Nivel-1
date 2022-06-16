using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Una importante cadena de delivery cuenta con una promoción por tiempo
            //limitado en la que otorga un 15 % de descuento sobre el total del valor de la
            //compra realizada. Hacer un programa para solicitar el monto total y el mismo
            //calcule y emita por pantalla el total a cobrar con el descuento aplicado.

            double mt;
            Console.WriteLine("Ingrese el monto total");
            mt = double.Parse(Console.ReadLine());
            mt = mt * 0.85;
            Console.WriteLine("El monto total a cobrar es de: " + mt);
            Console.ReadKey();
        }
    }
}
