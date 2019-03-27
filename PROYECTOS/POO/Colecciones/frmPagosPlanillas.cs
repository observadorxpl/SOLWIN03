using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO.Colecciones
{
    public partial class frmPagosPlanillas : Form
    {
        List<Clases.Pago> pagos = new List<Clases.Pago>();
        public frmPagosPlanillas()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Clases.Pago pago = new Clases.Pago();
            pago.Codigo = (Convert.ToInt32(txtCodigo.Text));
            pago.Nombre = txtNombre.Text;
            pago.Cargo = cboCargo.Text;
            pago.HorasTrabajadas = Convert.ToInt32(txtHorasTrabajadas.Text);
            pago.HorasExtras = Convert.ToInt32(txtHorasExtras.Text);
            if (rbtnContratado.Checked == true)
            {
                pago.Estado = "Contratado";
            }
            if (rbtnPlanilla.Checked == true)
            {
                pago.Estado = "Planilla";
            }
            pago.PagoHoraTrabajadas = pago.ObtenerPagoHora();
            pago.PagoHoraExtra = pago.ObtenerPagoExtra(0.50m);

            txtPagoHora.Text = Convert.ToString(pago.PagoHoraTrabajadas);
            txtPagoHoraExtras.Text = Convert.ToString(pago.PagoHoraExtra);

            pago.Salario = pago.ObtenerSalario();
            pago.Bonificacion = pago.ObtenerBonificacion();
            pago.Descuento = pago.ObtenerDsctoPlanilla();
            pago.Neto = pago.ObtenerNeto();

            txtSalario.Text = Convert.ToString(pago.Salario);
            txtBonificaion.Text = Convert.ToString(pago.Bonificacion);
            txtDescuento.Text = Convert.ToString(pago.Descuento);
            txtNeto.Text = Convert.ToString(pago.Neto);

            }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea Grabar?", "Grabar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Clases.Pago pago = new Clases.Pago();

                pago.Codigo = (Convert.ToInt32(txtCodigo.Text));
                pago.Nombre = txtNombre.Text;
                pago.Cargo = cboCargo.Text;
                pago.HorasTrabajadas = Convert.ToInt32(txtHorasTrabajadas.Text);
                pago.HorasExtras = Convert.ToInt32(txtHorasExtras.Text);
                if (rbtnContratado.Checked == true)
                {
                    pago.Estado = "Contratado";
                }
                if (rbtnPlanilla.Checked == true)
                {
                    pago.Estado = "Planilla";
                }
                pago.PagoHoraTrabajadas = pago.ObtenerPagoHora();
                pago.PagoHoraExtra = pago.ObtenerPagoExtra(0.50m);

                pago.Salario = pago.ObtenerSalario();
                pago.Bonificacion = pago.ObtenerBonificacion();
                pago.Descuento = pago.ObtenerDsctoPlanilla();
                pago.Neto = pago.ObtenerNeto();
                pagos.Add(pago);
                DGVPagos.DataSource = null;
                DGVPagos.DataSource = pagos;
                LimpiarDatos();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            
            
        }

        private void LimpiarDatos() {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtHorasTrabajadas.Text = "";
            txtHorasExtras.Text = "";
            rbtnContratado.Checked = false;
            rbtnPlanilla.Checked = false;
            ///
            cboCargo.Text = "";
            txtPagoHora.Text = "";
            txtPagoHoraExtras.Text = "";
            txtSalario.Text = "";
            txtBonificaion.Text = "";
            txtDescuento.Text = "";
            txtNeto.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            var pago = pagos.Where(p => p.Codigo == codigo).SingleOrDefault();

            if (pago != null)
            {
                txtNombre.Text = pago.Nombre;
                txtHorasTrabajadas.Text = Convert.ToString(pago.HorasTrabajadas);
                txtHorasExtras.Text = Convert.ToString(pago.HorasExtras);
      
                if (pago.Estado== "Planilla") {
                    rbtnPlanilla.Checked = true;
                }else if (pago.Estado == "Contratado") {
                    rbtnContratado.Checked = true;
                }
                string cargo = pago.Cargo;
                cboCargo.Text = cargo;
                txtPagoHora.Text = Convert.ToString(pago.PagoHoraTrabajadas);
                txtPagoHoraExtras.Text = Convert.ToString(pago.PagoHoraExtra);
                txtSalario.Text = Convert.ToString(pago.Salario);
                txtBonificaion.Text = Convert.ToString(pago.Bonificacion);
                txtDescuento.Text = Convert.ToString(pago.Descuento);
                txtNeto.Text = Convert.ToString(pago.Neto);

            }
            else
            {
                MessageBox.Show("No existe el producto",
                    "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            var pago = pagos.Where(p => p.Codigo == codigo).SingleOrDefault();
            if (MessageBox.Show("¿Seguro Que desea Elimiar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pagos.Remove(pago);
            }
        }

        private void DGVPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
