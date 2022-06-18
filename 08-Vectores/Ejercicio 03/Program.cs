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
            //Hacer un programa que solicite 100 números enteros y los guarde en un
            //vector.Luego recorrer ese vector para calcular el promedio. Mostrar por
            //pantalla los valores del vector que son mayores al promedio calculado.

            int[] n = new int[100];
            int num, promedio = 0, acu = 0;

            for (int x = 0; x < 100; x++)
            {
                Console.WriteLine("ingrese un numero");
                num = int.Parse(Console.ReadLine());
                n[x] = num;
            }

            for (int i = 0; i < 100; i++)
            {
                acu += n[i];
            }
            promedio = acu / 100;
            for (int y = 0; y < 100; y++)
            {
                if (n[y] > promedio) 
                { Console.WriteLine(n[y] + "es mayor al promedio calculado"); }
            }
            Console.ReadKey();

        }
    }
}
