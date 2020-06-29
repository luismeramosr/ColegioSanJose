using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Notas_De_Alumno_Por_Curso
    {
        public string Alumno { get; set; }
        public string Curso { get; set; }
        public string promedio_tareas { get; set; }
        public string examen_trimestral1 { get; set; }
        public string examen_trimestral2 { get; set; }
        public string examen_trimestral3 { get; set; }
        public string examen_final { get; set; }
        public string promedio_final { get; set; }
    }
}
