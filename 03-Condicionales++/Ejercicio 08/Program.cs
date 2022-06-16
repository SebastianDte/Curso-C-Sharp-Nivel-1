using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //El negocio de desinfectante antes mencionado vende además detergente
            //suelto, y los precios se aplican según la siguiente escala:
            //a. 25 ARS por litro los primeros 50 litros.
            //b. 20 ARS por litro si la venta es de 51 a 200 litros.
            //c. 15 ARS por litro si la venta es de 201 a 500 litros.
            //d. 10 ARS por litro si la venta es de más de 500 litros.
            //Además, si paga en efectivo, tiene un adicional del 10 % sobre el importe final.
            //Hacer un programa que solicite la cantidad de litros vendidos y el tipo de pago
            //(ingresará 1 si paga en efectivo y 0 con cualquier otro medio de pago) y calcule
            //y emita por pantalla el monto final a abonar por el cliente.

            double lv, mp;
            Console.WriteLine("Ingrese la cantidad de litros vendidos");
            lv = int.Parse(Console.ReadLine());
            if (lv > 500)
                lv = 10 * lv;
            else if (lv >= 201 && lv <= 500)
                lv = lv * 15;
            else if (lv >= 101 && lv <= 200)
                lv = lv * 20;
            else
                lv = lv * 25;
            Console.WriteLine("Presione 1 para abonar en efectivo y 0 otro medio de pago");
            mp = int.Parse(Console.ReadLine());
            if (mp == 1)
                lv = lv * 0.90;

            Console.WriteLine("El total final a abonar es de: " + "$" + lv.ToString("00.00"));
            Console.ReadKey();
        }
    }
}
