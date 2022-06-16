using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 números y luego mostrar por pantalla el
            //menor de ellos y la posición en la que fue encontrado.
            int pos = 0, min = 0;

            for (int x = 0; x < 20; x++)
            {
                int n;
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    min = n;
                    pos = 1;
                }
                else if (n < min)
                {
                    min = n;
                    pos = x + 1;
                }
            }
            Console.WriteLine("El numero menor es: " + min + " En la posicion: " + pos);
            Console.ReadKey();
        }
    }
}
