using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO.Util
{
    public static class Globales //genera una clase compartida, que puede ser llamado desde cualquier parte del proyecto
    {
        public static void Limpiar(Colecciones.frmArreglos frm) //si la clase se define como static, los métodos, también son static
        {
            frm.txtCodigo.Text = "";
            frm.txtNombre.Text = "";
            frm.txtPrecio.Text = "";
            frm.txtIGV.Text = "";
            frm.txtPrecioVenta.Text = "";
        }
        public static void Limpiar(Colecciones.frmListas frm)
        {
            frm.txtCodigo.Text = "";
            frm.txtNombre.Text = "";
            frm.txtPrecio.Text = "";
            frm.txtIGV.Text = "";
            frm.txtPrecioVenta.Text = "";
        }
        public static bool PermiteNumeros(int tecla)
        {
            if (tecla>=48 && tecla<=57 || tecla==8) // (|| es or)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
