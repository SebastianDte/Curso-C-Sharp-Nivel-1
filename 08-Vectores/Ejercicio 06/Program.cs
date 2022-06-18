using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dada una lista de 10 números, cargarlos en un vector. Luego detectar si en el
            //vector hay algún elemento repetido. De haberlo, indicarlo con un cartel
            //aclaratorio “Hay repetidos”, de lo contrario indicar “No hay repetidos”.
            //Pista: usar ciclos combinados.

            int[] n = new int[10];
            int num ;
            bool repetidos = false;

            
            
            
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero");
                num = int.Parse(Console.ReadLine());
                n[x] = num;
            

            }

            for (int i = 0; i < 10; i++)
            {
                
                for (int y = 0; y < 10; y++)
                {
                    if(n[i] == n[y] && i != y)
                        repetidos = true;
                }
            }
            
            if (repetidos)
            { Console.WriteLine("Hay repetidos"); }
            else
            { Console.WriteLine("No hay repetidos"); }
            Console.ReadKey();




            



        }
    }
}
