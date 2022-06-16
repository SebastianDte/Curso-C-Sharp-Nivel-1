using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Una casa de computación paga a sus empleados un sueldo fijo de ARS15000
            //más una comisión del 5 % sobre el total facturado por cada empleado. Hacer un
            //programa para ingresar el total facturado por un empleado y que luego calcule
            //y emita por pantalla el sueldo total a cobrar por el mismo.

            double TF, ST;
            Console.WriteLine("ingrese el total facturado");
            TF = double.Parse(Console.ReadLine());
            ST = 1500 + TF * 1.05;
            Console.WriteLine("El total facturado es de: " + ST );
            Console.ReadKey();
        }
    }
}
