using System;
using System.Windows.Forms;
using DB_interface;
using Domain;
using System.Collections.Generic;

namespace ColegioSanJose
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {   
            DB db = new DB("192.168.1.100","3307", "root", "123", "apolloma_Colegio");

            //foreach (Alumno alu in alumnos)
            //{
            //Console.WriteLine(alu.idAlumno+ " " +alu.nombres);
            //}          

            Evaluacion ev = new Evaluacion("EV12345","","29/06/20",
                                        "05/07/20", "www.google.com","tareita");

            db.writeTable(ev);
                                              
        }
    }
}
