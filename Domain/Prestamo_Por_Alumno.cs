using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Prestamo_Por_Alumno
    {
        public string Alumno { get; set; }
        public string Libro { get; set; }
        public string fecha_prestamo { get; set; }
        public string duracion_prestamo { get; set; }
    }
}
