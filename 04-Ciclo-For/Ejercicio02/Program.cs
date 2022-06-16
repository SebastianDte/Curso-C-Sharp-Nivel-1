using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 números y calcule y emita por pantalla
            //cuántos son positivos(mayores a cero). Se debe mostrar un solo valor: el
            //conteo final.

            int con = 0;

            for (int x = 0; x < 20; x++)
            {
                int n;
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
                if (n > 0)
                    con++;
            }
            Console.WriteLine("El total de numeros positivos es de: " + con);
            Console.ReadKey();



        }
    }
}
