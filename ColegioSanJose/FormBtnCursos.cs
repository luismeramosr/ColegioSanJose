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
        Dictionary<string, Image> images;
        List<Curso> cursos;

        public FormBtnCursos(Dictionary<string, object> data)
        {
            InitializeComponent();
            string[] pathToImages = Directory.GetFiles(@"..\..\Resources");
            cursos = (List<Curso>)data["cursos"];
            images = new Dictionary<string, Image>();            
            int i = 0;
            foreach (Curso cur in cursos)
            {
                images.Add(cur.nombre, Image.FromFile(pathToImages[i]));
                i++;
            }
            
            

        }

        private void loadCurso(string nomCurso, Image imgCurso, Point location)
        {
            CursoComponent newCurso = createCursoPanel(nomCurso, imgCurso);
            Controls.Add(newCurso);
            newCurso.Location = location;
        }

        private CursoComponent createCursoPanel(string name,Image img)
        {
            CursoComponent cursoControl = new CursoComponent(name, img);
            cursoControl.BringToFront();
            cursoControl.Show();
            return cursoControl;
        }

        private T[,] Make2DArray<T>(T[] input, int rowCount, int colCount)
        {
            T[,] output = new T[rowCount, colCount];
            if (rowCount * colCount <= input.Length)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < colCount; j++)
                    {
                        output[i, j] = input[i * colCount + j];
                    }
                }
            }
            return output;
        }

        private void reloadPanel(object sender, EventArgs e)
        {

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
