using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “pagos” que reciba un monto(float) y una cantidad
            //de pagos(entero) y devuelva el monto de cada pago.Hacer un programa para
            //ingresar 10 ventas.Para cada venta se conoce el monto y la cantidad de pagos.
            //El programa deberá mostrar la cantidad de pagos y el monto del pago para
            //cada una de las ventas.

            float monto = 0;
            int cantPagos = 0;
            float cuotas = 0;

            for (int x = 0; x < 2; x++)
            {
                Console.WriteLine("Ingre el monto a pagar");
                monto = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingre la cantidad de cuotas");
                cantPagos = int.Parse(Console.ReadLine());
                cuotas = Pagos(monto, cantPagos);

                Console.WriteLine("La cantidad de cuotas es: " + cantPagos + " El valor de cada cuota es de: " + cuotas);
            }

                    Console.ReadKey();
        }

        static float Pagos (float monto, int cantPagos)
        {
            float cantPagares;
            return cantPagares = monto / cantPagos;
        }
    }
}
