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
    public partial class VerwachteLengte : Form
    {
        public VerwachteLengte()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radGirl_CheckedChanged(object sender, EventArgs e)
        {
            boyTxt.Text = "";
            boyTxt.ReadOnly = true;
            girlTxt.ReadOnly = false;
        }

        private void radBoy_CheckedChanged(object sender, EventArgs e)
        {
            girlTxt.Text = "";
            girlTxt.ReadOnly = true;
            boyTxt.ReadOnly = false;
        }

        private void bereken_Click(object sender, EventArgs e)
        {
            Double fatherHeight = Convert.ToDouble(fatherTxt.Text);
            Double motherHeight = Convert.ToDouble(motherTxt.Text);
            Double result;

            if (radBoy.Checked)
            {
                result = (fatherHeight + motherHeight + 13) / 2 + 4.5;
                boyTxt.Text = String.Format("{000} cm", result);
            } else if (radGirl.Checked)
            {
                result = (fatherHeight + motherHeight - 13) / 2 + 4.5;
                girlTxt.Text = String.Format("{000} cm", result);
            }
        }

        private void sluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
