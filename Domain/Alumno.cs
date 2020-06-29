namespace Domain
{
    public class Alumno
    {

        public string idAlumno { get; set; }
        public string nombre { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
        public string dni { get; set; }
        public string telefono_fijo { get; set; }
        public string telefono { get; set; }
        public string fecha_nacimiento { get; set; }
        public string lugar_nacimiento { get; set; }
        public string nacionalidad { get; set; }
        public string departamento { get; set; }
        public string provincia { get; set; }
        public string Domicilio { get; set; }
        public string certificado { get; set; }
        public string discapacidad { get; set; }
        public string foto_url { get; set; }
        public string facebook_url { get; set; }
        public string correo { get; set; }
        public string password { get; set; }
        public string descripcion_perfil { get; set; }

        
        public Alumno(string idAlumno, string nombre, string apellido_paterno, 
                    string apellido_materno, string dni, string telefono_fijo, 
                    string telefono, string fecha_nacimiento, string lugar_nacimiento, 
                    string nacionalidad, string departamento, string provincia, 
                    string domicilio, string certificado, string discapacidad, 
                    string foto_url, string facebook_url, string correo, string password, 
                    string descripcion_perfil)
        {
            this.idAlumno = idAlumno;
            this.nombre = nombre;
            this.apellido_paterno = apellido_paterno;
            this.apellido_materno = apellido_materno;
            this.dni = dni;
            this.telefono_fijo = telefono_fijo;
            this.telefono = telefono;
            this.fecha_nacimiento = fecha_nacimiento;
            this.lugar_nacimiento = lugar_nacimiento;
            this.nacionalidad = nacionalidad;
            this.departamento = departamento;
            this.provincia = provincia;
            Domicilio = domicilio;
            this.certificado = certificado;
            this.discapacidad = discapacidad;
            this.foto_url = foto_url;
            this.facebook_url = facebook_url;
            this.correo = correo;
            this.password = password;
            this.descripcion_perfil = descripcion_perfil;
        }
    }
}
