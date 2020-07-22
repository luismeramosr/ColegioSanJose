using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Docente
    {
        public string idDocente { get; set; }
        public string Usuario { get; set; }

        public Docente() { }

        public Docente(string idDocente, string usuario)
        {
            this.idDocente = idDocente;
            Usuario = usuario;
        }

    }
}
