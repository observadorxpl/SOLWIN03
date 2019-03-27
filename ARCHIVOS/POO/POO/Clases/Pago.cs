using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO.Clases
{
  public  class Pago
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Estado { get; set; }
        public int HorasTrabajadas { get; set; }
        public int HorasExtras { get; set; }
        public decimal PagoHoraTrabajada { get; set; }
        public decimal PagoHoraExtra { get; set; }
        public decimal Salario { get; set; }
        public decimal Bonificacion { get; set; }
        public decimal Descuento { get; set; }
        public decimal Neto { get; set; }
        public Pago()
        {

        }
        public decimal ObtenerPagoHora ()
        {
            decimal pago = 0;
            switch (this.Cargo)
            {
                case "Gerente" : pago= 50 ; break;
                case "Jefe": pago=30; break;
                case "Supervisor": pago=25; break;
                case "Asistente": pago= 20; break;
                case "Secretaria": pago=12; break;
            }
            return pago;
        }

        public decimal ObtenerPagoHoraExtra(decimal porcentaje)
        {
            decimal pago = 0;
            switch (this.Cargo)
            {
                case "Gerente": pago = 50; break;
                case "Jefe": pago = 30; break;
                case "Supervisor": pago = 25; break;
                case "Asistente": pago = 20; break;
                case "Secretaria": pago = 12; break;
            }
            pago = pago + (pago * porcentaje);
            return pago;
        }
        public decimal ObtenerSalario()
        {            
           return this.HorasTrabajadas * this.PagoHoraTrabajada;                                
        }
        public decimal ObtenerBonificacion()
        {
            return this.HorasExtras* this.PagoHoraExtra;
        }
        public decimal ObtenerDsctoPlanilla()
        {
            decimal descuento = 0;
            if (this.Estado.ToLower() == "planilla")
            {
                descuento = this.Salario * 0.25m;
            }
            else if (this.Estado.ToLower() == "contratado")
            {
                descuento = (this.Salario * 0.08m);
            }
            return descuento;
        }
        public decimal ObtenerNeto()
        {
            return ((this.Salario + this.Bonificacion) - this.Descuento);
        }

    }
}


