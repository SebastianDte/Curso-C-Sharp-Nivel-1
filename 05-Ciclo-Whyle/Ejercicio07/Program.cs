using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite una lista de números que corta cuando se
            //ingresa un cero y luego mostrar por pantalla el máximo de ellos y la posición
            //en la que fue ingresado.

            int n1, pos = 1,M = 0, pm = 0;

            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());

            while (n1 != 0)
            {
                
                if (n1 > M)
                {
                    M = n1;
                    pm = pos;
                }
                pos++;
                Console.WriteLine("Ingrese un numero");
                n1 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El numero mayor ingresado fue " + M + " En la posicion: " + pm);
            Console.ReadKey();


        }
    }
}
