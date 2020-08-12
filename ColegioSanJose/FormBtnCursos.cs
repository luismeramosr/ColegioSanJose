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
        public List<CursoComponent> cursoComponents;
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
            orderComponents(initialRows, initialCols);
        }

        public void orderComponents(int rows, int columns)
        {
            CursoComponent[,] cursos = Make2DArray(cursoComponents.ToArray(), 
                                                    rows, columns);

            if (rows * columns == cursos.Length)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        cursos[i, j].relocate(new Point(50 + ((cursos[i, j].Width + 50) * j),
                                            27 + ((cursos[i, j].Height + 27) * i)));
                    }
                }
            }else if (rows * columns < cursos.Length)
            {
                int lastRow = 0;
                for (int i = 0; i < rows; i++)
                {
                    lastRow++;
                    for (int j = 0; j < columns; j++)
                    {
                        cursos[i, j].relocate(new Point(50 + ((cursos[i, j].Width + 50) * j),
                                            27 + ((cursos[i, j].Height + 27) * i)));
                    }
                }

                int lastIndex = rows * columns;
                int delta = cursos.Length - lastIndex;
                Console.WriteLine(cursos.Length);
                Console.WriteLine(lastIndex);
                Console.WriteLine(delta);
                for (int j = 0; j < delta-1; j++)
                {
                    if (cursos[lastRow,j]!=null)
                    {
                        cursos[lastRow, j].relocate(new Point(50 + ((cursos[lastRow, j].Width + 50) * j),
                                            27 + ((cursos[lastRow, j].Height + 27) * lastRow)));
                    }
                }
            }
        }

        public int getColumns()
        {
            return Width / 240;
        }

        public int getRows()
        {
            return cursoComponents.Count / getColumns();
        }

        private T[,] Make2DArray<T>(T[] input, int rowCount, int colCount)
        {
            T[,] output; 
            if (rowCount * colCount == input.Length)
            {
                output = new T[rowCount, colCount];
                Console.WriteLine("Delta ==0");
                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < colCount; j++)
                    {
                        output[i, j] = input[i * colCount + j];
                        Console.WriteLine(string.Format("Curso[{0},{1}] = {2}", i, j, output[i, j]));
                    }
                }
                return output;
            }
            else if((rowCount * colCount) < input.Length)
            {
                output = new T[rowCount+1, colCount];
                Console.WriteLine("Delta !=0");
                int lastRow=0;

                for (int i = 0; i < rowCount; i++)
                {
                    lastRow++;
                    for (int j = 0; j < colCount; j++)
                    {
                        output[i, j] = input[i * colCount + j];
                        Console.WriteLine(string.Format("Curso[{0},{1}] = {2}", i, j, output[i, j]));
                    }
                }

                int lastIndex = rowCount * colCount;
                int delta = input.Length - lastIndex;
                Console.WriteLine(lastIndex);
                Console.WriteLine(delta);
                for (int j = 0; j < delta; j++)
                {
                    output[lastRow, j] = input[lastIndex + j];
                    Console.WriteLine(string.Format("Curso[{0},{1}] = {2}", lastRow, j, output[lastRow, j]));
                }
                return output;
            }   
            else return null;         
        }                
    }    
}
