using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Datalib;

using Domain;
using System.Runtime.InteropServices;

namespace ColegioSanJose
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            if (!login(txtdni.Text, txtpass.Text))
                msgError("El código o contraseña ingresado es incorrecto o no existe");         
        }

        //DBManager db = new DBManager("192.168.1.100","root", "123", "apolloma_Colegio");
        DBManager db = new DBManager("localhost", "3306", "root", "SYSTEM", "apolloma_Colegio");

        #region Login
        private bool login(string user, string password)
        {
            Usuario newUser = db.readRow(new Usuario(),user);
            Dictionary<string, object> data = new Dictionary<string, object>();

            if(newUser != null)
            {
                if (newUser.isAlumno() && newUser.password == password)
                {
                    Console.WriteLine("Ingreso: " + newUser.idUsuario);
                    Alumno alu = db.readRow(new Alumno(), user);
                    List<Curso> cursos = db.readTable<Curso>(alu.Seccion, 1);
                    data.Add("userType", "Alumno");
                    data.Add("user", newUser);
                    data.Add("cursos", cursos);
                    (new FormPrincipal(data)).Show();
                    this.Close();
                    return true;
                }
                else if (newUser.isDocente() && newUser.password == password)
                {
                    Console.WriteLine("Ingreso: " + newUser.idUsuario);
                    Docente doc = db.readRow(new Docente(), user);
                    data.Add("userType", "Docente");
                    data.Add("user", newUser);
                    (new FormPrincipal(data)).Show();
                    this.Close();
                    return true;
                }
                else return false;                
            }
            else return false;

        }
        #endregion

        #region MsgError
        private void msgError(string msg)
        {
            lberror.Text = "     " + msg;
            lberror.Visible = true;
        }
        #endregion

        #region TEXTBOX
        private void txtdni_Enter(object sender, EventArgs e)
        {
            if(txtdni.Text == "ID USUARIO")
            {
                txtdni.Text = "";
                txtdni.ForeColor = Color.LightGray;
            }
        }

        private void txtdni_Leave(object sender, EventArgs e)
        {
            if(txtdni.Text == "")
            {
                txtdni.Text = "ID USUARIO";
                txtdni.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if(txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }
        #endregion

        #region BOTONES
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region MOVIMIENTO DEL FORM
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCaptura();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMenssage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaptura();
            SendMenssage(this.Handle, 0x112, 0xf012, 0);
        }
        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaptura();
            SendMenssage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaptura();
            SendMenssage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
    }
}
