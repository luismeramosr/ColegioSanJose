using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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
            vali_login();
        }

        #region VALIDACION_LOGIN
        public void vali_login()
        {
            try
            {
                if (txtdni.Text != "DNI USUARIO")
                {
                    if (txtpass.Text != "CONTRASEÑA")
                    {
                        Usermodel user = new Usermodel();
                        var validLogin = user.LoginUser(txtdni.Text, txtpass.Text);
                        //Console.WriteLine(validLogin);
                        if (validLogin == true)
                        {
                            FormPrincipal mainMenu = new FormPrincipal();
                            mainMenu.Show();
                            //this.Hide();
                        }
                        else
                        {
                            msgError("DNI o Contraseña Incorrecta");
                            txtpass.Clear();
                            txtdni.Focus();
                        }
                    }
                    else
                    {
                        msgError("Ingrese su Contraseña");
                    }

                }
                else
                {
                    msgError("Ingrese su DNI");
                }
            }
            catch
            {
                msgError("Problemas de conneción");
            }

           
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
            if(txtdni.Text == "DNI USUARIO")
            {
                txtdni.Text = "";
                txtdni.ForeColor = Color.LightGray;
            }
        }

        private void txtdni_Leave(object sender, EventArgs e)
        {
            if(txtdni.Text == "")
            {
                txtdni.Text = "DNI USUARIO";
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
