using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Usuario
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
    }
}
