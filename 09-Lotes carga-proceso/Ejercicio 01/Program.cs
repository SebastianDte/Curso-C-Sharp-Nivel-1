using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Una empresa que fabrica 20 artículos tiene la siguiente información para cada uno de ellos:
            //-Código de Artículo(4 dígitos, no correlativos).
            //-Precio Unitario.
            //Este primer lote no se encuentra ordenado.
            //Cuenta por otro lado con un lote de registros con las ventas del año anterior.Cada registro contiene
            //la siguiente información:
            //-Número de Cliente(1 a 300).
            //-Código de Artículo(4 dígitos no correlativos).
            //-Mes(1 a 12).
            //- Día(1 a 31).
            //- Cantidad vendida.
            //Puede haber más de un registro para el mismo artículo. El lote finaliza con un registro con número de
            //cliente igual a cero.
            //Se pide:
            //a) Un listado con el siguiente formato:
            //Código de Artículo / Cantidad Total Vendida
            //      999                       999
            //Este listado debe salir ordenado de mayor a menor por cantidad total vendida.
            //b) Informar, si los hubiera, los nombres de los meses en que no hubo ventas.
            //c) Informar los códigos de los artículos cuyas ventas en cantidad son mayores al promedio.



            int[] vCodigoArt = new int[20];
            float[] vAcu = new float[20];
            float[] vPrecioUni = new float[20];
            int[] vMes = new int[12];
            

            CargarLote1(ref vCodigoArt, ref vPrecioUni);
            ProcesoLote1(ref vCodigoArt, ref vPrecioUni, ref vAcu);
            OrdenarVector(ref vAcu, ref vCodigoArt);
            Console.WriteLine("Codigo de Articulo / Cantidad vendida");
            for (int x = 0; x < 3; x++)
            {
                Console.Write(vCodigoArt[x] + "                    " + vAcu[x]);
                Console.WriteLine();
            }

            puntoB(ref vMes, ref vAcu);

            Console.ReadKey();



        }


        //Funciones:

        static void CargarLote1(ref int[] varticulos, ref float[] vprecios)
        {

            int articulos;
            float precioUnitario;
            for (int x = 0; x < 3; x++)
            {

                Console.WriteLine("Ingrese el codigo del articulo");
                articulos = int.Parse(Console.ReadLine());
                varticulos[x] = articulos;
                Console.WriteLine("Ingre el precio unitario");
                precioUnitario = float.Parse(Console.ReadLine());
                vprecios[x] = precioUnitario;
            }

            Console.WriteLine("Lote 1 cargado");
        }

        static void ProcesoLote1(ref int[] varticulos, ref float[] vprecios, ref float[] vAcu)
        {
            int codArticulos, numeroCliente, mes, dia, cantVendida;

            do
            {
                Console.WriteLine("Ingrese el numero de cliente");
                numeroCliente = int.Parse(Console.ReadLine());
                if (numeroCliente != 0)
                {
                    Console.WriteLine("Ingrese el codigo de articulo");
                    codArticulos = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese el mes");
                    mes = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el dia");
                    dia = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad vendida");
                    cantVendida = int.Parse(Console.ReadLine());
                    for (int x = 0; x < 3; x++)
                    {
                        if (codArticulos == varticulos[x])
                        {

                            vAcu[x] += cantVendida * vprecios[x];
                        }


                    }
                }


            } while (numeroCliente != 0);


        }
        static void OrdenarVector(ref float[] vAcu, ref int[] vCodigoArt)
        {
            float auxiliar;
            int auxiliar2;
            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 2; x++)
                {
                    if (vAcu[x] < vAcu[x + 1])
                    {
                        auxiliar = vAcu[x];
                        vAcu[x] = vAcu[x + 1];
                        vAcu[x + 1] = auxiliar;
                        auxiliar2 = vCodigoArt[x];
                        vCodigoArt[x] = vCodigoArt[x + 1];
                        vCodigoArt[x + 1] = auxiliar2;
                    }
                }
            }
        }

        static void puntoB(ref int[] vMes, ref float[] vAcu)
        {
            bool[] vMesventas = new bool[12];

            for (int i = 0; i < 12; i++)
            {
                vMesventas[i] = true;
            }
            for (int x = 0; x < 12; x++)
            {
                vMes[x] = x + 1  ;
                if (vAcu[x] != 0)
                    vMesventas[x] = false;
            }
            
                Console.WriteLine("los meses que no hubo ventas fueron: ");
            for (int i = 0; i < 12; i++)
            {
                switch (vMes[i])
                {
                    case 1:
                        if (vMesventas[i])
                            Console.WriteLine("Enero");
                        break;
                    case 2:
                        if (vMesventas[i])
                            Console.WriteLine("Febrero");
                        break;
                    case 3:
                        if (vMesventas[i])
                            Console.WriteLine("Marzo");
                        break;
                    case 4:
                        if (vMesventas[i])
                            Console.WriteLine("Abril");
                        break;
                    case 5:
                        if (vMesventas[i])
                            Console.WriteLine("Mayo");
                        break;
                    case 6:
                        if (vMesventas[i])
                            Console.WriteLine("Junio");

                        break;
                    case 7:
                        if (vMesventas[i])
                            Console.WriteLine("Julio");
                        break;

                    case 8:
                        if (vMesventas[i])
                            Console.WriteLine("Agosto");

                        break;
                    case 9:
                        if (vMesventas[i])
                            Console.WriteLine("Septiembre");

                        break;
                    case 10:
                        if (vMesventas[i])
                            Console.WriteLine("Octubre");

                        break;
                    case 11:
                        if (vMesventas[i])
                            Console.WriteLine("Noviembre");

                        break;
                    case 12:
                        if (vMesventas[i])
                            Console.WriteLine("Diciembre");
                        break;


                    default:
                        break;
                }
            }
        }






    }
}


           


        


            







        




    

