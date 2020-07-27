using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Domain;


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
    }
}
