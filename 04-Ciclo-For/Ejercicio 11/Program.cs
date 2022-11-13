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
            //Hacer un programa para ingresar 10 números y luego calcule y emita el mayor
            //de los primos de la lista. En caso de no haber ningún número primo, deberá
            //aclararlo con un cartel.

            bool b = true;
            int max = 0, coni = 0;
            

            for (int x = 0; x < 5 ; x++)
            {
                int conp = 0;
                int  n;

                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
                for (int y = 1; y <= n ; y++)
                {
                    if(n % y == 0)
                        conp++;
                }
                if (conp == 2)
                {
                    if (b)
                    {
                        max = n;
                        b = false;
                    }
                    else if (n > max)
                        max = n;

                }
                else
                    coni++;
            }
            if (coni == 5)
                Console.WriteLine("No hay numeros primos");
            else
                Console.WriteLine("El maximo primo es: " + max);
            Console.ReadKey();
        }
    }
}
                

