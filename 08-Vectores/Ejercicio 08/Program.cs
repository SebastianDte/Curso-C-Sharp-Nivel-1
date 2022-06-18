using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se ingresa una lista de 20 números en un vector. Se pide ordenar dichos
            //números en forma decreciente(de mayor a menor). Mostrar el listado
            //ordenado informando también la posición original de cada número en el
            //vector.
            //Pista: usar ciclos combinados.

            int [] n = new int[10];
            int [] posicion = new int[10];
            int num,aux;
            
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero");
                num = int.Parse(Console.ReadLine());
                n[x] = num;
                posicion[x] = num;
            }
            
            for (int x = 0; x < 10; x++)
            {
                for (int i = 0; i < 9; i++)
                {
                    if(n[i] < n[i + 1])
                    {
                        aux = n[i];
                        n[i] = n[i + 1];
                        n[i + 1] = aux;

                    }
                }
            }
            Console.WriteLine("Vector ordenado de forma decreciente:");
            Console.WriteLine(String.Join(",", n));
            Console.WriteLine("La posicion original de los numeros en el vector fue: ");
            Console.WriteLine(String.Join(",", posicion));
            Console.ReadKey();




        }
    }
}
