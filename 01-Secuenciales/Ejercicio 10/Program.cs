using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar por teclado dos números y que luego
            //muestre por pantalla la suma, la resta, la multiplicación y la división de dichos
            //números.Se deben mostrar cuatro resultados en pantalla.Los números deben
            //ser solicitados una única vez.

            int n1, n2;
            double rs, rr, rm, rd;

            Console.WriteLine("Ingrese los numeros a calcular");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            rs = n1 + n2;
            rr = n1 - n2;
            rm = n1 * n2;
            rd = n1 / n2;

            Console.WriteLine("El resultado de la suma es: " + rs + "El resultado de la resta es: " + rr + "El resultado de la multuplicacion es: " + rm + "El resultado de la division es de: " + rd);
            Console.ReadKey();

        }
    }
}
