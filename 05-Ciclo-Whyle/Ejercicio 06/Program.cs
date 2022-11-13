using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite UN número y luego calcule y emita un cartel
            //aclaratorio si el mismo es primo o no es primo.
            //Nota: usando While. Ya lo hicimos con FOR, ahora con While.

            int n1,n2 = 1, con = 0;
            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());

            while (n2 <= n1)
            {
                if (n1 % n2 == 0)
                {
                    con++;
                }
                    n2++;
            }
            if (con == 2)
                Console.WriteLine("El numero ingresado es primo");
            else
                Console.WriteLine("El numero ingresado no es primo");
            Console.ReadKey();
               
                    

        }
    }
}
