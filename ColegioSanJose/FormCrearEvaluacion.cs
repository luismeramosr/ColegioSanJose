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
        public FormCrearEvaluacion()
        {
            InitializeComponent();
            PreguntaComponent pregunta = new PreguntaComponent();
            this.Controls.Add(pregunta);
            pregunta.Dock = DockStyle.Top;
        }
    }
}
