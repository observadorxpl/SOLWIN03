using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    class Pago
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Estado { get; set; }
        public int HorasTrabajadas { get; set; }
        public int HorasExtras { get; set; }
        public decimal PagoHoraTrabajadas { get; set; }
        public decimal PagoHoraExtra { get; set; }
        public decimal Salario { get; set; }
        public decimal Bonificacion { get; set; }
        public decimal Descuento { get; set; }
        public decimal Neto { get; set; }

        public Pago()
        {
        }
        public decimal ObtenerPagoHora()
        {
            decimal p = 0;
            switch (this.Cargo)
            {
                case "Gerente":
                    p = 50;
                    break;
                case "Jefe":
                    p = 30;
                    break;
                case "Supervisor":
                    p = 25;
                    break;
                case "Asistente":
                    p = 20;
                    break;
                case "Secretaria":
                    p = 12;
                    break;
            }
            return p;
        }
        public decimal ObtenerPagoExtra(decimal porcentaje)
        {
            decimal p = 0;
            switch (this.Cargo)
            {
                case "Gerente":
                    p = 50;
                    break;
                case "Jefe":
                    p = 30;
                    break;
                case "Supervisor":
                    p = 25;
                    break;
                case "Asistente":
                    p = 20;
                    break;
                case "Secretaria":
                    p = 12;
                    break;
            }
            p= p + (p * porcentaje);
            return p;
        }
        public decimal ObtenerSalario()
        {
            decimal salario = 0;
            salario = this.HorasTrabajadas * this.PagoHoraTrabajadas;
            return salario;
        }
        public decimal ObtenerBonificacion()
        {
            return this.HorasExtras * this.PagoHoraExtra;
        }

        public decimal ObtenerDsctoPlanilla()
        {
            decimal desc= 0;
            if (this.Estado == "Planilla")
            {
                desc= (this.Salario * 0.25m);
            }else if (this.Estado == "Contratado")
                {
                desc = (this.Salario * 0.08m);
            }
            return desc;
        }
        public decimal ObtenerNeto()
        {
            return ((this.Salario +this.Bonificacion)- this.Descuento);
        }

    }
}
