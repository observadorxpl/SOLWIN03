using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POO.Colecciones
{
    public partial class frmArreglos : Form
    {
        //Definición de variables publicas
        //crear un arreglo de tipo producto
        Clases.Producto[] productos = new Clases.Producto[5]; //arreglo de 5 elementos
        int icontador = 0;
        public frmArreglos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Util.Globales.Limpiar(this); //se usa this para llamar el formulario u objeto
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //Grabar un registro de producto
            //Instanciar una clase Producto
            Clases.Producto producto = new Clases.Producto();
            //Cargar sus propiedades
            producto.Codigo = Convert.ToInt32(txtCodigo.Text);
            producto.Nombre = txtNombre.Text;
            producto.Precio = Convert.ToInt32(txtPrecio.Text);
            producto.IGV = producto.ObtenerIGV();
            producto.PrecioVenta = producto.ObtenerPrecioVenta();
            //Mostrar IGV y PrecioVenta
            txtIGV.Text = Convert.ToString(producto.IGV);
            txtPrecioVenta.Text = Convert.ToString(producto.PrecioVenta);
            //Gruardar en el arreglo
            productos[icontador] = producto;
            //Incrementar contador
            icontador += 1;
            //Cargar arreglo en la grilla
            //Limpiamos la grilla
            DGVProductos.DataSource = null;
            DGVProductos.DataSource = productos;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Util.Globales.PermiteNumeros(e.KeyChar);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Util.Globales.PermiteNumeros(e.KeyChar);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            foreach(Clases.Producto producto in productos) //bucle para recorrer colecciones del primero al último elemento
            {
                //Si el codigo del producto es igual al codigo buscado
                if (producto.Codigo==codigo)
                {
                    txtNombre.Text = producto.Nombre;
                    txtPrecio.Text = Convert.ToString(producto.Precio);
                    txtIGV.Text = Convert.ToString(producto.IGV);
                    txtPrecioVenta.Text = Convert.ToString(producto.PrecioVenta);
                    //Abandonar el procedimiento
                    return;
                }
            }
            //Si el bucle finaliza entonces
            MessageBox.Show("No existe el producto con el código: " + txtCodigo.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }        
    }
}
