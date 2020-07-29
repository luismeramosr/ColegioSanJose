using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColegioSanJose
{
    public partial class CursoComponent : UserControl
    {
        public CursoComponent()
        {
            InitializeComponent();
        }

        public CursoComponent(string nomCurso, Image imgCurso) : this()
        {
            lbCursoNombre.Text = nomCurso;
            pbCursoImg.Image = imgCurso;
            panelCurso.BackColor = Color.White;
        }

        private void pbCursoImg_MouseEnter(object sender, EventArgs e)
        {
            pbCursoImg.SizeMode = PictureBoxSizeMode.Zoom;
            pbCursoImg.Cursor = Cursors.Hand;
        }

        private void pbCursoImg_MouseLeave(object sender, EventArgs e)
        {
            pbCursoImg.SizeMode = PictureBoxSizeMode.CenterImage;
            pbCursoImg.Cursor = Cursors.Default;
        }

        private void pbCursoImg_Click(object sender, EventArgs e)
        {
            // Cargar formulario de evaluaciones
        }

        public void relocate(Point newLocation)
        {
            Location = newLocation;
        }
    }
}
