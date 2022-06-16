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
            //Una empresa registró las compras realizadas a sus distintos proveedores durante
            //todo el año anterior.Para cadacompra se registraron los siguientes datos:
            //• Número de proveedor(número de cuatro cifras no correlativo).
            //• Día(1 a 31).
            //• Mes(1 a 12).
            //maxiprograma.com
            //3
            //• Tipo de Factura(Responsable inscripto: "A", Consumidor Final: "B", o
            //Monotributo: "C").
            //• Número de Producto(número no correlativo).
            //• Cantidad comprada.
            //• Precio unitario del producto.
            //Este lote finaliza con un registro con número de proveedor igual a 0.
            //Los registros están agrupados por número de proveedor. En el lote anterior no
            //aparecen
            //registros de los proveedores a los que que no se les hayan realizado compras.
            //Se pide determinar e informar:
            //            a.El monto máximo registrado en una sola compra por cada proveedor y el
            //           número de proveedor al que se le compró.
            //           b.La inversión total de todo el año discriminada por tipo de factura.
            //c.La compra con menor monto registrada durante el mes de Agosto junto al
            //número de producto comprado.
            //d.La cantidad de compras que se realizaron a cada proveedor.
            //e.El número de producto con mayor cantidad comprada en una sola compra y
            //en qué proveedor se compró.


            int numProveedor, dia, mes, numProducto = 0, cantComprada, precioUniProduct, maxCompra = 0, productoMayor = 0;
            int numProveedorAct, proveedorPos = 0, menorMonto = 0, numAgos = 0;
            bool bMaxCompra = true, bmenorMonto = true;
            char tipoFactura, a = 'A', b = 'B' ,c = 'C';
            int tipoA = 0 , tipoB = 0 , tipoC = 0;





            Console.WriteLine("Ingrese el numero del proveedor");
            numProveedor = int.Parse(Console.ReadLine());




            while (numProveedor != 0)
            {
                Console.WriteLine("Ingre el Dia");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Mes");
                mes = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Tipo de Factura");
                Console.WriteLine("Responsable inscripto: A,Consumidor Final: B, o Monotributo: C");
                tipoFactura = char.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad comprada");
                cantComprada = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el precio unitario del producto");
                precioUniProduct = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el numero del producto");
                numProducto = int.Parse(Console.ReadLine());
                numProveedorAct = numProveedor;
                
               
                while (numProveedor == numProveedorAct && numProducto != 0)
                {
                    
                    
                    
                    switch (tipoFactura)
                    {
                        case 'A':
                            tipoA = cantComprada * precioUniProduct;
                            a = tipoFactura;
                            break;
                            case 'B':
                                tipoB = cantComprada * precioUniProduct;
                            b = tipoFactura;
                            break ;
                            case 'C':
                                tipoC = cantComprada * precioUniProduct;
                            c = tipoFactura;
                            break;

                        default:
                            break;
                    }

                    if(mes == 8 )
                    {
                        if(bmenorMonto)
                        {
                            menorMonto = cantComprada * precioUniProduct;
                            bmenorMonto = false;
                            numAgos = numProducto;
                        }
                        else
                        {
                            if ( cantComprada * precioUniProduct < menorMonto)
                                menorMonto = cantComprada * precioUniProduct;
                                numAgos = numProducto;
                        }
                    }
                        
                    
                    
                    if (bMaxCompra)

                    {
                        maxCompra = cantComprada * precioUniProduct;
                        proveedorPos = numProveedor;
                        productoMayor = numProducto;
                        bMaxCompra = false;
                        
                    }
                    else
                    {
                        int acuCompra = cantComprada * precioUniProduct;
                        
                        if (acuCompra > maxCompra)
                        {
                            maxCompra = acuCompra;
                            proveedorPos = numProveedor;
                            productoMayor = numProducto;
                            
                        }
                    }

                        Console.WriteLine("Ingrese el numero del proveedor");
                        numProveedor = int.Parse(Console.ReadLine());
                    if(numProveedor != 0 && numProveedor == numProveedorAct)
                    {
                        Console.WriteLine("Ingre el Dia");
                        dia = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el Mes");
                        mes = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el Tipo de Factura");
                        Console.WriteLine("Responsable inscripto: A,Consumidor Final: B, o Monotributo: C");

                        tipoFactura = char.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el numero del producto");
                        numProducto = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la cantidad comprada");
                        cantComprada = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el precio unitario del producto");
                        precioUniProduct = int.Parse(Console.ReadLine());

                    }
                    Console.WriteLine("La cantidad de compras en el proveedor " + numProveedorAct + " fue de: " + cantComprada);


                }
            }
                Console.WriteLine("El monto máximo registrado en una sola compra fue de: " + maxCompra + " Proveedor: " + proveedorPos);
                Console.WriteLine("La inversion total del año fue de: " + tipoA + a + " " + tipoB + b + " " + tipoC + c + " ");
                Console.WriteLine("La compra con menor monto en agosto fue de : " + "$" + menorMonto + " Numero de prodcuto: " + numProducto);
            Console.WriteLine("El numero de producto con mayor cantidad comprada fue: " + productoMayor + "En el proveedor: " + proveedorPos);
            
                Console.ReadKey();
                














        }
    }
}
