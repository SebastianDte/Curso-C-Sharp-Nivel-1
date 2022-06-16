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
            //Hacer una función que se llame “sumaResta” que reciba dos números y que
            //devuelva la suma Y la resta del primer número con el segundo.
            //Nota: recordemos que una función solo puede devolver UN valor por return.
            //Cómo podríamos hacer para tener ambos resultados en el main?

            int n1, n2, resultado;
            Console.WriteLine("ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            n2 = int.Parse(Console.ReadLine());

            resultado = sumaresta(n1,ref n2);
            Console.WriteLine("El resultado de la suma es: " + resultado + " Y la resta: " + n2);
            Console.ReadKey();

        }

        static int sumaresta(int n4, ref int n3)
        {
            int resultadosuma;
            resultadosuma = n4 + n3;
            n3 = n4 - n3;
            return resultadosuma;


        }
    }
}
