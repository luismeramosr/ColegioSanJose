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
            DBManager db = new DBManager("192.168.1.100", "root", "123", "apolloma_Colegio");

            List<Seccion> secciones = db.readTable(new Seccion());

            foreach (Seccion sec in secciones)
            {
                Console.WriteLine(sec.idSeccion);
            }

        }

        private void FormTest_Load(object sender, EventArgs e)
        {

        }
    }
}
