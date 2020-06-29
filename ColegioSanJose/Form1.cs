using System;
using System.Windows.Forms;
using DB_interface;
using Domain;
using System.Collections.Generic;

namespace ColegioSanJose
{
    public partial class Form1 : Form
    {
        public Form1()
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

            Domicilio dom = new Domicilio("","SMP","",
                                    "Av. Zarumilla 1121");

            db.writeTable(dom);
                                              
        }
    }
}
