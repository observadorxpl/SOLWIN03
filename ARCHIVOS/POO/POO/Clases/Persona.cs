using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    public class Persona
    {
        //Definición de propiedades de la clase        
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public bool Sexo { get; set; }
        public int Edad { get; set; }
        public decimal Peso { get; set; }
        //Definción de constructores
        //tiene el mismo nombre que la clase
        public Persona()
        {

        }
        public Persona(String nombre,string apellidos,string email)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Email = email;
        }
        public Persona(string nombre, string apellidos, DateTime fechanacimiento,
                        int edad)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            FechaNacimiento = fechanacimiento;
            Edad = edad;
        }
        //Definición de métodos
        //Virtual permite hacer polimorfismo a un método
        public virtual string ListarNombreCompleto()
        {
            return Nombre + " " + Apellidos;
        }
        public virtual string ObtenerGenero()
        {
            if (Sexo == true)
            {
                return "Masculino";
            }
            else
            {
                return "Femenino";
            }
        }
        //Procedimiento - No retorna nada
        public void Limpiar()
        {
            Nombre = "";
            Apellidos = "";
            FechaNacimiento = DateTime.Now; //Fecha actual
            Sexo = false;
            Edad = 0;
            Peso = 0;
        }
    }
}
