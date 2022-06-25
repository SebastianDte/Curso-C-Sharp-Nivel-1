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
            //    Se dispone de un lote de 300 registros(uno por artículo), cada uno de los cuales tiene la
            //    siguiente información:
            //                -Número de artículo(4 dígitos no correlativos).
            //    -Cantidad de unidades en stock.
            //    -Precio Unitario.
            //    El lote está desordenado.
            //    Se dispone de otro lote de registros, cada uno de los cuales corresponde a una venta con la siguiente
            //    información:
            //                -Número de cliente(1 a 300).
            //    -Número de artículo(4 dígitos, no correlativos).
            //    -Cantidad de unidades vendidas.
            //    El último registro de este lote tiene número de cliente cero y no debe procesarse.Desarrollar el
            //    programa que determine e imprima:
            //                a) Un listado de las ventas realizadas, con el siguiente formato:
            //                Listado de ventas
            //    Nro.Cliente Nro. Artículo Cantidad Vendida Importe Total
            //    99          99              999             999.99
            //    b) Informar cuál es el número de cliente que más compró en total(en pesos).
            //    c) Informar cada uno de los números de los artículos que no hayan registrado ventas.

            int[] vNumeroArticulo = new int[300];
            int[] vStock = new int[300];
            float[] vPrecioUnitario = new float[300];
            

            

            LoteCarga(ref vNumeroArticulo, ref vStock, ref vPrecioUnitario);
            LoteVenta(ref vNumeroArticulo, ref vStock, ref vPrecioUnitario);
            Console.ReadKey();


        }
          static void LoteCarga(ref int []numeroArticulo,ref int [] stock, ref float [] precioUnitario)
          {
            for (int x = 0; x < 300; x++)
            {
                Console.WriteLine("Ingrese el Numero de Articulo");
                numeroArticulo[x] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese las unidades en Stock");
                stock[x] = int.Parse (Console.ReadLine());
                Console.WriteLine("Ingrese el precio unitario");
                precioUnitario[x] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Lote de carga finalizado");
          }

        static void LoteVenta(ref int[] vnumeroArticulo, ref int[] vstock, ref float[] vprecioUnitario)
        {
            int numeroCliente, numeroArticulo, unidadesVendidas;
            float ImporteTotal, mayorvCliente = 0,mayorAcu = 0;
            bool acu = true;
            float[] vAcu = new float[300];
            float importeTotal = 0;
            float [] noVentas = new float[300];



            do
            {
                Console.WriteLine("Ingrese el numero de cliente");
                numeroCliente = int.Parse(Console.ReadLine());
                if (numeroCliente != 0)
                {
                    Console.WriteLine("Ingrese el numero de Articulo");
                    numeroArticulo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese las unidades vendidas");
                    unidadesVendidas = int.Parse(Console.ReadLine());
                    ImporteTotal = Acumulador(numeroArticulo, unidadesVendidas,ref vnumeroArticulo,ref vprecioUnitario,ref mayorvCliente);
                    Console.WriteLine("Listado de ventas:");
                    Console.WriteLine("Nro. Cliente " + " Nro.Articulo " + " Cantidad Vendida " + " Importe Total ");
                    Console.WriteLine(numeroCliente + "           " + "     " + numeroArticulo + "               " + unidadesVendidas +      "         " + ImporteTotal);
                }
            
            } while (numeroCliente != 0);
            Console.WriteLine("El cliente que mas compro fue " + mayorvCliente + " Con la cantidad de: " + " $ " + mayorAcu  );
            Console.WriteLine("Los articulos que no registraron ventas fueron: ");
            for (int x = 0; x < 300; x++)
            {
                if(vAcu[x] == 0)
                {
                    noVentas[x] = vnumeroArticulo[x];
                    Console.WriteLine(noVentas[x]);
                }
                
            }
            
            

            float Acumulador(int numeroarticulo,int unidadesvendidas, ref int [] vnumArticulo, ref float [] precioUnitario, ref float mayorVCliente)
            {
               
                
                
                
                for (int i = 0; i < 300; i++)
                {
                    if(numeroarticulo == vnumArticulo[i])
                    {
                            vAcu[i] = unidadesvendidas * precioUnitario[i];
                            importeTotal = vAcu[i];
                        
                        if(acu)
                        {
                            mayorAcu = vAcu[i];
                            mayorVCliente = numeroCliente;
                            acu = false;
                        }
                        else
                        {

                            if (vAcu[i] > mayorAcu)
                            {
                                mayorVCliente = numeroCliente;
                                mayorAcu = vAcu[i];
                            }
                        }
                    }
                    
                }
                return importeTotal;
            }

            
                

        }
                            

                        
          
          
	

	


            


    }
}
