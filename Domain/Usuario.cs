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

        public Usuario() { }

        public Usuario(string idUsuario, string password, string tipo)
        {
            this.idUsuario = idUsuario;
            this.password = password;
            this.tipo = tipo;
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
