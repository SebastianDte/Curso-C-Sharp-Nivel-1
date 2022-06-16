using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Hacer un programa que solicite una lista de números que corta cuando se
            //    ingresa un cero y luego emitir por pantalla el máximo de los números
            //    negativos y el mínimo de los números positivos.

            bool bn = true,bp = true;
            int n,mn = 0,mp = 0;
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());


            while (n != 0)
            {
                if(n < 0){
                    if(bn ){
                        mn = n;
                        bn = false;
                    }else{if(n < mn)
                        mn = n;}
                }else{if(bp){
                    mp=n;
                    bp = false;
                    }else{if(n < mp)
                    mp = n;}
                    }


            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" El maximo de los numeros negativos es: " + mn + " Y el minimo de los numeros positivos es: " + mp);
            Console.ReadKey();



        }
    }
}
