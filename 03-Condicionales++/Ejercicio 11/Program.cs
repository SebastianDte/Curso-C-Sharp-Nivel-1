using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Hacer un programa para ingresar tres números y luego mostrarlos ordenados
            //de menor a mayor.

            int n1, n2, n3;
            Console.WriteLine("Ingrese 3 numeros para ordenar de menor a mayor");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine(n1);
                if (n2 < n3)
                {
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                }
                else
                {
                    Console.WriteLine(n3);
                    Console.WriteLine(n2);
                }
            }
            else
            {
                if (n2 < n3 && n2 < n1)
                {
                    Console.WriteLine(n2);
                    if (n3 < n1)
                    {
                        Console.WriteLine(n3);
                        Console.WriteLine(n1);
                    }
                    else
                    {
                        Console.WriteLine(n1);
                        Console.WriteLine(n3);
                    }
                }
                else
                {
                    Console.WriteLine(n3);
                    if (n2 < n1)
                    {
                        Console.WriteLine(n2);
                        Console.WriteLine(n1);
                    }
                    else

                    {
                        Console.WriteLine(n1);
                        Console.WriteLine(n2);
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
