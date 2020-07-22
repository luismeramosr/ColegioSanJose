using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Evaluacion
    {
        public string idEvaluacion { get; set; }
        public string Seccion { get; set; }
        public string Curso { get; set; }
        public string data { get; set; }

        public Evaluacion() { }

        public Evaluacion(string idEvaluacion, string seccion, string curso, string data)
        {
            this.idEvaluacion = idEvaluacion;
            Seccion = seccion;
            Curso = curso;
            this.data = data;
        }                              
    }
}
