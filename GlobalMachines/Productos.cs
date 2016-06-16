using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalMachines
{
    class Productos
    {
        private int codigo_articulo;
        private string nombre_articulo;
        private string tipo;
        private string fecha_vencimiento;
        private string nombre_proveedor;
        private int posicion_estante;
        private double precio;
        public double size;

        private struct products
        {
            public int codigo_articulo;
            public string nombre_articulo;
            public string tipo;
            public string fecha_vencimiento;
            public string nombre_proveedor;
            public int posicion_estante;
            public double precio;
        };

        private static products[] product;

        //constructor
        public Productos()
        {
            codigo_articulo = 0;
            nombre_articulo = "";
            tipo = "";
            fecha_vencimiento = "";
            nombre_proveedor = "";
            posicion_estante = 0;
            precio = 0;
        }

        //contructor con parámetros
        public Productos(int codigo, string nombre, string type, string fecha, string proveedor, int posicion, double price)
        {
            codigo_articulo = codigo;
            nombre_articulo = nombre;
            tipo = type;
            fecha_vencimiento = fecha;
            nombre_proveedor = proveedor;
            posicion_estante = posicion;
            precio = price;
        }

        //propiedades 
        /*public int BookID
        {
            get { return bookid; }
            set { bookid = value; }
        }
        public string BookName
        {
            get { return bookname; }
            set { bookname = value; }
        }*/

        //propiedades 
        public void SetCodigo(int codigo)
        {
            codigo_articulo = codigo;
        }

        public int GetCodigo()
        {
            return codigo_articulo;
        }

        public void SetNombre(string nombre)
        {
            nombre_articulo = nombre;
        }

        public string GetNombre()
        {
            return nombre_articulo;
        }

        public void SetTipo(string type)
        {
            tipo = type;
        }

        public string GetTipo()
        {
            return tipo;
        }


        public void SetFecha(string fecha)
        {
            fecha_vencimiento = fecha;
        }

        public string GetFecha()
        {
            return fecha_vencimiento;
        }


        public void SetProveedor(string proveedor)
        {
            nombre_proveedor = proveedor;
        }

        public string GetProveedor()
        {
            return nombre_proveedor;
        }


        public void SetPosicion(int posicion)
        {
            posicion_estante = posicion;
        }

        public int GetPosicion()
        {
            return posicion_estante;
        }

        public void SetPrecio(double price)
        {
            precio = price;
        }

        public double GetPrecio()
        {
            return precio;
        }

        public void SetSize(int Size)
        {
            size = Size;
            product = new products[Size];
        }

        public void Initdata()
        {
            //inicializar
            for (int i = 0; i < product.Length; i++)
            {
                product[i].codigo_articulo = 0;
                product[i].nombre_articulo = "";
                product[i].tipo = "";
                product[i].fecha_vencimiento = "";
                product[i].nombre_proveedor = "";
                product[i].posicion_estante = 0;
                product[i].precio = 0;
            }
        }

        public bool AddData(Productos Productos)
        {
            //agregar datos
            int i;

            for (i = 0; i < product.Length; i++)
            {
                if (product[i].codigo_articulo == 0)
                {
                    break;
                }
            }

            if (i < product.Length)
            {
                product[i].codigo_articulo = codigo_articulo;
                product[i].nombre_articulo = nombre_articulo;
                product[i].tipo = tipo;
                product[i].fecha_vencimiento = fecha_vencimiento;
                product[i].nombre_proveedor = nombre_proveedor;
                product[i].posicion_estante = posicion_estante;
                product[i].precio = precio;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SeekData(int record)
        {
            //buscar datos
            int i;
            for (i = 0; i < product.Length; i++)
            {
                if (product[i].codigo_articulo == record)
                {
                    break;
                }
            }

            if (i < product.Length)
            {
                codigo_articulo = product[i].codigo_articulo;
                nombre_articulo = product[i].nombre_articulo;
                tipo = product[i].tipo;
                fecha_vencimiento = product[i].fecha_vencimiento;
                nombre_proveedor = product[i].nombre_proveedor;
                posicion_estante = product[i].posicion_estante;
                precio = product[i].precio;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateData(Productos Productos, int record)
        {
            //actualizar datos
            int i;
            for (i = 0; i < product.Length; i++)
            {
                if (product[i].codigo_articulo == record)
                {
                    break;
                }
            }

            if (i < product.Length)
            {
                product[i].codigo_articulo = Productos.codigo_articulo;
                product[i].nombre_articulo = Productos.nombre_articulo;
                product[i].tipo = Productos.tipo;
                product[i].fecha_vencimiento = Productos.fecha_vencimiento;
                product[i].nombre_proveedor = Productos.nombre_proveedor;
                product[i].posicion_estante = Productos.posicion_estante;
                product[i].precio = Productos.precio;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteData(Productos Productos, int record)
        {
            //borrar datos
            int i;
            for (i = 0; i < product.Length; i++)
            {
                if (product[i].codigo_articulo == record)
                {
                    break;
                }
            }

            if (i < product.Length)
            {
                product[i].codigo_articulo = 0;
                product[i].nombre_articulo = "";
                product[i].tipo = "";
                product[i].fecha_vencimiento = "";
                product[i].nombre_proveedor = "";
                product[i].posicion_estante = 0;
                product[i].precio = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintData(int pos)
        {
            //imprimir todo el registro
            codigo_articulo = product[pos].codigo_articulo;
            nombre_articulo = product[pos].nombre_articulo;
            tipo = product[pos].tipo;
            fecha_vencimiento = product[pos].fecha_vencimiento;
            nombre_proveedor = product[pos].nombre_proveedor;
            posicion_estante = product[pos].posicion_estante;
            precio = product[pos].precio;
        }

        // destructor
        ~Productos()
        {

        }
    }
}