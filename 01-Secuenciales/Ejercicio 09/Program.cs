using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Una universidad desea conocer los porcentajes de mujeres y hombres en las
            //carreras de ciencias exactas. Se solicita un programa para cargar la cantidad de
            //mujeres y la cantidad de hombres y que el mismo calcule y emita por pantalla
            //los porcentajes correspondientes.

            int ch, cm, ct, ph, pm;

            Console.WriteLine("Ingrese la cantidad de hombres");
            ch = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de mujeres");
            cm = int.Parse(Console.ReadLine());
            ct = ch + cm;
            ph = ch * 100 / ct;
            pm = cm * 100 / ct;
            Console.WriteLine("El porcentaje de mujeres es de : " + pm + " Y el porcentaje de hombres es de: " + ph);
            Console.ReadKey();
        }
    }
}
