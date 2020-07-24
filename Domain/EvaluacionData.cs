using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class EvaluacionData
    {
        public string descripcion;
        public string nombre;
        public int tiempo;
        public Pregunta[] preguntas; 
    }

    public class Pregunta
    {
        public string enunciado;
        public Alternativa[] alternativas;
    }

    public class Alternativa
    {
        public string descripcion;
        public bool isSelected;
    }
}

