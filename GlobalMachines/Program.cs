using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalMachineSinObjetos
{
    class Program
    {
        static int option = 0;
        static int i = 0;
        static int size = 3;

        static int totalFrituras = 0;
        static int totalReposteria = 0;
        static int totalGaseosos = 0;
        static int totalNaturales = 0;
        static int totalConfiteria = 0;
        static int nivel1, nivel2, nivel3, nivel4, nivel5 = 0;

        struct product
        {
            public int codigo_articulo;
            public string nombre_articulo;
            public string tipo;
            public string fecha_vencimiento;
            public string nombre_proveedor;
            public int posicion_estante;
            public double precio;
        };

        static product[] products;

        static void AddProducts()
        {
            int r = 0;
            while (r != 1)
            {
                Console.Clear();
                if (i < products.Length)
                {
                    Console.WriteLine("*-*   Global Machines  *-*");
                    Console.WriteLine("Ingreso de Productos.             ");
                    Console.Write("Digite el Codigo del Producto:                  ");
                    products[i].codigo_articulo = int.Parse(Console.ReadLine());
                    Console.Write("Digite el Nombre del Producto:    ");
                    products[i].nombre_articulo = Console.ReadLine();
                    Console.WriteLine("Frituras - Reposteria - Gaseosos - Naturales - Confiteria");
                    Console.WriteLine("Seleccione el tipo del Producto:");
                    products[i].tipo = Console.ReadLine();
                    if (products[i].tipo == "frituras" || products[i].tipo == "FRITURAS")
                    {
                        totalFrituras = totalFrituras + 1;
                    }
                    else if (products[i].tipo == "reposteria" || products[i].tipo == "REPOSTERIA")
                    {
                        totalReposteria = totalReposteria + 1;
                    }
                    else if (products[i].tipo == "gaseosos" || products[i].tipo == "GASEOSOS")
                    {
                        totalGaseosos = totalGaseosos + 1;
                    }
                    else if (products[i].tipo == "naturales" || products[i].tipo == "NATURALES")
                    {
                        totalNaturales = totalNaturales + 1;
                    }
                    else if (products[i].tipo == "confiteria" || products[i].tipo == "CONFITERIA")
                    {
                        totalConfiteria = totalConfiteria + 1;
                    }
                    else
                    {
                        Console.WriteLine("Clasificacion Invalida");
                    }
                    Console.Write("Digite la Fecha de vencimiento del Producto: ");
                    products[i].fecha_vencimiento = Console.ReadLine();
                    Console.Write("Digite el proveedor del Producto: ");
                    products[i].nombre_proveedor = Console.ReadLine();
                    Console.Write("Digite la Posicion en el estante: (1 2 3 4 5)");
                    products[i].posicion_estante = int.Parse(Console.ReadLine());
                    if (products[i].posicion_estante == 1)
                    {
                        nivel1 = nivel1 + 1;
                    }
                    else if (products[i].posicion_estante == 2)
                    {
                        nivel2 = nivel2 + 1;
                    }
                    else if (products[i].posicion_estante == 3)
                    {
                        nivel3 = nivel3 + 1;
                    }
                    else if (products[i].posicion_estante == 4)
                    {
                        nivel4 = nivel4 + 1;
                    }
                    else
                    {
                        nivel5 = nivel5 + 1;
                    }
                    Console.WriteLine("Seleccione el precio del Producto:");
                    products[i].precio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Desea agregar otro Producto 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("Registro de Productos lleno..");
                    r = 1;
                    Console.ReadKey();
                }
            }

        }
        static void ModifyProducts()
        {
            int ID = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.WriteLine("*-*   Global Machines  *-*");
                Console.WriteLine("Modificacion de productos.             ");
                Console.WriteLine("Digite el codigo del articulo a modificar");
                ID = int.Parse(Console.ReadLine());
                for (i = 0; i < products.Length; i++)
                {
                    if (ID == products[i].codigo_articulo)
                    {
                        reg = i + 1;
                        Console.Write("Digite el nombre del articulo:    ");
                        products[i].nombre_articulo = Console.ReadLine();
                        Console.Write("Digite el nombre del proveedor:    ");
                        products[i].nombre_proveedor = Console.ReadLine();
                        Console.Write("Digite el precio del articulo:     ");
                        products[i].precio = int.Parse(Console.ReadLine());
                        Console.Write("Digite la fecha de vencimiento:     ");
                        products[i].fecha_vencimiento = Console.ReadLine();
                        Console.Write("Digite el tipo de articulo:    ");
                        products[i].tipo = Console.ReadLine();
                        if (products[i].tipo == "frituras" || products[i].tipo == "FRITURAS")
                        {
                            totalFrituras = totalFrituras + 1;
                        }
                        else if (products[i].tipo == "reposteria" || products[i].tipo == "REPOSTERIA")
                        {
                            totalReposteria = totalReposteria + 1;
                        }
                        else if (products[i].tipo == "gaseosos" || products[i].tipo == "GASEOSOS")
                        {
                            totalGaseosos = totalGaseosos + 1;
                        }
                        else if (products[i].tipo == "naturales" || products[i].tipo == "NATURALES")
                        {
                            totalNaturales = totalNaturales + 1;
                        }
                        else if (products[i].tipo == "confiteria" || products[i].tipo == "CONFITERIA")
                        {
                            totalConfiteria = totalConfiteria + 1;
                        }
                        else
                        {
                            Console.WriteLine("Clasificacion Invalida");
                        }
                        Console.Write("Digite el nivel donde esta el articulo:     ");
                        products[i].posicion_estante = int.Parse(Console.ReadLine());

                        if (products[i].posicion_estante == 1)
                        {
                            nivel1 = nivel1 + 1;
                        }
                        else if (products[i].posicion_estante == 2)
                        {
                            nivel2 = nivel2 + 1;
                        }
                        else if (products[i].posicion_estante == 3)
                        {
                            nivel3 = nivel3 + 1;
                        }
                        else if (products[i].posicion_estante == 4)
                        {
                            nivel4 = nivel4 + 1;
                        }
                        else
                        {
                            nivel5 = nivel5 + 1;
                        }
                        Console.WriteLine("Seleccione el precio del Producto:");
                        products[i].precio = double.Parse(Console.ReadLine());
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                else
                {
                    Console.WriteLine("Desea modificar otro Producto 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                }
            }
        }
        static void DeleteProducts()
        {
            int codigo_articulo = 0;
            int resp = 0;
            bool found = false;
            while (resp != 1)
            {
                Console.Clear();
                Console.WriteLine("*-*   Global Machines  *-*");
                Console.WriteLine("Eliminado de Productos");
                Console.WriteLine("Digite el Codigo del Producto a Eliminar");
                codigo_articulo = int.Parse(Console.ReadLine());
                for (i = 0; i < products.Length; i++)
                {
                    if (products[i].codigo_articulo == codigo_articulo)
                    {
                        products[i].codigo_articulo = 0;
                        products[i].nombre_articulo = "";
                        products[i].nombre_proveedor = "";
                        products[i].tipo = "";
                        products[i].fecha_vencimiento = "";
                        products[i].posicion_estante = 0;
                        products[i].precio = 0;
                        found = true;
                    }
                    if (!found)
                    {
                        Console.WriteLine("No se encontro ese Codigo");
                        found = false;
                    }

                }
                Console.WriteLine("Desea Eliminar otro Producto 0-Sí 1-No");
                resp = int.Parse(Console.ReadLine());
            }
        }
        static void SeekProducts()
        {

            int codigo_articulo = 0;
            int registro = 0;
            int resp = 0;
            bool found = false;
            while (resp != 1)
            {
                Console.Clear();
                Console.WriteLine("*-* Global Machines  *-*");
                Console.WriteLine("Busqueda de Productos.           ");
                Console.WriteLine("Digite el codigo del Producto a buscar");
                codigo_articulo = int.Parse(Console.ReadLine());
                for (i = 0; i < products.Length; i++)
                {
                    if (codigo_articulo == products[i].codigo_articulo)
                    {
                        registro = i + 1;
                        Console.WriteLine("Registro: " + registro);
                        Console.WriteLine("Codigo del Producto:         " + products[i].codigo_articulo);
                        Console.WriteLine("Nombre del producto:         " + products[i].nombre_articulo);
                        Console.WriteLine("Tipo del producto:           " + products[i].tipo);
                        Console.WriteLine("Vencimiento del producto:    " + products[i].fecha_vencimiento);
                        Console.WriteLine("Proveedor:                   " + products[i].nombre_proveedor);
                        Console.WriteLine("Posicion del producto:       " + products[i].posicion_estante);
                        Console.WriteLine("Precio:                      " + products[i].precio);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese Codigo");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro Producto 0-Sí 1-No");
                resp = int.Parse(Console.ReadLine());
            }
        }
        static void ShowProducts()
        {
            int reg = 0;
            Console.Clear();
            Console.Clear();
            Console.WriteLine("===================================================================");
            Console.WriteLine("*-*                  *-*  Global Machines  *-*                  *-*");
            Console.WriteLine("===================================================================");
            Console.WriteLine("*-*                    Listado de Articulos                     *-*");
            Console.WriteLine("===================================================================");
            Console.WriteLine("Reg\tID\tNombre\tTipo\tVence\tProveedor\tPosicion\tPrecio");
            Console.WriteLine("-------------------------------------------------------------------");
            for (i = 0; i < products.Length; i++)
            {
                reg = i + 1;
                Console.Write(reg);
                Console.Write("\t" + products[i].codigo_articulo);
                Console.Write("\t" + products[i].nombre_articulo);
                Console.Write("\t" + products[i].tipo);
                Console.Write("\t" + products[i].fecha_vencimiento);
                Console.Write("\t" + products[i].nombre_proveedor);
                Console.Write("\t" + products[i].posicion_estante);
                Console.WriteLine("\t" + products[i].precio);

            }
            Console.WriteLine("Fin del Listado...\n\n");
            Console.WriteLine("                  Global Machines  ");
            Console.WriteLine("=====================================================");
            Console.WriteLine("                  Listado de Productos             ");
            Console.WriteLine("=====================================================");
            Console.Write("Clasificacion          ||           Cantidad\n");
            Console.Write("Frituras               ||          " + totalFrituras + "\n");
            Console.Write("Reposteria             ||          " + totalReposteria + "\n");
            Console.Write("Confiteria             ||          " + totalConfiteria + "\n");
            Console.Write("Refrescos Gaseosos     ||          " + totalGaseosos + "\n");
            Console.Write("Refrescos Naturales    ||          " + totalNaturales + "\n");
            Console.Write("Nivel                  ||           Cantidad\n");
            Console.Write("1                      ||          " + nivel1 + "\n");
            Console.Write("2                      ||          " + nivel2 + "\n");
            Console.Write("3                      ||          " + nivel3 + "\n");
            Console.Write("4                      ||          " + nivel4 + "\n");
            Console.Write("5                      ||          " + nivel5 + "\n");
            Console.Write("========================================================\n");
            Console.Write("Fin del Listado...");


            Console.ReadKey();
        }
        static void SellProducts()
        {
            int numero_telef = 0;
            string nombre_cliente = "";
            int desc = 0;
            int imprimir, monto = 0;
            int r, resp = 0;
            int cantidad = 0;
            double total = 0.0;
            double subtotal = 0.0;
            double totalcompra, impuvent, vuelto = 0;
            while (resp != 1)
            {
                Console.Clear();
                if (i < products.Length)
                {
                    Console.WriteLine("*-* Global Machine *-*");
                    Console.WriteLine("--Venta de Productos--");
                    Console.WriteLine("Digite el nombre del cliente: ");
                    nombre_cliente = Console.ReadLine();
                    Console.WriteLine("Digite el telefono del cliente: ");
                    numero_telef = int.Parse(Console.ReadLine());
                    Console.WriteLine("Seleccione el Codigo de producto que desee: ");
                    products[i].codigo_articulo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Seleccione la Cantidad que desea: ");
                    cantidad = int.Parse(Console.ReadLine());
                    subtotal = products[i].precio * cantidad;
                    total = subtotal + total;
                    Console.WriteLine("Desea agregar otro Producto 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());

                    //haciendo calculos
                    impuvent = total * 0.13;
                    totalcompra = total - impuvent;
                    vuelto = monto - totalcompra;

                    Console.WriteLine("Con que monto desea cancelar: ");
                    monto = int.Parse(Console.ReadLine());
                    if (monto < total)
                    {
                        Console.WriteLine("Disculpe el monto no es suficiente, digite otra cantidad");
                    }

                    Console.WriteLine("============================================");
                    Console.WriteLine("          ** Global Machine  **");
                    Console.WriteLine("============================================");
                    Console.WriteLine("Factura Proforma Nro: 0001");
                    Console.WriteLine("Cliente:" + nombre_cliente);
                    Console.WriteLine("Telefono: " + numero_telef);
                    Console.WriteLine("____________________________________________");
                    Console.WriteLine("Item\tCtd\tPrecio Unit");
                    Console.Write(products[i].nombre_articulo + "\t" + cantidad + "\t" + products[i].precio + "\t");
                    Console.WriteLine("============================================");
                    Console.WriteLine("Total Orden:                             " + totalcompra);
                    Console.WriteLine("Descuento:                               " + desc);
                    Console.WriteLine("Impuesto de Venta:                       " + impuvent);
                    Console.WriteLine("Precio Neto:                             " + total);
                    Console.WriteLine("____________________________________________");
                    Console.WriteLine("Monto Recibido:                          " + monto);
                    Console.WriteLine("Monto Cambio:                            " + vuelto);
                    Console.WriteLine("____________________________________________");
                    Console.WriteLine("Gracias Por su compra...");

                    i++;
                }


                Console.WriteLine("Desea Imprimir en archivo:\n0-Si\n1-No");
                imprimir = int.Parse(Console.ReadLine());
                if (imprimir == 0)
                { PrintInvoice(); }

                Console.WriteLine("Desea Continuar en el menu:\n0-Si\n1-No");
                resp = int.Parse(Console.ReadLine());
                if (resp == 0)
                { PrintInvoice(); }
            }
        }

        static void PrintInvoice()
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            Console.WriteLine(currentPath + @"\Invoice.txt");

            StreamWriter sw = new StreamWriter(currentPath + @"\Invoice.txt");
            //Imprimiendo la factura
            // ShowArt();
            sw.WriteLine("===================================================================");
            sw.WriteLine("*-*                       Global Machines                       *-*");
            sw.WriteLine("===================================================================");
            sw.WriteLine("*-*                    Listado de Articulos                     *-*");
            sw.WriteLine("===================================================================");

            sw.Write(" Gracias por comprar con nosotros...");
            sw.Close();
        }

        static void Main(string[] args)
        {
            products = new product[size];
            do
            {
                Console.Clear();
                Console.WriteLine("*-* Global Machines  *-*");
                Console.WriteLine("1. Ingreso de productos.");
                Console.WriteLine("2. Modificación de productos.");
                Console.WriteLine("3. Eliminación de productos.");
                Console.WriteLine("4. Búsquedad de productos.");
                Console.WriteLine("5. Listado de productos.");
                Console.WriteLine("6. Venta de productos.");
                Console.WriteLine("7. Salir.");
                Console.WriteLine("Seleccione una opción");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            AddProducts();
                            break;
                        }
                    case 2:
                        {
                            ModifyProducts();
                            break;
                        }
                    case 3:
                        {
                            DeleteProducts();
                            break;
                        }
                    case 4:
                        {
                            SeekProducts();
                            break;
                        }
                    case 5:
                        {
                            ShowProducts();
                            break;
                        }
                    case 6:
                        {
                            SellProducts();
                            break;
                        }
                    case 7:
                        //Salir
                        break;
                    default:
                        {
                            Console.WriteLine("Seleccion no Valida...\n Selecione una opcion valida");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            } while (option != 7);
        }
    }
}