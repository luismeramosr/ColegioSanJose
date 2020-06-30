using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Seccion
    {
        public Seccion(string idSeccion, string numAlumnos, string tutor)
        {
            this.idSeccion = idSeccion;
            this.numAlumnos = numAlumnos;
            Tutor = tutor;
        }

        public string idSeccion { get; set; }
        public string numAlumnos { get; set; }
        public string Tutor { get; set; }
    }
}
