using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    public class Persona
    {
        //Definicion de propiedades
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public bool Sexo { get; set; }
        public int Edad { get; set; }
        public decimal Peso { get; set; }
        //Definicion de constructores
        public Persona()
        {
        }
        public Persona(string nombre,string apellidos,string email)
        {
            this.Nombre = nombre;
            this.Apellidos=apellidos;
            this.Email = email;
        }
        public Persona(string nombre, string apellidos, 
                       DateTime fechanacimiento,int edad)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fechanacimiento;
            this.Edad = edad;
        }
        //Definicion de metodos
        //Virtual permite hacer polimorfismo a un metodo
        public virtual string ListarNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }
        public string ObtenerGenero()
        {
            if (this.Sexo==true)
            {
                return "Masculino";
            }
            else
            {
                return "Femenino";
            }
        }
        public void Limpiar()
        {
            this.Nombre = "";
            this.Apellidos = "";
            this.FechaNacimiento = DateTime.Now; //Fecha Actual
            this.Sexo = false;
            this.Email = "";
            this.Edad = 0;
            this.Peso = 0;
        }
    }
}




