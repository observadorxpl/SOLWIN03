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
    public partial class frmListas : Form
    {
        //crear una colección de tipo LIST, este colección es dinamica, no tiene límite
        List<Clases.Producto> productos = new List<Clases.Producto>();        
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea grabar el producto?", "Grabar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Clases.Producto producto = new Clases.Producto();
                //Grabar un registro de producto
                producto.Codigo = Convert.ToInt32(txtCodigo.Text);
                producto.Nombre = txtNombre.Text;
                producto.Precio = Convert.ToInt32(txtPrecio.Text);
                producto.IGV = producto.ObtenerIGV();
                producto.PrecioVenta = producto.ObtenerPrecioVenta();
                //Mostrar IGV y PrecioVenta
                txtIGV.Text = Convert.ToString(producto.IGV);
                txtPrecioVenta.Text = Convert.ToString(producto.PrecioVenta);
                //Gruardar en el coleccion
                productos.Add(producto);
                //Cargar datos en la grilla
                DGVProductos.DataSource = null;
                DGVProductos.DataSource = productos;
                MessageBox.Show("Registro almacenado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmListas()
        {
            InitializeComponent();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            var producto = productos.Where(p => p.Codigo == codigo).SingleOrDefault();
            if (producto != null)
            {
                if (MessageBox.Show("¿Esta seguro?","Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    productos.Remove(producto);
                    Util.Globales.Limpiar(this);
                    DGVProductos.DataSource = null;
                    DGVProductos.DataSource = productos;
                }                
            }
            else //Si no exite
            {
                MessageBox.Show("No existe el producto", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Util.Globales.Limpiar(this);
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea grabar el producto?","Grabar Producto",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Clases.Producto producto = new Clases.Producto();
                //Grabar un registro de producto
                producto.Codigo = Convert.ToInt32(txtCodigo.Text);
                producto.Nombre = txtNombre.Text;
                producto.Precio = Convert.ToInt32(txtPrecio.Text);
                producto.IGV = producto.ObtenerIGV();
                producto.PrecioVenta = producto.ObtenerPrecioVenta();
                //Mostrar IGV y PrecioVenta
                txtIGV.Text = Convert.ToString(producto.IGV);
                txtPrecioVenta.Text = Convert.ToString(producto.PrecioVenta);
                //Gruardar en el coleccion
                productos.Add(producto);
                //Cargar datos en la grilla
                DGVProductos.DataSource = null;
                DGVProductos.DataSource = productos;
                MessageBox.Show("Registro almacenado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Util.Globales.PermiteNumeros(e.KeyChar);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Util.Globales.PermiteNumeros(e.KeyChar);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            //Buscar el producto por su código en la colección y especificar mediante una consulta
            //que devuelva una sola fina como máximo(single)
            var producto = productos.Where(p => p.Codigo == codigo).SingleOrDefault();
            //where es un condicional que pregunta si dentro de la colección hay un producto
            //.SingleOrDefault devuelve una solo fila de la consulta

            //Si exite el producto
            if (producto!=null)
            {
                txtNombre.Text = producto.Nombre;
                txtPrecio.Text = Convert.ToString(producto.Precio);
                txtIGV.Text = Convert.ToString(producto.IGV);
                txtPrecioVenta.Text = Convert.ToString(producto.PrecioVenta);
            }
            else //Si no exite
            {
                MessageBox.Show("No existe el producto", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
