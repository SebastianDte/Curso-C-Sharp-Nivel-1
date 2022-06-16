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
            //Hacer un programa que permita ingresar una lista de números que corta
            //cuando se ingresa un cero.A partir de dichos datos informar:
            //a.El mayor de los números pares.
            //b.La cantidad de números impares.
            //c.El menor de los números primos.
            //Hacer uso de las funciones anteriormente desarrolladas.




            int n , mayorPar = 0, contadorImpar = 0, menorPrimo = 0;
            bool ParoImpar, primerPar = true, primerMenor = true, bmenorPrimo;
            Console.WriteLine("ingrese un numero");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                ParoImpar = Pares(n);
                if(ParoImpar)
                {
                    if(primerPar)
                    {
                        mayorPar = n;
                        primerPar = false;
                    }
                    else
                    {
                        if (n > mayorPar)
                            mayorPar = n;
                    }
                }
                else
                {
                    contadorImpar++;
                }
                bmenorPrimo = Primos(n);
                if(bmenorPrimo)
                {
                    if (primerMenor)
                    {
                        menorPrimo = n;
                        primerMenor = false;
                    }
                    else
                    {
                        if (n < menorPrimo)
                        {
                            menorPrimo = n;
                        }
                    }

                }
               

                
                Console.WriteLine("ingrese un numero");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El maximo de los numeros pares es: " + mayorPar + " La cantidad de numeros impares es " + contadorImpar);
            Console.WriteLine("El menor primo ingresado fue: " + menorPrimo);
            Console.ReadKey();
                



        }

        static  bool Pares (int n1)
        {
            bool resultado ;
            if (n1 % 2 == 0)
                 resultado = true;
            else
                resultado = false;
            return resultado;
           
        }
        static bool Primos(int n1)
        {
            bool resultado = false;
            int contador = 0;

            for (int x = 1; x <= n1; x++)
            {
                if (n1 % x == 0) 
                    contador++;
            }
            if (contador == 2)
            {
                resultado = true;
            }
                return resultado;
        }
                    

                
                
                
                
    }
}
