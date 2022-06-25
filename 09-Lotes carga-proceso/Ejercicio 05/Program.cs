using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Una empresa de alquiler de autos cuenta con distintas agencias desde donde efectúa sus
            //operaciones.Para ello cuenta con varios lotes de registros. Un primer lote contiene los datos de los
            //autos, cada registro está compuesto por:
            //            -Código de auto(4 dígitos no correlativos).
            //-Categoría del auto(1 a 10).
            //-Importe del alquiler por km.
            //-Número de agencia(1 a 20).
            //Este lote se encuentra ordenado por código de auto y contiene 400 registros.
            //Existe un segundo lote con la información de los alquileres que se realizaron durante el mes pasado.
            //Cada registro contiene:
            //            -Código de auto(4 dígitos no correlativos).
            //-Número de cliente que efectúo el alquiler(1 a 200).
            //-Total de días del alquiler.
            //-Kms.Recorridos.
            //Este lote finaliza con un registro con número de cliente igual a cero.Puede haber más de un registro
            //para el mismo auto y para el mismo cliente.
            //Por último, un tercer lote contiene los datos de las agencias de esta empresa.
            //                - Número de agencia(1 a 20).
            //-Ubicación de la agencia(1 = Aeropuerto Ezeiza, 2 = Aeroparque, 3 = Centro Ciudad).
            //A partir de estos lotes se pide determinar e informar:
            //a) Un listado con el siguiente formato:
            //  Número de Cliente     Total de pesos abonados en alquiler
            //  999                        999
            //b) La recaudación total acumulada para cada una de las tres ubicaciones.
            //c) La cantidad total de autos para cada una de las veinte agencias.
            //d) La categoría de auto más veces alquilada por los clientes.
            //e) Los números de las agencias, si las hubiera, que hayan efectuado en el mes menos de diez
            //alquileres en total. Para calcular el importe del alquiler de un auto se debe multiplicar el
            //importe en pesos por kilómetro por la cantidad de kilómetros recorridos.
        }
    }
}
