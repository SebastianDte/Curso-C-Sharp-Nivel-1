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
            //Hacer una función llamada “mayor” que reciba dos números enteros y
            //devuelva el mayor de ellos o cero si son iguales.

            int n1, n2, r;

            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            n2 = int.Parse(Console.ReadLine());
            r = Mayor(n1, n2);
            Console.WriteLine("El numero mayor es: " + r);
            Console.ReadKey();
        }

        static int Mayor(int n1, int n2)
        {
            int r;
            if (n1 > n2)
                r = n1;
            else
                r = n2;

            return r;
                
        }
    }
}
