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
            //Una compañía de turismo aventura registró los paquetes vendidos durante la
            //última temporada vacacional. Para cada venta se ingresó:
            //• Número de paquete(4 dígitos no correlativos).
            //• Cantidad de personas incluidas.
            //• Precio por persona.
            //• Horas totales de actividades.
            //• Tipo de aventura(“M”, Montaña. “T”, Trekking. “R”, Rafting. “B”, Bicicleta.
            //“C”, Canopy. “E”, Escalar. “K”, Sky. “S”, Snowboard. “J”, Jumping. “P”,
            //Parapente).
            //El lote se encuentra no ordenado y agrupado por tipo de aventura y corta con
            //número de paquete cero.En el lote no se ingresan registros cuyo tipo de aventura
            //no se haya vendido.
            //A partir de dichos datos, se solicita informar:
            //            a.La cantidad de paquetes vendidos de cada tipo de aventura..b.La cantidad total de personas que disfrutaron de las aventuras durante la
            //temporada.
            //c.El total recaudado por cada venta.
            //d.La venta con mayor importe de cada tipo de aventura.
            //e.El paquete con menos horas incurridlas y en qué tipo de actividad fue.

            int numPaquete, cantPersonas, precioPersona, hsTotalesAct;
            int  cantVentasPaquete = 0, acumPersonas = 0, totalVentas = 0, mayorImporte  ;
            string tipoAventura, tipoAventuraAct, paqueteMin;
            int paqueMinimo;

            Console.WriteLine("Ingrese el numero de paquete ");
            numPaquete = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de personas");
            cantPersonas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio por persona");
            precioPersona = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de horas totales de la actividad");
            hsTotalesAct = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de aventura");
            Console.WriteLine(" “M”, Montaña. “T”, Trekking. “R”, Rafting. “B”, Bicicleta.“C”, Canopy. “E”, Escalar. “K”, Sky. “S”, Snowboard. “J”, Jumping. “P”, Parapente");
            tipoAventura = (Console.ReadLine());
            paqueMinimo = hsTotalesAct;
            paqueteMin = tipoAventura;



            while (numPaquete != 0)
            {
                mayorImporte = 0;
                tipoAventuraAct = tipoAventura;
                cantVentasPaquete = 0;
                
                while (tipoAventura == tipoAventuraAct)
                {
                    cantVentasPaquete++;
                    acumPersonas = cantPersonas ;
                    totalVentas =  precioPersona * cantPersonas ;
                    
                    if (totalVentas > mayorImporte)
                    {
                        mayorImporte = totalVentas;
                    }
                    if(hsTotalesAct < paqueMinimo)
                    {
                        paqueMinimo = hsTotalesAct ;
                    }
                    


                    
                    
                    Console.WriteLine("Ingrese el numero de paquete ");
                    numPaquete = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad de personas");
                    cantPersonas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el precio por persona");
                    precioPersona = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad de horas totales de la actividad");
                    hsTotalesAct = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el tipo de aventura");
                    Console.WriteLine(" “M”, Montaña. “T”, Trekking. “R”, Rafting. “B”, Bicicleta.“C”, Canopy. “E”, Escalar. “K”, Sky. “S”, Snowboard. “J”, Jumping. “P”, Parapente");
                    tipoAventura = (Console.ReadLine());
                    Console.WriteLine("El total de la venta fue de: " + totalVentas);
                }

                Console.WriteLine("La cantidad de paquetes vendidos en : " + tipoAventuraAct + " fue de: " + cantVentasPaquete);
                Console.WriteLine("La venta con mayor importe por paquete fue de: " + mayorImporte);
            }
            Console.WriteLine("La cantidad total de personas en este temporada fue de: " + acumPersonas);
            Console.WriteLine("El paquete con menor horas incorrudias fue: " + tipoAventura );
            
            Console.ReadKey();




                


        }
    }
}
