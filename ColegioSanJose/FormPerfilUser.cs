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
        DBManager db = new DBManager("localhost", "3306", "root", "SYSTEM", "apolloma_colegio");
        public FormPerfilUser(Dictionary<string, object> data)
        {
            Usuario user = (Usuario)data["user"];
            InitializeComponent();
            PosicionInicial();
            this.data = data;
            lbnombre.Text = user.nombre;
            lbapellido.Text = user.apellidos;
            lbyears.Text = user.edad.ToString();
            lbcorreo.Text = user.correo;
            editardatos();

        }
        private void actualizarform(Usuario olduser)
        {
            Usuario user = db.readRow(olduser,olduser.idUsuario);
            lbnombre.Text = user.nombre;
            lbapellido.Text = user.apellidos;
            lbyears.Text = user.edad.ToString();
            lbcorreo.Text = user.correo;
           

        }
        private void actulizardatos(object sender, EventArgs e)
        {
            Usuario user = (Usuario)data["user"];
            user.nombre = lbnombre.Text;
            user.apellidos = lbapellido.Text;
            user.edad = int.Parse(lbyears.Text);
            user.correo = lbcorreo.Text;
            db.updateRow(user);
            actualizarform(user);
        }

        private void editardatos()
        {
            txtNomUser.Text = lbnombre.Text;
            txtapellido.Text = lbapellido.Text;
            txtedad.Text = lbyears.Text;
            txtemail.Text = lbcorreo.Text;
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

        private void btncamcelar_Click(object sender, EventArgs e)
        {
            PosicionInicial();
            editardatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pldatos.Location = new Point(
            this.ClientSize.Width / 3 - pldatos.Size.Width / 2,
            this.ClientSize.Height / 2 - pldatos.Size.Height / 2);
            pldatos.Anchor = AnchorStyles.Left;
            plEditarDatos.Visible = true;
        }



        

    }
}
