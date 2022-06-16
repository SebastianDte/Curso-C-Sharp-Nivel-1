using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar los kilómetros existentes entre dos
            //ciudades y la velocidad promedio de un vehículo.Calcular y emitir por pantalla
            //el tiempo aproximado que demandará llegar de un punto a otro teniendo en
            //cuenta los datos ingresados.

            int Kme, Velocidad;
            double Tiempo;

            Console.WriteLine("Ingrese los km entre las ciudades");
            Kme = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad promedio");
            Velocidad = int.Parse(Console.ReadLine());
            Tiempo = Kme / Velocidad;
            Console.WriteLine("El tiempo estimado de viaje es de: " + Tiempo + "Hs");
            Console.ReadKey();


        }
    }
}
