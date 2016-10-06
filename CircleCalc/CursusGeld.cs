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
    public partial class CursusGeld : Form
    {
        public CursusGeld()
        {
            InitializeComponent();
        }

        private void bereken_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(jaarTxt.Text);
            if (year % 4 == 0)
            {
                isLeap.Visible = true;
                if (year % 100 == 0 && year % 400 != 0)
                {
                    isLeap.Visible = false;
                }
            }
            else
            {
                isLeap.Visible = false;
            }
            int hours = Convert.ToInt32(lesuurTxt.Text);
            double cost;

            if (DateTime.IsLeapYear(year))
            {
                hours++;
            }
            cost = hours * 1.5;

            geldTxt.Text = String.Format("{0:00.00}",cost);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void testNumeriek_Click(object sender, EventArgs e)
        {
            string year = jaarTxt.Text;
            int number;
            bool result = Int32.TryParse(year, out number);
            isNum.Visible = result;
        }

        private void jaarTxt_TextChanged(object sender, EventArgs e)
        {
            isNum.Visible = false;
        }
    }
}
