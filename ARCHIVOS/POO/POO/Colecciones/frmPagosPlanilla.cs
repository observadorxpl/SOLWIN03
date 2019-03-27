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
    public partial class frmPagosPlanilla : Form
    {
        public frmPagosPlanilla()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Instanciar la clase Pago
            Clases.Pago pago = new Clases.Pago();
            //Cargar sus propiedades
            pago.Codigo =Convert.ToInt32( txtCodigo.Text);
            pago.Nombre = txtNombre.Text;
            pago.Cargo = cboCargo.Text;
            pago.HorasTrabajadas = Convert.ToInt32(txtHorasTrabajadas.Text);
            pago.HorasExtras = Convert.ToInt32(txtHorasExtras.Text);
            //Calcular los montos
            pago.PagoHoraTrabajada = pago.ObtenerPagoHora();
            pago.PagoHoraExtra = pago.ObtenerPagoHoraExtra(0.50m);
            //Mostrar
            txtPagoHora.Text =Convert.ToString( pago.PagoHoraTrabajada);
            txtPagoHoraExtra.Text = Convert.ToString(pago.PagoHoraExtra);

            pago.Salario = pago.ObtenerSalario();
            pago.Bonificacion = pago.ObtenerBonificacion();

            if (rbtPlanilla.Checked == true)
                pago.Estado = "Planilla";
            if (rbtContratado.Checked == true)
                pago.Estado = "Contratado";

            pago.Descuento = pago.ObtenerDsctoPlanilla();
            pago.Neto = pago.ObtenerNeto();
            //Mostrar
            txtSalario.Text =Convert.ToString( pago.Salario);
            txtBonificacion.Text =Convert.ToString( pago.Bonificacion);
            txtDescuento.Text = Convert.ToString(pago.Descuento);
            txtNeto.Text = Convert.ToString(pago.Neto);

        }
    }
}
