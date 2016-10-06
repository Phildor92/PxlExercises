using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bereken_Click(object sender, EventArgs e)
        {
            Double radius = Convert.ToDouble(radiusTxt.Text);
            Double surface, circumference;

            surface = (radius * radius) * Math.PI;
            circumference = 2 * Math.PI * radius;

            surfaceTxt.Text = surface + "";
            cirmcumferenceTxt.Text = String.Format("{0:00.00}", circumference);
        }

        private void wissen_Click(object sender, EventArgs e)
        {
            surfaceTxt.Text = "";
            cirmcumferenceTxt.Text = "";
            radiusTxt.Text = "";
        }
    }
}
