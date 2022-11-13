using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar el año actual y el año de la fecha de
            //nacimiento de una persona y luego calcule y emita por pantalla su edad.
            //Nota: no hay que tener en cuenta si la persona cumplió años o no,
            //simplemente calcular.


            int ac,an,e;

            Console.WriteLine("Ingrese el año actual");
            ac = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su fecha de nacimiento");
            an = int.Parse(Console.ReadLine());
            e = ac - an;
            Console.WriteLine("Su edad es de: " + e);
            Console.ReadKey();




        }
    }
}
