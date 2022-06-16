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
            //Hacer un programa que solicite 10 números y luego mostrar por pantalla el
            //máximo de ellos y la posición en la que fue ingresado.

            int pos = 0 , max = 0;

            for (int x = 0; x < 10 ; x++)
            {
                int n;
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    max = n;
                    pos = 1;
                }
                else if (n > max)
                {
                    max = n;
                    pos = x + 1;
                }
            }
                Console.WriteLine("El numero mayor es: " + max + " En la posicion: " + pos);
                Console.ReadKey();



        }
    }
}
