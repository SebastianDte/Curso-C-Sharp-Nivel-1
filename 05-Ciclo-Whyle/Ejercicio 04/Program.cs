using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite dos números y luego muestre los números
            //entre el menor y el mayor de ellos. Acordate, usando While.

            int n1, n2;
            int M, m;
            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                M = n1;
                m = n2;
            }
            else
            {
                m = n1;
                M = n2;
            }
            Console.Write(m + ",");

            while (m < M)
            {
                m++;
                Console.Write(m + ",");
            }
            Console.ReadKey();
            {

            }



        }
    }
}
