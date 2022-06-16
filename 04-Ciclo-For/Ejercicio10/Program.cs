using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 números y luego emitir por pantalla el
            //máximo de los números pares y el mínimo de los números impares.

            bool bp = true, bi = true;
            int maxp = 0, mini = 0, n;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingre un numero");
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    if (bp)
                    {
                        maxp = n;
                        bp = false;
                    }
                    else
                    {
                        if (n > maxp)
                            maxp = n;
                    }
                }
                else
                {
                    if (bi)
                    {
                        mini = n;
                        bi = false;
                    }
                    else
                    {
                        if (n < mini)
                            mini = n;
                    }
                }
            }
            Console.WriteLine("El maximo par es: " + maxp + "El minimo impar es: " + mini);
            Console.ReadKey();
        }
    }
}
