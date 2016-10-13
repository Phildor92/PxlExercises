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
    public partial class Falculteit : Form
    {
        public Falculteit()
        {
            InitializeComponent();
        }

        private void berekenBtn_Click(object sender, EventArgs e)
        {
            Int32 getalInt = Convert.ToInt32(getalTxt.Text);
            Int32 faculteit = 1;

            if (getalInt > 2)
            {
                for (int i = getalInt; i > 1; i--)
                {
                    faculteit *= i;
                }
            } else
            {
                faculteit = 1;
            }

            resultaatTxt.Text = faculteit.ToString();
        }
    }
}
