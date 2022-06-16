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

            //Hacer un programa que solicite el ingreso de dos números y luego calcular:
            //a.La resta si el primero es mayor que el segundo.
            //b.La suma si son iguales.
            //c.El producto si el primero es menor.
            //Se deberá emitir un cartel por pantalla con el resultado correspondiente.

            int n1, n2, r;
            Console.WriteLine("Ingrese el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                r = n1 - n2;
                Console.WriteLine("Los numeros seran restados");
            }
            else if (n1 < n2)
            {
                r = n1 * n2;
                Console.WriteLine("Los numeros seran Multiplicados");
            }
            else
            {
                r = n1 + n2;
                Console.WriteLine("Los numeros seran sumados");
            }
            Console.WriteLine("El resultado es: " + r);
            Console.ReadKey();
        }
    }
}
