using Datalib;
using Domain;
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
    
    public partial class FormPerfilUser : Form
    {
        Dictionary<string, object> data;
        int lx, ly;

        //MySQLManager db = new MySQLManager("gator4125.hostgator.com", "apolloma_root", "!Rg[5b1mzuOV", "apolloma_Colegio");
        MySQLManager db = new MySQLManager("localhost", "3306", "root", "SYSTEM", "apolloma_Colegio");

        public FormPerfilUser(Dictionary<string, object> data)
        {
            Usuario user = (Usuario)data["user"];
            InitializeComponent();
            PosicionInicial();
            this.data = data;
            txtNombre.Text = user.nombre;
            txtApellido.Text = user.apellidos;
            txtEdad.Text = user.edad.ToString();
            txtEmail.Text = user.correo;
            editardatos();

        }
        private void actualizarform(Usuario olduser)
        {
            Usuario user = db.readRow(olduser,olduser.idUsuario);
            txtNombre.Text = user.nombre;
            txtApellido.Text = user.apellidos;
            txtEdad.Text = user.edad.ToString();
            txtEmail.Text = user.correo;
           

        }
        private void actulizardatos(object sender, EventArgs e)
        {
            Usuario user = (Usuario)data["user"];
            user.nombre = txt_edNombre.Text;
            user.apellidos = txt_edApellido.Text;
            user.edad = int.Parse(txt_edEdad.Text);
            user.correo = txt_edEmail.Text;
            db.updateRow(user);
            actualizarform(user);
        }

        private void editardatos()
        {
            txt_edNombre.Text = txtNombre.Text;
            txt_edApellido.Text = txtApellido.Text;
            txt_edEdad.Text = txtEdad.Text;
            txt_edEmail.Text = txtEmail.Text;
        }

        private void PosicionInicial()
        {
            lx = pldatos.Location.X;
            ly = pldatos.Location.Y;

            pldatos.Location = new Point(
            this.ClientSize.Width / 2 - pldatos.Size.Width / 2,
            this.ClientSize.Height / 2 - pldatos.Size.Height / 2);
            pldatos.Anchor = AnchorStyles.None;
            plEditarDatos.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PosicionInicial();
            editardatos();
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            pldatos.Location = new Point(
            this.ClientSize.Width / 3 - pldatos.Size.Width / 2,
            this.ClientSize.Height / 2 - pldatos.Size.Height / 2);
            pldatos.Anchor = AnchorStyles.Left;
            plEditarDatos.Visible = true;
        }
        
    }
}
