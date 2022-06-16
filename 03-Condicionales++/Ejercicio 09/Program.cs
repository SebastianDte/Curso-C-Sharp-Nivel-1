using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Una importante marca de computadoras permite elegir cierta configuración del
            //equipo a comprar.Para ello existe la siguiente escala de precios:
            //i5(1) i7(2) i9(3)
            //8 RAM(1) USD 800 USD 900 USD 1200
            //16 RAM(2) USD 900 USD 1000 USD 1400
            //32 RAM(3) USD 1000 USD 1400 USD 2000
            //Además, el equipo viene con un disco que permite almacenar 500 GB de
            //información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo
            //adicional de USD 300.
            //Hacer un programa que solicite la opción de procesador, la opción de memoria
            //RAM, y si extiende el disco o no(ingresa 1 para extender y 0 para no extender)
            //y calcule y emita por pantalla el monto de la máquina seleccionada.

            int p, r, d;
            Console.WriteLine("Seleccione su procesador: 1:I5, 2:i7, 3:i9");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("Seleccione su memoria ram: 1:8GB, 2:16GB, 3:32GB");
            r = int.Parse(Console.ReadLine());

            switch (p)
            {
                case 1:
                    switch (r)
                    {
                        case 1:
                            p = 800;
                            break;
                        case 2:
                            p = 900;
                            break;
                        case 3:
                            p = 1000;
                            break;
                    }
                    break;

                case 2:
                    switch (r)
                    {
                        case 1:
                            p = 900;
                            break;
                        case 2:
                            p = 100;
                            break;
                        case 3:
                            p = 1400;
                            break;
                    }
                    break;

                case 3:
                    switch (r)
                    {
                        case 1:
                            p = 1200;
                            break;
                        case 2:
                            p = 1400;
                            break;
                        case 3:
                            p = 2000;
                            break;
                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }
            Console.WriteLine("Desea extender el disco duro por 300usd? Precione 1 para extender y 0 para caso contrario");
            d = int.Parse(Console.ReadLine());
            if (d == 1)
                p = p + 300;
            Console.WriteLine("El precio final es de: " + "$" + p);
            Console.ReadKey();
        }
    }
}
