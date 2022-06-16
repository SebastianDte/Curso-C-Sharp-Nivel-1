using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar dos números.Si el segundo es distinto de
            //cero, calcular la división del primero por el segundo y mostrar el resultado por
            //pantalla; caso contrario, emitir un cartel aclarando que no se puede dividir por
            //cero.

            double n1, n2, r = 0;
            Console.WriteLine("Ingrese el primer numero");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            n2 = double.Parse(Console.ReadLine());

            if (n2 != 0)
                r = n1 / n2;
            else
                Console.WriteLine("No se puede");

            Console.WriteLine("El resultado de la division es: " + r.ToString("00.00"));

            Console.ReadKey();
        }
    }
}
