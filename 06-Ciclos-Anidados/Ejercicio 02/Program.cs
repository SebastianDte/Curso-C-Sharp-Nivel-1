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
            //Una compañía de electricidad necesita calcular anualmente el consumo que ha
            //registrado cada uno de sus usuarios y el monto pagado por cada uno de ellos.
            //Para ello tiene un lote de registros por cada uno de los usuarios con los
            //siguientes datos:
            //• Zona(numérico entero).
            //• Número de cliente(número de cuatro dígitos no correlativos).
            //• Cantidad de kilovatios consumidos en el periodo.
            //El lote se encuentra agrupado(no ordenado) por zona y finaliza con un registro
            //con zona igual a cero.
            //Se pide generar un listado con el siguiente formato:
            //        Zona: XX
            //        Cantidad de usuarios de la zona: XX
            //        Total facturado en la zona: XX
            //        Zona: XX
            //        Cantidad de usuarios de la zona: XX
            //        Total facturado en la zona: XX
            //        El precio es escalonado según la siguiente escala:
            //• $ 0.10 por kv por los primeros 100 kv de consumo.
            //• $ 0.12 por kv por el consumo de 101 a 200 kvs.
            //• $ 0.15 por kv por el consumo de 201 kvs en adelante.

            int zona, zonaActual = 0;
            
            Console.WriteLine("Ingre su zona");
            zona = int.Parse(Console.ReadLine());

            while (zona != 0)
            {
                int numeroDeCliente;
                double cantiKilovatios = 0;
                int cantidadUsuarios = 0 ;
                double TotalFacturado = 0;
                zonaActual  = zona;

                while (zona == zonaActual)
                {
                    Console.WriteLine("Selecciono la zona: " + zonaActual);
                    Console.WriteLine("Ingrese su numero de cliente de 4 digitos no correlativos");
                    numeroDeCliente = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese su consumo en este periodo");
                    cantiKilovatios = int.Parse(Console.ReadLine());

                    if (cantiKilovatios >= 201)
                        TotalFacturado += cantiKilovatios * 0.15;
                    else if (cantiKilovatios >= 101 && cantiKilovatios <= 200)
                        TotalFacturado += cantiKilovatios * 0.12;
                    else
                        TotalFacturado += cantiKilovatios * 0.10;


                    cantidadUsuarios++;
                    Console.WriteLine("Ingrese su zona");
                    zona = int.Parse(Console.ReadLine());
                }
                Console.WriteLine(" ");
                Console.WriteLine(" zona: " + zonaActual);
                Console.WriteLine(" Cantidad de usuarios de la zona: " + cantidadUsuarios);
                Console.WriteLine(" Total Facturado por zona: " + "$" + TotalFacturado);
                Console.WriteLine(" ");

            }
            Console.ReadKey();



        }
    }
}
