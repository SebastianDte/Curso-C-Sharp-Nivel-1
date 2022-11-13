using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar el nuevamente el ejercicio 8 pero ahora debe devolver además la
            //posición en la que fue encontrado cada uno de los mínimos.

            int n, minI = 0,pmI = 0, minII = 0, pmII = 0 , pos = 1;
            bool b1 = true;
            bool b2 = true;
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                if (b1)
                {
                    minI = n;
                    b1 = false;
                    pmI = pos;
                }
                else if (n < minI)
                {
                    minI = n;
                    pmI = pos;
                }
                else if (b2)
                {
                    minII = n;
                    b2 = false;
                    pmII = pos;
                }
                else if (n < minII)
                { minII = n;
                    pmII = pos;
                }
                pos++;
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" El menor primero es: " + minI + " En la posicion: " + pmI);
            Console.WriteLine(" El menor segundo es: " + minII+ " EN la posicion " + pmII);
            Console.ReadKey();
        }
    }
}
