﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Un importante negocio de desinfectante líquido realiza descuentos
            //dependiendo de la cantidad de litros vendidos según la siguiente escala:
            //a.Si vende menos de 100 litros, no hay descuento.
            //b.Si vende entre 101 y 300 litros, el descuento es del 10 %.
            //c.Si vende entre 301 y 500 litros, el descuento es del 15 %.
            //d.Finalmente, si la venta es de más de 500 litros, el descuento es del 25 %.
            //Hacer un programa que solicite el ingreso del importe total de la venta y la
            //cantidad de litros vendidos y calcule y emita el importe con el descuento
            //aplicado.

            double litros, tv;
            Console.WriteLine("Ingre la cantidad de litros");
            litros = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el total vendido");
            tv = double.Parse(Console.ReadLine());

            if (litros > 500)
                tv = tv * 0.75;
            else if (litros > 300)
                tv = tv * 0.85;
            else if (litros > 100)
                tv = tv * 0.90;

            Console.WriteLine("El Importe total es de: " + tv);
            Console.ReadKey();
        }
    }
}
