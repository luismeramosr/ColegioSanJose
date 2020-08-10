using System;
using System.Windows.Forms;
using Datalib;
using Domain;
using System.Collections.Generic;

namespace ColegioSanJose
{
    public partial class FormTest : Form
    {
        AlternativaArrayComponent ac;
        

        public FormTest()
        {
            InitializeComponent();
            ac = new AlternativaArrayComponent();
            Controls.Add(ac);
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            ac.push();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            ac.pop();
        }
    }
}
