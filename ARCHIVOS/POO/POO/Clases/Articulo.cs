using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    public class Articulo : Producto
    {
        //Propiedades
        public string Categoria { get; set; }
        public string UnidadMedida { get; set; }
        //Constructor
        public Articulo()
        {

        }
        public Articulo(int codigo, string nombre, string categoria)
        {
            Codigo = codigo;
            Nombre = nombre;
            Categoria = categoria;            
        }
        //public Articulo(int codigo, string categoria, double precioSoles)
        //{
        //    Codigo = codigo;
        //    Categoria = categoria;
        //    PrecioSoles = precioSoles;
        //}

        //Métodos
        
        //public double ConvertirEuros()
        //{
        //    return PrecioSoles * 3.82;
        //}
        //public override string NombreMayusculas()
        //{
        //    return Nombre.ToLower();
        //}
    }
}
