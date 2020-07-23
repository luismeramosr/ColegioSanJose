using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Curso
    {
        public string idCurso { get; set; }
        public string Seccion { get; set; }
        public string Docente { get; set; }
        public string nombre { get; set; }

        public Curso() { }

        public Curso(string idCurso, string seccion, string docente, string nombre)
        {
            this.idCurso = idCurso;
            Seccion = seccion;
            Docente = docente;
            this.nombre = nombre;
        }

    }
}
