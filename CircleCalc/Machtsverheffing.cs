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
    public partial class Machtsverheffing : Form
    {
        public Machtsverheffing()
        {
            InitializeComponent();
        }

        private void berekenBtn_Click(object sender, EventArgs e)
        {
            double verheffing = 0;
            Int32 getalInt = Convert.ToInt32(getalTxt.Text);
            for (int i = 1; i<11; i++)
            {
                verheffing = Math.Pow(getalInt, i);
                resultaatTxt.Text += "Mach " + i + " van " + getalInt + " is " + verheffing.ToString() + Environment.NewLine;
            }
        }

        private void wissenBtn_Click(object sender, EventArgs e)
        {
            resultaatTxt.Text = "";
            getalTxt.Text = "";
        }

        private void sluitenBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
