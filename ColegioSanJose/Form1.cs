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
            DB db = new DB("192.168.1.100", "root", "", "test");
            string query = "select * from `Tienda_Virtual`" +
                           "where `ID_Tienda_Virtual` = 'TV0005'";

            Tienda tienda = db.readTable(query,new Tienda())[0];

            //foreach (Tienda tienda in tiendas)
            //{
              Console.WriteLine(tienda.nombre);
            //}
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
