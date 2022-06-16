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
            //1.Se dispone de una lista de 10 grupos de números enteros separados entre ellos
            //      por ceros.Se pide determinar e informar:
            //   a.El número de grupo con mayor porcentaje de números impares
            //      positivos respecto al total de números que forman el grupo.
            //   b.Para cada grupo, el último número primo y en qué orden apareció en
            //      ese grupo. Si en un grupo no hubiera números primos, informarlo con
            //      un cartel aclaratorio.
            //   c.Informar cuántos grupos están formados por todos números ordenados
            //      de mayor a menor.




            int posI = 0, maxI = 0, contadorGrupo = 0;
            bool impar = true;


            for (int x = 0; x < 10; x++)
            {
                int contadorImpares = 0, porcentajeImp = 0, acuNumI = 0;
                int n;
                int numPrimo = 0, posicionPrimos = 0, mayor = 0; ;

                bool bMayor = true, bGrupo = true;

                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());

                while (n != 0)
                {
                    int contadorprimos = 0;
                    acuNumI++;

                    if (n > 0 && n % 2 != 0)
                    {
                        contadorImpares++;
                    }
                    for (int i = 1; i <= n; i++)
                    {
                        if (n % i == 0)
                            contadorprimos++;
                    }
                    if (contadorprimos == 2)
                    {
                        posicionPrimos++;
                        numPrimo = n;

                    }



                    if (bMayor)
                    {
                        mayor = n;
                        bMayor = false;
                    }
                    else
                    {
                        if (mayor > n)
                        {
                            mayor = n;

                        }
                        else
                            bGrupo = false;
                    }

                    Console.WriteLine("Ingrese un numero");
                    n = int.Parse(Console.ReadLine());
                }

                porcentajeImp = contadorImpares * 100 / acuNumI;
                if (impar)
                {
                    maxI = porcentajeImp;
                    posI = x;
                    impar = false;
                }
                else
                {
                    if (porcentajeImp > maxI)
                    {
                        maxI = porcentajeImp;
                        posI = x;
                    }
                }
                if (posicionPrimos != 0)
                {
                    Console.WriteLine(" El ultimo numero primo ingresado en el grupo fue: " + numPrimo + " En la posicion: " + posicionPrimos);
                }
                else
                    Console.WriteLine("No hay numeros primos en este grupo");
                if (bGrupo)
                {
                    contadorGrupo++;

                }

            }
            posI++;
            Console.WriteLine("La posicion del grupo con mayor cantidad de numeros impares es:" + posI);
            Console.WriteLine("Hay " + contadorGrupo + " Grupo ordenado de mmayor a menor");

            Console.ReadKey();
        }
    }
}
