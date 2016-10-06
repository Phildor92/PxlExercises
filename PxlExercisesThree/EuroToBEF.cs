using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PxlExercisesThree
{
    public partial class EuroToBEF : Form
    {
        public EuroToBEF()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void berekenen_Click(object sender, EventArgs e)
        {
            double befAmount;

            befAmount = Convert.ToDouble(euroTxt.Text) * 40.3399;

            befText.Text = befAmount + "";
        }

        private void wissen_Click(object sender, EventArgs e)
        {
            euroTxt.Text = "";
            befText.Text = "";
        }
    }
}
