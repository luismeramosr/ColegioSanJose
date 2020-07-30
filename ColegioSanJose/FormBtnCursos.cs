using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Domain;
using System.IO;
using System.Resources;
//using System.Assembly
using Datalib;
using ColegioSanJose;

namespace ColegioSanJose
{

    public partial class FormBtnCursos : Form
    {
        List<Curso> cursos;
        List<CursoComponent> cursoComponents;
        int initialRows = 5;
        int initialCols = 3;

        public FormBtnCursos(Dictionary<string, object> data)
        {
            InitializeComponent();
            cursos = (List<Curso>)data["cursos"];
            cursoComponents = new List<CursoComponent>();
                      
            int i = 1;
            foreach (Curso cur in cursos)
            {
                Image img = Image.FromFile(string.Format(@"..\..\Resources\{0}.png",i));  
                cursoComponents.Add(new CursoComponent(cur.nombre, img));
                i++;
            }            

            Controls.AddRange(cursoComponents.ToArray());
            orderComponents(initialCols, initialRows);
        }

        private void orderComponents(int rows, int columns)
        {
            CursoComponent[,] cursos = Make2DArray(cursoComponents.ToArray(), 
                                                    rows, columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    cursos[i, j].relocate(new Point(50 + ((cursos[i, j].Width + 50) * j),
                                        27 + ((cursos[i, j].Height + 27) * i)));
                }
            }
        }

        private int getColumns()
        {
            return Width / 240;
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
            }else if (input.Length / (rowCount*colCount) != 1)
            {
                int residuo = input.Length - (rowCount * colCount);

                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < colCount; j++)
                    {
                        output[i, j] = input[i * colCount + j];
                    }
                }

                for (int i=0;i<residuo; i++)
                {
                    output[i, rowCount] = input[(rowCount * colCount) + i];
                }
            }
            return output;
        }

        private void reloadPanel(object sender, EventArgs e)
        {
            int rows = initialRows - (getColumns() - initialCols);
            if (rows==getColumns())
                orderComponents(getColumns(), 3);
            else
                orderComponents(getColumns(), rows);
        }
    }
}
