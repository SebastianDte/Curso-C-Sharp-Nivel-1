using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dada una lista de 10 números enteros, cargarlos en un vector.Luego,
            //determinar e informar si el vector está ordenado en forma creciente.Por
            //ejemplo el vector con los valores 1, 3, 5, 7 y 9 está ordenado; el vector 1, 5, 3, 7
            //y 9 no lo está.

            int[] n = new int[10];
            int num, acu = 0;
            bool b = true, ordenados = true;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero");
                num = int.Parse(Console.ReadLine());
                n[x] = num;
            }

            for (int i = 0; i < 10; i++)
            {
                if (b)
                {
                    acu = n[i];
                    b = false;
                }
                else
                {
                    if (acu >= n[i])
                    {
                        acu = n[i];
                    }
                    else
                        ordenados = false;
                }
            }
            if (ordenados)
                Console.WriteLine("Estas ordenados de forma creciente");
            else
                Console.WriteLine("Estan desordenados");
            Console.ReadKey();



        }
    }
}
