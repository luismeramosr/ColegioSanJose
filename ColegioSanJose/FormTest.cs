using System;
using System.Windows.Forms;
using Datalib;
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
            DBManager db = new DBManager("192.168.1.100", "root", "123", "apolloma_Colegio");

            List<Alumno> alumnos = db.readTable<Alumno>();

            foreach (Alumno alu in alumnos)
            {
                Console.WriteLine(alu.idAlumno);
            }

        }
    }
}
