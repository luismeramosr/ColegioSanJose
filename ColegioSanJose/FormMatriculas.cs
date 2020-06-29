using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ColegioSanJose
{
    public partial class FormMatriculas : Form
    {
        public FormMatriculas()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCaptura();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMenssage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void Form1_Load(object sender, EventArgs e)
        {
            #region Lista_Año
            //Agregando Año
            List<string> year = new List<string>();
            year.Add("Seleccionar");
            year.Add("Primaria");
            year.Add("Secundaria");
            cboYear.Items.AddRange(year.ToArray());
            cboYear.SelectedIndex = 0;
            #endregion

            #region Lista_Grado
            List<string> grado = new List<string>();
            grado.Add("Seleccionar");
            grado.Add("1");
            grado.Add("2");
            grado.Add("3");
            grado.Add("4");
            grado.Add("5");
            grado.Add("6");
            cboGrado.Items.AddRange(grado.ToArray());
            cboGrado.SelectedIndex = 0;
            #endregion

            #region Lista_Secciones
            //Agregando Seccion
            List<string> seccion = new List<string>();
            seccion.Add("Selecionar");
            seccion.Add("A");
            seccion.Add("B");
            seccion.Add("C");
            seccion.Add("D");
            seccion.Add("E");
            cboSeccion.Items.AddRange(seccion.ToArray());
            cboSeccion.SelectedIndex = 0;
            #endregion

            #region Lista_Grados
            //Agregando grados de instruccion 
            List<string> grados = new List<string>();
            grados.Add("Seleccionar");
            grados.Add("Primaria ");
            grados.Add("Secundaria");
            grados.Add("Tecnico Superior");
            grados.Add("Universitario");
            grados.Add("No tiene Estudios");
            cboGradodeInstruccion.Items.AddRange(grados.ToArray());
            cboGradodeInstruccion.SelectedIndex = 0;
            cboGradodeInstruccion2.Items.AddRange(grados.ToArray());
            cboGradodeInstruccion2.SelectedIndex = 0;
            #endregion

            #region Lista_E.Civil
            //Agregado Estado Civil 
            List<string> civil = new List<string>();
            civil.Add("Seleccionar");
            civil.Add("Soltero");
            civil.Add("Casado");
            civil.Add("Viudo");
            civil.Add("Divorciado");
            civil.Add("Separado");
            cboEstadoCivil.Items.AddRange(civil.ToArray());
            cboEstadoCivil.SelectedIndex = 0;
            cboEstadoCivil2.Items.AddRange(civil.ToArray());
            cboEstadoCivil2.SelectedIndex = 0;
            #endregion

            #region Lista_Turno
            //Agregando Turno
            List<string> turno = new List<string>();
            turno.Add("Seleccionar");
            turno.Add("Mañana");
            turno.Add("Tarde");
            turno.Add("Noche");
            cboTurno.Items.AddRange(turno.ToArray());
            cboTurno.SelectedIndex = 0;
            #endregion   
        }
            #region Boton_Cerrar
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

            #region Animacion_form
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaptura();
            SendMenssage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

            #region Validacion_Datos
        private void button1_Click(object sender, EventArgs e)
        {
            switch (cboSeccion.SelectedIndex.ToString())
            {
                case "0": MessageBox.Show("Eliga una Seccion"); break;

            }
            switch (cboGradodeInstruccion.SelectedIndex.ToString())
            {
                case "0": MessageBox.Show("Eliga un grado"); break;
            }
            switch (cboGradodeInstruccion2.SelectedIndex.ToString())
            {
                case "0": MessageBox.Show("Eliga un grado"); break;
            }
            if (cboYear.SelectedIndex.ToString() == "0")
            {
                MessageBox.Show("Selecionar Año");
            }
            else if (cboYear.SelectedIndex.ToString() == "2")
            {
                if (cboGrado.SelectedIndex.ToString() == "6")
                {
                    MessageBox.Show("Eliga grado del 1 al 5");
                }
            }
            #endregion

        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            #region Test
            txtNombres.Text = "Alfredo";
            txtApellidoMaterno.Text = "Sanchez";
            txtApellidoPaterno.Text = "Aguirre";
            txtFechaNacimiento.Text = "09/01/2001";
            txtDni.Text = "73025689";
            txtPais.Text = "Peru";
            txtDepartamento.Text = "Lima";
            txtProvincia.Text = "Lima";
            txtDomicilio.Text = "Av los cascanueces 885, La Victoria";
            txtLugarNacimiento.Text = "La Victoria";
            txtNombreMadre.Text = "Karina";
            txtApellidoMaternoMadre.Text = "Torres";
            txtApellidoPaternoMadre.Text = "Sanchez";
            txtFechaNM.Text = "29/12/1979";
            txtOcuM.Text = "Ama de Casa";
            txtNombrePadre.Text = "Javier";
            txtApellidoMaternoPadre.Text = "Gonzales";
            txtApellidoPaternoPadre.Text = "Aguirre";
            txtFechaNP.Text = "14/01/1969";
            txtOcuP.Text = "Albañil";
            txtDistrito2.Text = "Av los cascanueces 885, La Victoria";
            txtTelefono.Text = "987564521";
            txtTeflFijo.Text = "5554-32";
            #endregion
        }
    }
}
