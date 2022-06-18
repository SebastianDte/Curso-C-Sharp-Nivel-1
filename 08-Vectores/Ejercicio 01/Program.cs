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
            //Hacer un programa que solicite 50 números enteros y los guarde en un vector.
            //Luego recorrer el vector y determinar e informar cuál es la suma de los valores
            //del mismo.
            //Nota: usar dos ciclos: uno para guardar los números en el vector y otro para
            //recorrerlo y leerlo.

            int[] n = new int[50];
            int num ,suma = 0;
            for (int x = 0; x < 50
                ; x++)
            {

                Console.WriteLine("Ingrese un numero");
                num = int.Parse(Console.ReadLine());
                n[x] = num;

                
            }
            for (int x = 0; x < 50; x++)
            {

                suma += n[x];
            }
            Console.WriteLine("La suma de los numeros en el vector es de: " + suma);

            Console.ReadKey();
        }
    }
}
