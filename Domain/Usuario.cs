using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Usuario
    {
        public string idUsuario { get; set; }
        public string password { get; set; }
        public string tipo { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string edad { get; set; }
        public string correo { get; set; }
        public string image { get; set; }

        public Usuario() { }

        public Usuario(string idUsuario, string password, string tipo, string nombre, string apellidos, string edad, string correo, string image)
        {
            this.idUsuario = idUsuario;
            this.password = password;
            this.tipo = tipo;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            this.correo = correo;
            this.image = image;
        }

        public bool isAlumno()
        {
            if (tipo == "A")
                return true;
            else return false;
        }

        public bool isDocente()
        {
            if (tipo == "D")
                return true;
            else return false;
        }
    }
}
