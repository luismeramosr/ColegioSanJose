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
    public partial class AlternativaComponent : UserControl
    {        
        public AlternativaComponent()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if(btnCambiar.Text == "Cambiar")
            {
                rb.Hide();
                txtAlternativa.Show();
                txtAlternativa.Text = "";
                txtAlternativa.Focus();
                btnCambiar.Text = "Guardar";
                return;
            }else if(btnCambiar.Text == "Guardar")
            {
                rb.Show();
                txtAlternativa.Hide();
                rb.Text = txtAlternativa.Text;
                btnCambiar.Text = "Cambiar";
                return;
            }
        }
    }
}
