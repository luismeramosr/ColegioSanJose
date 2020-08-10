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
    public partial class PreguntaComponent : UserControl
    {
        AlternativaArrayComponent ac;

        public PreguntaComponent()
        {
            InitializeComponent();
            Visible = false;
            ac = new AlternativaArrayComponent();
            Controls.Add(ac);
            ac.Dock = DockStyle.Bottom;
        }

        //A00023249

        private void PreguntaComponent_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                cb_fonts.Items.Add(font.Name.ToString());
            }
        }        

        #region btncolor, btnfonts, btnsize
        private void btncolor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
            plcolor.BackColor = colorDialog1.Color;
        }

        private void cb_fonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SelectionFont = new Font(cb_fonts.Text, richTextBox1.SelectionFont.Size);
            }
            catch { }
          
        }

        private void cb_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, float.Parse(cb_size.SelectedItem.ToString()));
            }
            catch { }
            
        }
        #endregion

        #region position text
        private void btnCentrar_Click(object sender, EventArgs e)
        {
            
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnleft_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            
        }

        private void btnright_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        #endregion

        private void btnlist_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = true;
            richTextBox1.AcceptsTab = true;
        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                richTextBox1.SelectionIndent = 30;
            }
            if (e.KeyCode == Keys.Enter)
            {
                richTextBox1.SelectionIndent = 0;
            }
        }
    }
}
