using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Una empresa comercializa 15 tipos de artículos y por cada venta realizada
            //genera un registro con los siguientes datos:
            //• Número de artículo(1 a 15).
            //• Cantidad vendida.
            //Puede haber varios registros para el mismo artículo y el último se indica
            //número de artículo igual a cero.
            //Se pide determinar e informar:
            //            a.El número de artículo que más se vendió en total.
            //b.Los números de artículos que no registraron ventas.
            //c.La cantidad de unidades vendidas para el artículo número 10.
            //Nota: tener en cuenta el concepto de “registro” y el planteo de estructura
            //principal separado de consignas(ver videos de ciclos combinados y ejercicios
            //resueltos de ciclos combinados).


            int[] tipoArticulo = new int [15] ;
            int cantVenta , numeroArticulo, mayor = 0, posicion = 0, cont = 0;
            int[] sinVentas = new int[15];

            Console.WriteLine("Ingrese el numero del Articulo");
            numeroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese una cantidad de venta");
            cantVenta = int.Parse(Console.ReadLine());

            while (numeroArticulo != 0)
            {
                tipoArticulo[numeroArticulo - 1 ] += cantVenta;
                

                Console.WriteLine("Ingrese el numero del Articulo");
                numeroArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese una cantidad de venta");
                cantVenta = int.Parse(Console.ReadLine());
                if (numeroArticulo == 10)
                    cont++;
            }

            for (int x = 0; x < 15; x++)
            {
                if (tipoArticulo[x] > mayor)
                {
                    mayor = tipoArticulo[x];
                    posicion = x + 1;
                }
                if(tipoArticulo[x] >= 0)
                    sinVentas[x] = x + 1;

            }
            Console.WriteLine("El articulo mas vendido fue el numero: " + posicion + " Con un acantidad de venta de: " + mayor);
            Console.WriteLine("Los articulos sin ventas fueras: " + sinVentas);
            Console.WriteLine("La cantidad de unidades vendidas en el articulo 10 fue de: " + cont);
            Console.ReadLine();

            
            




        }
    }
}
