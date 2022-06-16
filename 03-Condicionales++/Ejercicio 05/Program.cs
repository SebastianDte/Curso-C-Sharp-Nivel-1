using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Hacer un programa que solicite el ingreso de las notas del primer parcial y del
            //segundo parcial de una alumna de programación. El programa deberá analizar
            //las notas y emitir la situación de la alumna según la siguiente escala:
            //  a.Si tiene 8 o más en ambos parciales, emitir “aprobación directa”.
            //b.Si no tiene 8 o más en ambos pero tiene aprobados ambos parciales(se
            //aprueba con 6 o más), emitir “rinde examen final”.
            //c.Si tiene menos de 6 en alguno de los dos parciales, emitir “debe
            //recuperar”.
            //El programa debe emitir solo un cartel, el que corresponda.

            int p1, p2;

            Console.WriteLine("Igrese la primer nota");
            p1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Igrese la segunda nota");
            p2 = int.Parse(Console.ReadLine());

            if (p1 >= 8 && p2 >= 8)
                Console.WriteLine("Aprobacion directa");
            else if (p1 < 4 || p2 < 4)
                Console.WriteLine("Debe recuperar");
            else
                Console.WriteLine("Rinde examen Final");
            Console.ReadKey();
        }
    }
}
