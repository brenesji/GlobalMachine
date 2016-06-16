using System;
using System.IO;
using System.Text;


namespace GlobalMachines
{
    class Program
    {
        static Productos Producto = new Productos();

        static int option = 0;
        static int size = 3;


        //[Flags]
        //enum BookPrice
        //{
        //    Bajo = 500,
        //    MedioBajo = 2500,
        //    Medio = 5000,
        //    MedioAlto = 7500,
        //    Alto = 10000,
        //};

        static void AddProducts()
        {
            //agregar libro
            int r = 0, i = 0;
            while (r != 1)
            {
                Console.Clear();
                if (i < Producto.size)
                {
                    Console.WriteLine("-* Bienvenido a Global Machine  *-*");
                    Console.WriteLine("Ingreso de Productos.             ");
                    Console.Write("Digite el ID:                  ");
                    Producto.SetCodigo(int.Parse(Console.ReadLine()));
                    Console.Write("Digite el Nombre del Producto:    ");
                    Producto.SetNombre(Console.ReadLine());
                    Console.Write("Digite el Tipo del Producto:     ");
                    Producto.SetTipo(Console.ReadLine());
                    Console.Write("Digite la fecha de Vencimiento del Producto:     ");
                    Producto.SetFecha(Console.ReadLine());
                    Console.Write("Digite el Nombre del Proveedor del Producto:     ");
                    Producto.SetProveedor(Console.ReadLine());
                    Console.Write("Digite la Posicion en el estante del Producto:     ");
                    Producto.SetPosicion(int.Parse(Console.ReadLine()));
                    Console.Write("Digite el Precio del Producto:     ");
                    Producto.SetPrecio(double.Parse(Console.ReadLine()));
   
                    if (Producto.AddData(Producto) == true)
                        Console.WriteLine("Producto agregado correctamente");
                    else
                        Console.WriteLine("Producto no agregado");
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

        static void ShowProducts()
        {
            //listar libros
            int reg = 0, i;
            Console.Clear();
            Console.WriteLine("-* Global Machines  *-*");
            Console.WriteLine("Listado de Productos.             ");
            for (i = 0; i < Producto.size; i++)
            {
                Producto.PrintData(i);
                reg = i + 1;
                Console.WriteLine("Registro:    " + reg);
                Console.WriteLine("ID:          " + Producto.GetCodigo());
                Console.WriteLine("Nombre:      " + Producto.GetNombre());
                Console.WriteLine("Tipo:        " + Producto.GetTipo());
                Console.WriteLine("Vencimiento: " + Producto.GetFecha());
                Console.WriteLine("Proveedor:   " + Producto.GetProveedor());
                Console.WriteLine("Nivel:       " + Producto.GetPosicion());
                Console.WriteLine("Precio:      " + Producto.GetPrecio());
                Console.WriteLine("************************************");

                /*Console.WriteLine("Auto:     " + );
                Console.WriteLine("Precio:   " + );*/
            }
            Console.ReadKey();
        }

        static void SeekProducts()
        {
            //buscar libro
            int ID = 0, reg = 0, r = 0;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("-* Global Machines  *-*");
                Console.WriteLine("Búsquedad de Productos.           ");
                Console.WriteLine("Digite el ID del Producto a buscar");
                ID = int.Parse(Console.ReadLine());
                if (Producto.SeekData(ID) == true)
                {
                    reg = ID;
                    Console.WriteLine("Registro1: " + reg);
                    Console.WriteLine("ID:       " + Producto.GetCodigo());
                    Console.WriteLine("Nombre:      " + Producto.GetNombre());
                    Console.WriteLine("Tipo:        " + Producto.GetTipo());
                    Console.WriteLine("Vencimiento: " + Producto.GetFecha());
                    Console.WriteLine("Proveedor:   " + Producto.GetProveedor());
                    Console.WriteLine("Nivel:       " + Producto.GetPosicion());
                    Console.WriteLine("Precio:      " + Producto.GetPrecio());
                    Console.WriteLine("************************************");

                    /*Console.WriteLine("Auto:     " + );
                    Console.WriteLine("Precio:   " + );*/
                }
                else
                    Console.WriteLine("No se encontro ese ID");
                Console.WriteLine("Desea buscar otro libro 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }

        static void ModifyProducts()
        {
            int ID = 0, reg = 0, r = 0;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("-* Global Machine  *-*");
                Console.WriteLine("Modificacion de Productos.           ");
                Console.WriteLine("Digite el ID del Producto a Modificar");
                ID = int.Parse(Console.ReadLine());

                Console.Write("Digite el Tipo del Producto:     ");
                Producto.SetTipo(Console.ReadLine());
                Console.Write("Digite la fecha de Vencimiento del Producto:     ");
                Producto.SetFecha(Console.ReadLine());
                Console.Write("Digite el Nombre del Proveedor del Producto:     ");
                Producto.SetProveedor(Console.ReadLine());
                Console.Write("Digite la Posicion en el estante del Producto:     ");
                Producto.SetPosicion(int.Parse(Console.ReadLine()));
                Console.Write("Digite el Precio del Producto:     ");
                Producto.SetPrecio(double.Parse(Console.ReadLine()));

                Producto.UpdateData(Producto, ID);
                r = 1;
            }

        }

        static void DeleteProducts()
        {
            //eliminar libro
            int ID, i = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("-* Global Machines  *-*");
                Console.WriteLine("Cual Producto desea eliminar.           ");
                Console.WriteLine("Digite el ID del libro a eliminar");
                ID = int.Parse(Console.ReadLine());
                for (i = 0; i < Producto.size; i++)
                {
                    Producto.DeleteData(Producto, ID);
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                Console.WriteLine("Desea eliminar otro libro 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }

        static void VentaProducts()
        {

            string CustomerName, CelPhone;
            int reg = 0, i;
            //int NumberOfBook1 = 0, NumberOfBook2 = 0, NumberOfBook3 = 0, NumberOfBook4 = 0, NumberOfBook5 = 0;
            //int NumberOfBook6 = 0, NumberOfBook7 = 0, NumberOfBook8 = 0, NumberOfBook9 = 0, NumberOfBook10 = 0;
            //double BookPrice1 = 0, BookPrice2 = 0, BookPrice3 = 0, BookPrice4 = 0, BookPrice5 = 0;
            //double BookPrice6 = 0, BookPrice7 = 0, BookPrice8 = 0, BookPrice9 = 0, BookPrice10 = 0;
            //double TotalDiscount = 0, TotalOrder = 0, TaxAmount = 0, SalesTotal = 0;
            //double AmountTended, Difference;
            Console.Clear();
            Console.WriteLine("*-* Global Machines *-*");
            Console.WriteLine("Ingrese la siguiente información");
            Console.Write("Nombre Cliente  : ");
            CustomerName = Console.ReadLine();
            Console.Write("Teléfono Cliente: ");
            CelPhone = Console.ReadLine();
            Console.WriteLine("\nDesglose de Productos");

            Console.WriteLine("Listado de Productos.             ");
            Console.WriteLine("Codigo \tNombre\tTipo\tFecha\tProveedor\tNivel\tPrecio");
            for (i = 0; i < Producto.size; i++)
            {
                Producto.PrintData(i);
                reg = i + 1;


                Console.Write(Producto.GetCodigo() + "\t" + Producto.GetNombre() + "\t" + Producto.GetTipo()
                    + "\t" + Producto.GetFecha() + "\t" + Producto.GetProveedor() + "\t" + Producto.GetPosicion()
                    + "\t" + Producto.GetPrecio());
                Console.ReadKey();
            }
        }

        //    Console.Write("\nMonto a Cancelar: ");
        //    Console.WriteLine("{0:N2}", SalesTotal);
        //    Console.Write("Monto Ahorro: ");
        //    Console.WriteLine("{0:N2}", TotalDiscount);
        //returnflag:
        //    Console.Write("Digite el Monto con que Cancela: ");
        //    AmountTended = double.Parse(Console.ReadLine());
        //    if (AmountTended >= SalesTotal)
        //        Difference = AmountTended - SalesTotal;
        //    else
        //    {
        //        Console.WriteLine("Monto insuficiente..Intente de nuevo por favor");
        //        goto returnflag;
        //    }
        //    Console.WriteLine("Presione Enter para Imprimir la Factura");
        //    Console.ReadKey();

        //    Imprimiendo la factura
        //    Console.Clear();
        //    Console.WriteLine("===================================================================");
        //    Console.WriteLine("*-*                  Librería El Buen Lector                    *-*");
        //    Console.WriteLine("===================================================================");
        //    Console.WriteLine(" Factura Proforma\t\t\t\t\t    N°0001");
        //    Console.Write(" Cliente : ");
        //    Console.WriteLine(CustomerName);
        //    Console.Write(" Teléfono: ");
        //    Console.WriteLine(CelPhone);
        //    Console.WriteLine("-------------------------------------------------------------------");
        //    Console.WriteLine(" Item\t\t\t\tCtd\tPrecio\t\tSubTotal");
        //    Console.WriteLine("-------------------------------------------------------------------");
        //    if (NumberOfBook1 > 0)
        //    {
        //        Console.Write(" El Señor de los anillos, las..");
        //        Console.Write("\t" + NumberOfBook1);
        //        Console.Write("\t¢{0:N2}", BookPrice1);
        //        Console.WriteLine("\t¢{0:N2}", NumberOfBook1 * BookPrice1);
        //    }
        //    if (NumberOfBook2 > 0)
        //    {


        //        Console.ReadKey();
        //    }

            //        Console.WriteLine("Nombre:      " + Producto.GetNombre());
            //        Console.WriteLine("Tipo:        " + Producto.GetTipo());
            //        Console.WriteLine("Vencimiento: " + Producto.GetFecha());
            //        Console.WriteLine("Proveedor:   " + Producto.GetProveedor());
            //        Console.WriteLine("Nivel:       " + Producto.GetPosicion());
            //        Console.WriteLine("Precio:      " + Producto.GetPrecio());
            //        Console.WriteLine("************************************");

            //        /*Console.WriteLine("Auto:     " + );
            //        Console.WriteLine("Precio:   " + );*/
            //    }
            //}
            //    Console.WriteLine("Libro \t\t\t\t\t\tCategoría\tCantidad");
            //    Console.Write("El Señor de los anillos, Las dos torres\t\tFantasía\t");
            //    NumberOfBook1 = int.Parse(Console.ReadLine());
            //    BookPrice1 = BookPriceMediumHigh;
            //    Console.Write("Alicia en el país de la Maravillas\t\tInfantil\t");
            //    NumberOfBook2 = int.Parse(Console.ReadLine());
            //    BookPrice2 = BookPriceMedium;
            //    Console.Write("Cementerio de Mascotas\t\t\t\tMisterio\t");
            //    NumberOfBook3 = int.Parse(Console.ReadLine());
            //    BookPrice3 = BookPriceMediumLow;
            //    Console.Write("Quiero aprender\t\t\t\t\tEducativo\t");
            //    NumberOfBook4 = int.Parse(Console.ReadLine());
            //    BookPrice4 = BookPriceLow;
            //    Console.Write("El poder del pensamiento Positivo\t\tSuperación\t");
            //    NumberOfBook5 = int.Parse(Console.ReadLine());
            //    BookPrice5 = BookPriceMedium;
            //    Console.Write("Mi primer libro de matemáticas\t\t\tEducativo\t");
            //    NumberOfBook6 = int.Parse(Console.ReadLine());
            //    BookPrice6 = BookPriceLow;
            //    Console.Write("Las aventuras de Tom Sawyer\t\t\tInfantil\t");
            //    NumberOfBook7 = int.Parse(Console.ReadLine());
            //    BookPrice7 = BookPriceMediumHigh;
            //    Console.Write("El mago de Oz\t\t\t\t\tFantasía\t");
            //    NumberOfBook8 = int.Parse(Console.ReadLine());
            //    BookPrice8 = BookPriceMediumLow;
            //    Console.Write("La zona muerta\t\t\t\t\tMisterio\t");
            //    NumberOfBook9 = int.Parse(Console.ReadLine());
            //    BookPrice9 = BookPriceHigh;
            //    Console.Write("Viaje al centro de la tierra\t\t\tCiencia ficción\t");
            //    NumberOfBook10 = int.Parse(Console.ReadLine());
            //    BookPrice10 = BookPriceHigh;

            //    //Ejecutando los cálculos
            //    TotalOrder = TotalOrder + NumberOfBook1 * BookPrice1;
            //    TotalDiscount = TotalDiscount + BookPrice1 * NumberOfBook1 * DiscountFantasy;
            //    TotalOrder += NumberOfBook2 * BookPrice2;
            //    TotalDiscount += BookPrice2 * NumberOfBook2 * DiscountChildren;
            //    TotalOrder += NumberOfBook3 * BookPrice3;
            //    TotalDiscount += BookPrice3 * NumberOfBook3 * DiscountMistery;
            //    TotalOrder += NumberOfBook4 * BookPrice4;
            //    TotalDiscount += BookPrice4 * NumberOfBook4 * DiscountEducational;
            //    TotalOrder += NumberOfBook5 * BookPrice5;
            //    TotalDiscount += BookPrice5 * NumberOfBook5 * DiscountOther;
            //    TotalOrder += NumberOfBook6 * BookPrice6;
            //    TotalDiscount += BookPrice6 * NumberOfBook6 * DiscountEducational;
            //    TotalOrder += NumberOfBook7 * BookPrice7;
            //    TotalDiscount += BookPrice7 * NumberOfBook7 * DiscountChildren;
            //    TotalOrder += NumberOfBook8 * BookPrice8;
            //    TotalDiscount += BookPrice8 * NumberOfBook8 * DiscountFantasy;
            //    TotalOrder += NumberOfBook9 * BookPrice9;
            //    TotalDiscount += BookPrice9 * NumberOfBook9 * DiscountMistery;
            //    TotalOrder += NumberOfBook10 * BookPrice10;
            //    TotalDiscount += BookPrice10 * NumberOfBook10 * DiscountOther;
            //    TaxAmount = (TotalOrder - TotalDiscount) * TaxRate;
            //    SalesTotal = TotalOrder - TotalDiscount + TaxAmount;

            //    //Haciendo el cobro
            //    Console.Write("\nMonto a Cancelar: ");
            //    Console.WriteLine("{0:N2}", SalesTotal);
            //    Console.Write("Monto Ahorro: ");
            //    Console.WriteLine("{0:N2}", TotalDiscount);
            //returnflag:
            //    Console.Write("Digite el Monto con que Cancela: ");
            //    AmountTended = double.Parse(Console.ReadLine());
            //    if (AmountTended >= SalesTotal)
            //        Difference = AmountTended - SalesTotal;
            //    else
            //    {
            //        Console.WriteLine("Monto insuficiente..Intente de nuevo por favor");
            //        goto returnflag;
            //    }
            //    Console.WriteLine("Presione Enter para Imprimir la Factura");
            //    Console.ReadKey();

            //    //Imprimiendo la factura
            //    Console.Clear();
            //    Console.WriteLine("===================================================================");
            //    Console.WriteLine("*-*                  Librería El Buen Lector                    *-*");
            //    Console.WriteLine("===================================================================");
            //    Console.WriteLine(" Factura Proforma\t\t\t\t\t    N°0001");
            //    Console.Write(" Cliente : ");
            //    Console.WriteLine(CustomerName);
            //    Console.Write(" Teléfono: ");
            //    Console.WriteLine(CelPhone);
            //    Console.WriteLine("-------------------------------------------------------------------");
            //    Console.WriteLine(" Item\t\t\t\tCtd\tPrecio\t\tSubTotal");
            //    Console.WriteLine("-------------------------------------------------------------------");
            //    if (NumberOfBook1 > 0)
            //    {
            //        Console.Write(" El Señor de los anillos, las..");
            //        Console.Write("\t" + NumberOfBook1);
            //        Console.Write("\t¢{0:N2}", BookPrice1);
            //        Console.WriteLine("\t¢{0:N2}", NumberOfBook1 * BookPrice1);
            //    }
            //    if (NumberOfBook2 > 0)
            //    {
            //        Console.Write(" Alicia en el país de las mar..");
            //        Console.Write("\t" + NumberOfBook2);
            //        Console.Write("\t¢{0:N2}", BookPrice2);
            //        Console.WriteLine("\t¢{0:N2}", NumberOfBook2 * BookPrice2);
            //    }
            //    if (NumberOfBook3 > 0)
            //    {
            //        Console.Write(" Cementerio de Mascotas   ");
            //        Console.Write("\t" + NumberOfBook3);
            //        Console.Write("\t¢{0:N2}", BookPrice3);
            //        Console.WriteLine("\t¢{0:N2}", NumberOfBook3 * BookPrice3);
            //    }
            //    if (NumberOfBook4 > 0)
            //    {
            //        Console.Write(" Quiero aprender          ");
            //        Console.Write("\t" + NumberOfBook4);
            //        Console.Write("\t¢{0:N2}", BookPrice4 + "   ");
            //        Console.WriteLine("\t¢{0:N2}", NumberOfBook4 * BookPrice4);
            //    }
            //    if (NumberOfBook5 > 0)
            //    {
            //        Console.Write(" El poder del pensamiento Pos..");
            //        Console.Write("\t" + NumberOfBook5);
            //        Console.Write("\t¢{0:N2}", BookPrice5);
            //        Console.WriteLine("\t¢{0:N2}", NumberOfBook5 * BookPrice5);
            //    }
            //    if (NumberOfBook6 > 0)
            //    {
            //        Console.Write(" Mi primer libro de matemátic..");
            //        Console.Write("\t" + NumberOfBook6);
            //        Console.Write("\t¢{0:N2}", BookPrice6 + "   ");
            //        Console.WriteLine("\t¢{0:N2}", NumberOfBook6 * BookPrice6);
            //    }
            //    if (NumberOfBook7 > 0)
            //    {
            //        Console.Write(" Las aventuras de Tom Sawyer");
            //        Console.Write("\t" + NumberOfBook7);
            //        Console.Write("\t¢{0:N2}", BookPrice7);
            //        Console.WriteLine("\t¢{0:N2}", NumberOfBook7 * BookPrice7);
            //    }
            //    if (NumberOfBook8 > 0)
            //    {
            //        Console.Write(" El mago de Oz            ");
            //        Console.Write("\t" + NumberOfBook8);
            //        Console.Write("\t¢{0:N2}", BookPrice8);
            //        Console.WriteLine("\t¢{0:N2}", NumberOfBook8 * BookPrice8);
            //    }
            //    if (NumberOfBook9 > 0)
            //    {
            //        Console.Write(" La zona muerta           ");
            //        Console.Write("\t" + NumberOfBook9);
            //        Console.Write("\t¢{0:N2}", BookPrice9);
            //        Console.WriteLine("\t¢{0:N2}", NumberOfBook9 * BookPrice9);
            //    }
            //    if (NumberOfBook10 > 0)
            //    {
            //        Console.Write(" Viaje al centro de la tierra");
            //        Console.Write("\t" + NumberOfBook10);
            //        Console.Write("\t¢{0:N2}", BookPrice10);
            //        Console.WriteLine("\t¢{0:N2}", NumberOfBook10 * BookPrice10);
            //    }
            //    Console.WriteLine("-------------------------------------------------------------------");
            //    Console.Write(" Total Orden:    \t\t\t\t\t");
            //    Console.WriteLine("¢{0:N2}", TotalOrder);
            //    Console.Write(" Total Descuento:    \t\t\t\t\t");
            //    Console.WriteLine("¢{0:N2}", TotalDiscount);
            //    Console.Write(" Impuesto Venta: \t\t\t\t\t");
            //    Console.WriteLine(TaxRate * 100 + "%");
            //    Console.Write(" Impuesto Total: \t\t\t\t\t");
            //    Console.WriteLine("¢{0:N2}", TaxAmount);
            //    Console.Write(" Precio Neto:    \t\t\t\t\t");
            //    Console.WriteLine("¢{0:N2}", SalesTotal);
            //    Console.WriteLine("-------------------------------------------------------------------");
            //    Console.Write(" Monto Recibido:");
            //    Console.WriteLine("¢{0:N2}", AmountTended);
            //    Console.Write(" Monto Cambio  :");
            //    Console.WriteLine("¢{0:N2}", Difference);
            //    Console.WriteLine("===================================================================");
            //    Console.Write(" Gracias por comprar con nosotros...");
            //    Console.ReadKey();
            //    return 0;
            //}



            static void Main()
        {
            //inicializar el objeto
            Producto.SetSize(size);
            Producto.Initdata();
                   
            do
            {
                Console.Clear();
                Console.WriteLine("-* Global Machines  *-*");
                Console.WriteLine("1. Ingreso de Productos.");
                Console.WriteLine("2. Modificación de Productos.");
                Console.WriteLine("3. Eliminación de Productos.");
                Console.WriteLine("4. Búsquedad de Productos.");
                Console.WriteLine("5. Listado de Productos.");
                Console.WriteLine("6. Venta de Productos.");
                Console.WriteLine("7. Salir.");
                Console.WriteLine("Selecciones una opción");
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
                            //Modificar la información
                            ModifyProducts();
                            break;
                        }
                    case 3:
                        {
                            //Eliminar información dejando campos en 0 o vacío
                            DeleteProducts();
                            break;
                        }
                    case 4:
                        {
                            //SeekBooks();
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
                                //Venta similar a tarea1
                                VentaProducts();
                            //PrintInvoice();
                            break;
                        }
                    case 7:
                        //Salir
                        break;
                    default:
                        {
                            Console.WriteLine("Seleccione inválida..");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            } while (option != 7);
        }
    }
}