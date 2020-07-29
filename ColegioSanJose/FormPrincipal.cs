using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;

namespace ColegioSanJose
{
    public partial class FormPrincipal : Form
    {
        Dictionary<string, object> data;
        public FormPrincipal(Dictionary<string, object> data)
        {
            InitializeComponent();
            Designsubmenu();
            this.data = data;
            btnPerfil.Text = data["userType"].ToString();
            this.data = data;
        }

        

        #region Forma del panelcontenedor
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            //lineas diagonales
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        #endregion

        #region Botones close, min , max
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;

        bool isMaximized = false;
        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            panelForm.Size = Size;
            panelForm.Location = Location;
            btnmaximizar.Visible = false;
            btnrestaurar.Visible = true;
            actualizarForm();

        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            btnmaximizar.Visible = true;
            btnrestaurar.Visible = false;
            isMaximized = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            panelForm.Size = new Size(sw,sh);
            actualizarForm();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Mover Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelBarra_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private Form activeForm()
        {
            return isMaximized ? (Form)panelForm.GetChildAtPoint(new Point(400, 150)): 
                                    new Form();
        }

        private void actualizarForm()
        {
            Form form = activeForm();
            if (form != null)
            {
                form.Size = panelForm.Size;
                form.BringToFront();
            }
        }

        #region Metodo para abrir Formularios dentro el panel
        Form formulario = new Form();
        private void Abrirformulario<MiForm>() where MiForm : Form, new()
        {
            formulario = panelForm.Controls.OfType<MiForm>().FirstOrDefault();//busca en la coleccion del form
            //si el form no existe
            if (formulario == null)
            {
                
                formulario = new MiForm();
                formulario.Size = panelForm.Size;
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelForm.Controls.Add(formulario);
                panelForm.Tag = formulario;
                formulario.BringToFront();
                formulario.Show();
                formulario.FormClosed += new FormClosedEventHandler(cerrarform);
            }
            //si el form existe
            else
            {
                formulario.Size = panelForm.Size;
                formulario.BringToFront();
            }
        }
        #endregion

        private void abrirFormBtnCursos()
        {
            formulario = panelForm.Controls.OfType<FormBtnCursos>().FirstOrDefault();//busca en la coleccion del form
            if (formulario == null)
            {
                formulario = new FormBtnCursos(data);
                formulario.Size = panelForm.Size;
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelForm.Controls.Add(formulario);
                panelForm.Tag = formulario;
                formulario.BringToFront();
                formulario.Show();
                formulario.FormClosed += new FormClosedEventHandler(cerrarform);
            }
            //si el form existe
            else
            {
                formulario.Size = panelForm.Size;
                formulario.BringToFront();
            }
        }

        #region Botones del menu (abrir forms)

        private void btnCursos_Click(object sender, EventArgs e)
        {
            abrirFormBtnCursos();
            btnCursos.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            Abrirformulario<FormPerfilUser>();
            btnPerfil.BackColor = Color.FromArgb(12, 61, 92);

        }

        private void cerrarform(object sender,FormClosedEventArgs e)
        {
            if (Application.OpenForms["FormPerfilUser"] == null)
                btnPerfil.BackColor = Color.FromArgb(28, 28, 28);
            if (Application.OpenForms["FormBtnCursos"] == null)
                btnCursos.BackColor = Color.FromArgb(28, 28, 28);
            //if (Application.OpenForms["Form3"] == null)
            //    btnHorario.BackColor = Color.FromArgb(28, 28, 28);
            ////submenu
            //if (Application.OpenForms["Form4_submenu"] == null)
            //    btnconfuser.BackColor = Color.FromArgb(45, 45, 48);
        }
        #endregion

        #region Timer panelMenu
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 220)
            {
                tmOcultarMenu.Enabled = true;
            }
            else if (panelMenu.Width == 60)
            {
                tmMostrarMenu.Enabled = true;
            }


        }
        private void tmOcultarMenu_Tick(object sender, EventArgs e)
        {
            if(panelMenu.Width <= 60)
            {
                tmOcultarMenu.Enabled = false;
            }else
            {
                panelMenu.Width = panelMenu.Width - 40;
            }

        }
        private void tmMostrarMenu_Tick(object sender, EventArgs e)
        {
            if(panelMenu.Width >= 220)
            {
                tmMostrarMenu.Enabled = false;
            }else
            {
                panelMenu.Width = panelMenu.Width + 40;
            }

        }
        #endregion

        #region SubMenu
        //submenus opcional
        private void Designsubmenu()
        {
            panelDespegable.Visible = false;
        }

        private void hidesubmenu()
        {
            if (panelDespegable.Visible == true)
                panelDespegable.Visible = false;
        }

        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private void btnconf_Click(object sender, EventArgs e)
        {
            showsubmenu(panelDespegable);            
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            (new FormLogin()).Show();
        }

        private void btnconfuser_Click(object sender, EventArgs e)
        {
            //Abrirformulario<Form4_submenu>();
            //btnconfuser.BackColor = Color.FromArgb(12, 61, 92);
            //hidesubmenu();
        }
        #endregion

        #region Hora y fecha
        private void tmHoraFecha_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
            lbfecha.Text = DateTime.Now.ToLongDateString();
        }
        #endregion

    }
}
