using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite el ingreso de 10 números y que muestre el
            //mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

            int n = 0, m = 0;
            
            for (int X = 0; X < 10; X++)
            {
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
                if (X == 0)
                    m = n;
                else if (n > m)
                    m = n;
            }
            Console.WriteLine("El numero mayor es: " + m);
            Console.ReadKey();
                

                
                



            

                    





        }
    }
}
