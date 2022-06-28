using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Una empresa de transporte de carga por camión posee 20 tarifas distintas de acuerdo al destino
            //de los envíos que deba realizar. Dispone de un lote de registros con la siguiente información:
            //-Número de Tarifa(Número de 4 cifras, no correlativos).
            //-Importe por KM.
            //Este lote no viene ordenado.A continuación, dispone de un segundo lote de registros con la
            //información de los envíos que se realizaron durante la semana pasada, conteniendo cada uno de
            //ellos los siguientes campos:
            //-Número de Camión(1 a 20).
            //-Número de Tarifa.
            //-Kilómetros Recorridos.
            //Este lote finaliza con un registro con número de camión negativo.Se nos pide realizar un programa
            //que determine e informe:
            //a) El total recaudado por cada tarifa.
            //b) Un listado como el siguiente:
            //            Número de camión Total recaudado
            //            xxx                 xxx
            //Este listado debe salir ordenado por total recaudado, de mayor a menor.
            //c) Indicar el número de camión que recorrió la menor cantidad de kilómetros entre los que
            //realizaron viajes.Nota: cada camión realizó cero, uno o varios viajes.



            int[] numeroTarifa = new int[20]; int[] vNumeroCamion = new int[20]; float[] acuCamion = new float[20];
            float[] importeKm = new float[20]; float[] acu = new float[20];
            int numeroCamion = 0, numTarifa = 0;
            float kmRecorrido = 0;


            LoteCarga(ref numeroTarifa, ref importeKm);
            LoteProceso(ref numTarifa, ref numeroTarifa, ref kmRecorrido, ref importeKm, ref numeroCamion, ref acu, ref vNumeroCamion, ref acuCamion);
            Console.ReadKey();
        }

        static void LoteCarga(ref int[] numeroTarifa, ref float[] importeKm)
        {
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese el número de tarifa");
                numeroTarifa[x] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el importe por km");
                importeKm[x] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Lote de Registrado cargado");


        }
        static void LoteProceso(ref int numTarifa, ref int[] numeroTarifa, ref float kmRecorrido, ref float[] importeKm, ref int numeroCamion, ref float[] acu, ref int[] vNumeroCamion, ref float[] acuCamion)
        {
            int menorCamion = 0;
            float menorkm = 0;
            bool bmenorkm = true;
            do
            {
                Console.WriteLine("Ingrese el numero de camion");
                numeroCamion = int.Parse(Console.ReadLine());
                if (numeroCamion > 0)
                {


                    vNumeroCamion[numeroCamion] = numeroCamion;



                    Console.WriteLine("Ingrese el Numero de Tarifa");
                    numTarifa = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese los km recorridos");
                    kmRecorrido = float.Parse(Console.ReadLine());
                    if(bmenorkm)
                    {
                        menorCamion = numeroCamion;
                        menorkm = kmRecorrido;
                        bmenorkm = false;
                    }
                    else if(kmRecorrido < menorkm)
                    {
                        menorCamion = numeroCamion;
                        menorkm = kmRecorrido;
                    }


                    Puntoa(ref numTarifa, ref numeroTarifa, ref kmRecorrido, ref importeKm, ref acu, ref numeroCamion, ref vNumeroCamion, ref acuCamion);
                }

            } while (numeroCamion > 0);

            Console.WriteLine("El total recaudado por cada tarifa es de: ");
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine(numeroTarifa[x] + " " + acu[x]);

            }
            Console.WriteLine("Numero de Camion " + "      " + " Total recaudado");

            Puntob(ref vNumeroCamion, ref acuCamion);

            for (int x = 1; x < 20; x++)
            {

                if (acuCamion[x] != 0)
                {
                    Console.WriteLine(vNumeroCamion[x] + "           " + acuCamion[x]);
                }
            }

            Console.WriteLine("El camion que recorrio menos kilometros fue: " + menorCamion);


        }
        static void Puntoa(ref int numTarifa, ref int[] numeroTarifa, ref float kmRecorrido, ref float[] importeKm, ref float[] acu, ref int numerocamion, ref int[] vNumeroCamion, ref float[] VacuCamion)
        {
            bool vacuC = true;
            for (int x = 0; x < 20; x++)
            {
                if (numTarifa == numeroTarifa[x])
                {
                    acu[x] += kmRecorrido * importeKm[x];
                }

                if (vacuC)
                {
                    VacuCamion[numerocamion] += kmRecorrido * importeKm[x];
                    vacuC = false;
                }
            }
                
        }













        static void Puntob(ref int[] vNumeroCamion, ref float[] acuCamion)
        {
            float auxiliar;
            int auxiliar2;
            for (int x = 1; x < 19; x++)
            {
                if (acuCamion[x] < acuCamion[x + 1])
                {
                    auxiliar = acuCamion[x];
                    acuCamion[x] = acuCamion[x + 1];
                    acuCamion[x + 1] = auxiliar;
                    auxiliar2 = vNumeroCamion[x];
                    vNumeroCamion[x] = vNumeroCamion[x + 1];
                    vNumeroCamion[x + 1] = auxiliar2;
                }

            }
        }
        

    }
   

}


            
            
            
            

           
