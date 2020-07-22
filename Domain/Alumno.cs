using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Alumno
    {
        public string idAlumno { get; set; }
        public string Seccion { get; set; }
        public string Usuario { get; set; }

        public Alumno() { }

        public Alumno(string idAlumno, string seccion, string usuario)
        {
            this.idAlumno = idAlumno;
            Seccion = seccion;
            Usuario = usuario;
        }
    }
}
