using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    public class Empleado : Persona //Herencia                
    {
        public string DNI { get; set; }
        public DateTime FechaContrato { get; set; }

        public Empleado()
        {

        }
        public Empleado(string  nombre , string apellidos,
                        DateTime fechacontrato, string DNI)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.FechaContrato = fechacontrato;
            this.DNI = DNI;
        }
        public int TiempoServicio()
        {            
            return (DateTime.Now.Year - this.FechaContrato.Year);
        }
        //Aplicar polimorfismo con Override
        public override string ListarNombreCompleto()
        {
            return this.Apellidos + "," + this.Nombre;
        }
        //Sobrecarga de metodos
        public int TiempoServicio(int añoactual)
        {            
            return (añoactual - this.FechaContrato.Year);
        }
        public int TiempoServicio(int añoactual,int añocontrato)
        {
            return (añoactual - añocontrato);           
        }
    }
}

