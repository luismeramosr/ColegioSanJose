using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Domicilio
    {
        public string idDomicilio { get; set; }
        public string distrito { get; set; }
        public string referencia { get; set; }
        public string direccion { get; set; }

        public Domicilio(string idDomicilio, string distrito, string referencia, string direccion)
        {
            this.idDomicilio = idDomicilio;
            this.distrito = distrito;
            this.referencia = referencia;
            this.direccion = direccion;
        }

    }
}
