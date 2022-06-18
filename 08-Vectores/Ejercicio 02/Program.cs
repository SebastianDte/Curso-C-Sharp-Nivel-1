using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 50 números enteros y los guarde en un vector.
            //Luego recorrer todos los elementos del vector y determinar cuál es el valor
            //máximo y su posición dentro del vector.

            int[] n = new int[50];
            int num, pos = 0, max = 0;
            bool bmax = true;

            for (int x = 0; x < 50; x++)
            {
                Console.WriteLine("Ingrese un numero");
                num = int.Parse(Console.ReadLine());
                n[x] = num;
                
            }
            for (int i = 0; i < 50; i++)
            {
                if (bmax)
                {
                    pos = i + 1;
                    max = n[i];
                    bmax = false;
                }
                else
                {
                    if (n[i] > max)
                    {
                        max = n[i];
                        pos = i + 1;
                    }
                }
            }
            Console.WriteLine("El numero maximo es " + max + " En la posicion " + pos);
            Console.ReadKey();
                
        }
    }
}
