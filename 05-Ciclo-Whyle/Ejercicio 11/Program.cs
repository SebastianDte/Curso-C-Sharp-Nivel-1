using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, cpri = 0, cpar = 0, cpos = 0, cn = 0;
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());

            while (n!=0)
            {
                if (n < 0)
                    cn++;
                else
                    cpos++;
                if (n % 2 == 0)
                    cpar++;
                int n2 = 1;
                int con = 0;
                while (n2 <= n)
                {
                    if (n % n2 == 0)
                    {
                        con++;
                        n2++;
                    }
                    else
                        n2++;
                }
                if (con == 2)
                    cpri++;
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("cantidad de primos: " + cpri);
            Console.WriteLine("cantidad de pares: " + cpar);
            Console.WriteLine("cantidad de positivos: " + cpos);
            Console.WriteLine("cantidad de negativos: " + cn);
            Console.ReadKey();
                
                
        }
    }
}
