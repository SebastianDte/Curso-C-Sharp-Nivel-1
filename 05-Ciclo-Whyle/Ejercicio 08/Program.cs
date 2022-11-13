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
            //Hacer un programa que solicite una lista de números que corta cuando se
            //ingresa un cero y luego mostrar por pantalla el menor y el segundo menor.

            int n , minI = 0 , minII= 0;
            bool b1 = true; 
            bool b2 = true;
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());

            while (n!=0)
            {
                if(b1)
                {
                    minI = n;
                    b1 = false;
                }
                else if (n < minI)
                    minI = n;
                else if (b2)
                {
                    minII = n;
                    b2 = false;
                }
                else if(n < minII)
                    minII = n;
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El menor primero es: " + minI + "El menor segundo es: " + minII);
            Console.ReadKey();

        }
    }
}
