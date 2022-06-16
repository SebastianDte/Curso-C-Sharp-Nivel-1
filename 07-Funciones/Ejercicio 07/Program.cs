using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función de tipo void(porque no va a devolver nada) llamada
            //“positivoNegativoCero” que reciba un número por valor y una variable por
            //referencia.Que analice el número y escriba variable recibida por referencia
            //con:
            //            a. 1 si el número es positivo.
            //            b. - 1 si el número es negativo.
            //             c. 0 si el número es cero.
            //Hacer un programa main que permita ingresar 100 números y emitir por
            //pantalla cuántos son positivos, cuántos negativos y cuántos cero.
            



           int n1, n2 = 0, postivo = 0, negativo = 0, cero = 0;

            for (int x = 0; x < 100; x++)
            {
                Console.WriteLine("Ingrese un numero");
                n1 = int.Parse(Console.ReadLine());
                PositivoNegativoCero(n1, ref n2);
                if (n2 == 1)
                postivo++; 
                else if (n2 == -1)
                 negativo++; 
                else if(n2 == 0)
                 cero++; 
            }
            Console.WriteLine("Hay " + postivo + " postivos");
            Console.WriteLine("Hay " + negativo + " negativo");
            Console.WriteLine("Hay " + cero + " cero");
            Console.ReadKey();

        }
        static void PositivoNegativoCero(int a, ref int b)
        {
            if (a > 0)
                b = 1;
            else if (a < 0)
                b = -1;
            else if (a == 0)
                b = 0;
            
        }
    }
            
}










