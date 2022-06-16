using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite el ingreso de un número y que luego emita un
            //cartel por pantalla aclarando si el mismo es múltiplo de 5.

            int n;

            Console.WriteLine("ingrese un valor para saber si es multiplo");
            n = int.Parse(Console.ReadLine());
            if (n % 5 == 0)
                Console.WriteLine(" es multiplo de 5");
            else
                Console.WriteLine("no es es multiplo");
            Console.ReadKey();
        }
    }
}
