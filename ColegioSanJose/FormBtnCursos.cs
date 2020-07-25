using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using DB_interface;
using ColegioSanJose;

namespace ColegioSanJose
{

    public partial class FormBtnCursos : Form
    {
        Dictionary<String, object> data;
        Dictionary<String, String> imagenes=new Dictionary<string, string>();
        public FormBtnCursos(Dictionary<String, object> data)
        {
            InitializeComponent();
            this.data = data;
            imagenes.Add("Álgebra", @"C:\Users\littman\Documents\GitHub\ColegioSanJose\ColegioSanJose\Resources\1.png");
        }



        #region Animacion Btn
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.Cursor = Cursors.Default;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.Cursor = Cursors.Default;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.Cursor = Cursors.Hand;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.Cursor = Cursors.Default;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.Cursor = Cursors.Hand;

        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.Cursor = Cursors.Default;
        }
        #endregion

        private void FormBtnCursos_Load(object sender, EventArgs e)
        {
            List<Curso> cursos =(List<Curso>) data["cursos"];
            foreach (Curso c in cursos)
            {
                if (c.nombre == "Álgebra")
                {
                    pictureBox1.Image = Image.FromFile(imagenes[c.nombre]);
                }
                Console.WriteLine(c.nombre);
            }

        }
    }
}
