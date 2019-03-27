using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
   public class Producto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal IGV { get; set; }
        public decimal PrecioVenta { get; set; }
        public Producto()
        {
        }
        public decimal ObtenerIGV()
        {
            return this.Precio * 0.18m;
        }
        public decimal ObtenerPrecioVenta()
        {
            return this.Precio * 1.18m;
        }
    }
}
