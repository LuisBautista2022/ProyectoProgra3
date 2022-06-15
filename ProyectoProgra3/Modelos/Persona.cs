using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }
        public string TipoUsuario { get; set; }

        public Persona()//Contructor por defecto ingresar a todos los atributos
        {

        }

        public Persona(string nombre, string apellido, string usuario, string contrasenia)
        {
            Nombre = nombre;
            Apellido = apellido;
            Usuario = usuario;
            Contrasenia = contrasenia;
        }
    }
}
