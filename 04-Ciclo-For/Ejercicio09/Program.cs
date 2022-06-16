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
            //Hacer un programa que solicite 20 números y luego mostrar por pantalla el
            //menor de ellos y la posición en la que fue encontrado.

            int acu = 0, con = 0;
            double p;

            for (int x = 0; x < 20; x++)
            {
                int n;
                Console.WriteLine("Ingrese una edad");
                n = int.Parse(Console.ReadLine());

                if(n > 18)
                { 
                    con++;
                    acu += n;
                }
            }
            p = acu / con;
            Console.WriteLine("El promedio de las personas mayores a 18 es de: " + p );
            Console.ReadKey();
        }
    }
}
