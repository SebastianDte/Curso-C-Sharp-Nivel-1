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
            //Hacer un programa para ingresar los valores de los pesos de distintas
            //encomiendas que se deben enviar a distintos clientes y que finaliza cuando se
            //ingresa un peso negativo.Se deben agrupar las encomiendas en camiones que
            //pueden transportar hasta 200 kilos en total.
            //Por ejemplo:
            //10, 20, 140, 70, 100, 40, 10, 50, 80, 90, 30, 40, 50, -10.
            //Camión 1.Camión 2 Camión 3 Camión 4 Camión 5
            //Se pide determinar e informar:
            //            a.El número de camión y peso total de encomiendas(Camión 1: 170kg,
            //           Camión 2: 170kg, etc.).
            //           b.El número de camión que transporta mayor cantidad de encomiendas
            //          (en el ejemplo anterior sería el camión 3 con 4 encomiendas).
            //          c.La cantidad de camiones que se terminaron cargando.




            int peso, camion = 0, maximoCamion = 0, maximaEncomienda = 0;
            
            Console.WriteLine("Ingre el peso de la encomienda");
            peso = int.Parse(Console.ReadLine());

            while (peso > 0)
            {
                int acuPeso = 0, encomiendas = 0;
                camion++;
                while (peso + acuPeso <= 200 && peso  > 0)
                {
                    acuPeso += peso;
                    encomiendas++;
                    
                    Console.WriteLine("Ingre el peso de la encomienda");
                    peso = int.Parse(Console.ReadLine());
                }
                Console.WriteLine(" Camion " + camion + " peso " + acuPeso);
                if(encomiendas > maximaEncomienda)
                {
                    maximaEncomienda = encomiendas;
                    maximoCamion = camion;
                }
                
            }
            Console.WriteLine("El camion con mayor encomiendas es el numero: " + maximoCamion + " Con " + maximaEncomienda + " de encomiendas "); 
            Console.WriteLine("La cantidad de camiones cargados es de " + camion);

            Console.ReadKey();




           

            
        }














                
                
                
               


            
    }
}
