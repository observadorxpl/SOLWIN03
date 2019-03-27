using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    public class Producto
    {
        //Propiedades
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal IGV { get; set; }
        public decimal PrecioVenta { get; set; }
        //Constructor
        public Producto()
        {

        }
        //public Producto(int codigo, string nombre)
        //{
        //    Codigo = codigo;
        //    Nombre = nombre;
        //}
        //public Producto(int codigo, int precioSoles)
        //{
        //    Codigo = codigo;
        //    Precio = precioSoles;
        //}

        //Métodos
        //public decimal ConvertirPrecioDolares()
        //{            
        //    return Precio * 3.38;
        //}
        //public virtual string NombreMayusculas()
        //{
        //    return Nombre.ToUpper();
        //}
        public decimal ObtenerIGV()
        {
            return Precio * 0.18m;
        }
        public decimal ObtenerPrecioVenta()
        {
            return this.Precio * 1.18m; 
        }
    }
}
