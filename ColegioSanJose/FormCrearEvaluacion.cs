using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColegioSanJose
{
    public partial class FormCrearEvaluacion : Form
    {
        List<PreguntaComponent> preguntas;
        int selected=0;

        public FormCrearEvaluacion()
        {
            InitializeComponent();
            preguntas = new List<PreguntaComponent>();
            push();
        }

        private void push()
        {
            if (preguntas.Count > 0)
            {
                hidePregunta(selected);
                preguntas.Add(new PreguntaComponent());                
                preguntas.ElementAt(preguntas.Count-1).Dock = DockStyle.Fill;
                preguntas.ElementAt(preguntas.Count - 1).Location = 
                preguntas.ElementAt(preguntas.Count - 2).Location;
                selected = preguntas.Count - 1;                
                showPregunta(selected);
            }
            else if (preguntas.Count == 0)
            {
                preguntas.Add(new PreguntaComponent());
                preguntas.ElementAt(0).Dock = DockStyle.Fill;
                preguntas.ElementAt(0).Location = new Point(0, 29);
                showPregunta(0);
            }
            Console.WriteLine(preguntas.Count);
            Controls.AddRange(preguntas.ToArray());
        }

        private void pop()
        {
            hidePregunta(selected);
            foreach (PreguntaComponent pregunta in preguntas)
            {
                Controls.Remove(pregunta);
            }            
            preguntas.RemoveAt(preguntas.Count -1);
            selected = preguntas.Count-1;
            Controls.AddRange(preguntas.ToArray());                      
            showPregunta(selected);
            Console.WriteLine(preguntas.Count);
        }

        private void BtnAgregarPregunta_Click(object sender, EventArgs e)
        {
            push();
        }

        private void BtnQuitarPregunta_Click(object sender, EventArgs e)
        {
            if (preguntas.Count > 1)
                pop();
            else
                MessageBox.Show("No puede eliminar esta pregunta.");
            // Si dejase que el usuario elimine esta pregunta ya no podria
            // agregar mas xd, tendria que volver a abrir el programa
        }

        private void showPregunta(int index)
        {
            preguntas.ElementAt(index).Visible = true;
            lblPregunta.Text = "PREGUNTA " + (index+1);
        }

        private void hidePregunta(int index)
        {            
            preguntas.ElementAt(index).Visible = false;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (selected > 0)
            {
                hidePregunta(selected);
                selected--;
                showPregunta(selected);
            }
            else
            {
                MessageBox.Show("Ya no hay mas preguntas");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (selected < preguntas.Count-1)
            {
                hidePregunta(selected);
                selected++;
                showPregunta(selected);
            }
            else
            {
                MessageBox.Show("Ya no hay mas preguntas");
            }
        }
    }
}
