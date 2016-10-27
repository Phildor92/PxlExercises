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
    public partial class ResizableFrm : Form
    {
        public ResizableFrm()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtWaarde.Text = trackBar1.Value.ToString();
            resizeImg.Width = trackBar1.Value;
            resizeImg.Height = Convert.ToInt32(trackBar1.Value * 100.0 / 166);
            toolTip1.SetToolTip(trackBar1, trackBar1.Value.ToString());
        }

        private void ResizableFrm_Load(object sender, EventArgs e)
        {
            txtWaarde.Text = trackBar1.Value.ToString();
        }
    }
}
