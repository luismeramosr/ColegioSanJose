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
        public string descripcion { get; set; }
        public string fecha_inicio { get; set; }
        public string fecha_fin { get; set; }
        public string documento { get; set; }
        public string tipo { get; set; }

        public Evaluacion(string idEvaluacion, string descripcion, string fecha_inicio, string fecha_fin, string documento, string tipo)
        {
            this.idEvaluacion = idEvaluacion;
            this.descripcion = descripcion;
            this.fecha_inicio = fecha_inicio;
            this.fecha_fin = fecha_fin;
            this.documento = documento;
            this.tipo = tipo;
        }

    }
}
