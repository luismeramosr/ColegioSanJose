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
    public partial class AlternativaArrayComponent : UserControl
    {
        List<AlternativaComponent> alternativas = new List<AlternativaComponent>();

        public AlternativaArrayComponent()
        {
            InitializeComponent();
            push();
            push();
            push();
        }

        public void push()
        {                     
            if (alternativas.Count > 0)
            {
                alternativas.Add(new AlternativaComponent());
                alternativas.ElementAt(alternativas.Count-1).rb.Click += RB_Clicked;
                alternativas.ElementAt(alternativas.Count-1).Location = new Point(30,
                                    alternativas.ElementAt(alternativas.Count-2).Location.Y+34);
            }else if (alternativas.Count == 0)
            {
                alternativas.Add(new AlternativaComponent());
                alternativas.ElementAt(0).rb.Click += RB_Clicked;
                alternativas.ElementAt(0).Location = new Point(0,0);
            }
            Console.WriteLine(alternativas.Count);
            Controls.AddRange(alternativas.ToArray());
        }

        private void RB_Clicked(object sender, EventArgs e)
        {
            RadioButton selected = ((RadioButton) sender);
            foreach(AlternativaComponent alt in alternativas)
            {
                if (alt.rb.Equals(selected))
                    Console.WriteLine(alternativas.IndexOf(alt));
                else
                    alt.rb.Checked = false;
            }
        }

        public void pop()
        {            
            foreach(AlternativaComponent alternativa in alternativas)
            {
                Controls.Remove(alternativa);
            }
            alternativas.RemoveAt(alternativas.Count - 1);
            Controls.AddRange(alternativas.ToArray());
            Console.WriteLine(alternativas.Count);
        }

    }
}
