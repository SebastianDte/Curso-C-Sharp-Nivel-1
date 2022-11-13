using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite la edad de un grupo de personas. El programa
            //deberá pedir edades hasta que se ingrese una edad menor a 18 años.Deberá
            //mostrar por pantalla cuántas personas mayores se registraron.

            int edad , con = 0;
            Console.WriteLine("Ingrese una edad");
            edad = int.Parse(Console.ReadLine());


            while (edad >= 18)
            {
                con++;
                Console.WriteLine("Ingrese una edad");
                edad = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("La cantidad de personas mayores es de: " + con);
            Console.ReadKey();

                

        }
    }
}
