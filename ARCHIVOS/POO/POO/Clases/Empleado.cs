using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    //herencia de clases, permite heredar propiedades y metodos de otra clase
    public class Empleado : Persona // Herencia
    {
        //Propiedades
        public string DNI { get; set; }
        public DateTime FechaContrato { get; set; }
        //Constructor
        public Empleado()
        {

        }
        public Empleado(string nombre,string apellidos, DateTime fechacontrato, string DNI)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            FechaContrato = fechacontrato;
            this.DNI = DNI;
        }
        //Metodos
        public int TiempoServicio()
        {
            //Restar el año actual - año de contrato
            return (DateTime.Now.Year - FechaContrato.Year);
        }
        //Aplicar polimorfismo con Override - Permite modificar el método heredado
        public override string ListarNombreCompleto()
        {
            return Apellidos + "," + Nombre; //se cambió el método definido en Persona
        }
        //Sobrecarga de métodos - se puede tener muchas funciones con el mismo nombre, siempre que tengan diferents elementos
        public int TiempoServicio(int yearactual)
        {            
            return (yearactual - FechaContrato.Year); //el componente corresponde según el tipo de elemento defino (FechaContrato es DateTime), por tanto puede ser Year, Date, Hour, etc
            //en caso se requiera para operaciones matemáticas se debe usar: Math.xxx
        }
        public int TiempoServicio(int yearactual, int yearcontrato)
        {
            return (yearactual - yearcontrato);            
        }
    }
}
