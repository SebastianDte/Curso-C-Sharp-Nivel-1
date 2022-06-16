using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “primo” que reciba un número entero y devuelva 1
            //si el número es primo o cero si no lo es.Hacer un programa para ingresar
            //números.El lote corta cuando se ingresa un número cero.Informar el
            //promedio teniendo en cuenta sólo los números primos.


            double n1, acuPrimos = 0, contPrimos = 0;
            bool comprobacion;

            Console.WriteLine("Ingrese un numero");
            n1 = double.Parse(Console.ReadLine());

            while (n1 != 0)
            {

                comprobacion = Primos(n1);
                if (comprobacion)
                {
                    acuPrimos += n1;
                    contPrimos++;

                }

                Console.WriteLine("Ingrese un numero");
                n1 = double.Parse(Console.ReadLine());
            }
            acuPrimos = acuPrimos / contPrimos;
            Console.WriteLine("El porecentaje de numeros primos es de: " + acuPrimos);
            Console.ReadKey();
        }
        static bool Primos(double n1)
            
		{
            double con = 0;
            for (int i = 1; i <= n1; i++)
            {
                if (n1 % i == 0)
                {
                    con++;
                    
                }
            }
                if (con == 2)
                     return true;
                else
                    return false;
		}
                
        



        
    }
    
}
