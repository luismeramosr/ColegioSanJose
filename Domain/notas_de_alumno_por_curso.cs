using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class notas_de_alumno_por_curso
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
