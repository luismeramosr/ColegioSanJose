using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Seccion
    {
        public string idSeccion { get; set; }
        public string num_alumnos { get; set; }

        public Seccion() { }

        public Seccion(string idSeccion, string num_alumnos)
        {
            this.idSeccion = idSeccion;
            this.num_alumnos = num_alumnos;
        }

    }
}
