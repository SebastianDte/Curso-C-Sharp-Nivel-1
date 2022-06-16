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
            //Hacer una función llamada “par” que reciba un número entero y devuelva 1 si
            //es par o cero si no lo es.Hacer un programa para ingresar 20 números y
            //mostrar por pantalla cuántos son pares.

            int n1, paracu = 0;
            Console.WriteLine("ingrese un numero");
             n1 = int.Parse(Console.ReadLine());

            for (int x = 0; x < 19; x++)
            {
                n1 = Par(n1);
                if(n1 == 1)
                    paracu++;
                Console.WriteLine("ingrese un numero");
                n1 = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Se contaron " + paracu + " Numero pares");
            Console.ReadKey();

        }

        static int Par (int n1)
        {
            if (n1 % 2 == 0)
                return 1;
            else
                return 0;
        }

    }
}
