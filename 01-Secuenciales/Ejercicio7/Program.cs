using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar por teclado los metros cuadrados totales de
            //un predio y los metros cuadrados cubiertos; luego calcular y mostrar por
            //pantalla el porcentaje de metros cuadrados cubiertos y el porcentaje de
            //metros cuadrados descubiertos.

            double m2t, m2c,m2d,pm2d,pm2c;
            Console.WriteLine("Ingrese los metros cuadrados totales");
            m2t = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los metros cuadrados cubiertos");
            m2c = double.Parse(Console.ReadLine());
            m2d = m2t - m2c;
            pm2d = m2d * 100 / m2t;
            pm2c = m2c * 100 / m2t;
            Console.WriteLine("El porcentaje de metros cubiertos es de: " + pm2c + " Y el de descubierto es: " + pm2d);
            Console.ReadKey();

        }
    }
}
