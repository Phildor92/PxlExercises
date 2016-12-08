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
    public partial class TrackbarTimer : Form
    {
        private Random maakRand = new Random();
        //private bool clicked = false;
        public TrackbarTimer()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value * 10;
            toolTip1.SetToolTip(trackBar1, trackBar1.Value.ToString());
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            /*if (clicked)
            {
                trackBar1.Visible = false;
                label0.Visible = false;
                label25.Visible = false;
                label50.Visible = false;
                timer1.Enabled = false;
                clicked = false;
            } else
            {
                trackBar1.Visible = true;
                label0.Visible = true;
                label25.Visible = true;
                label50.Visible = true;
                timer1.Enabled = true;
                clicked = true;
            }*/
            trackBar1.Visible = !trackBar1.Visible;
            label0.Visible = !label0.Visible;
            label25.Visible = !label25.Visible;
            label50.Visible = !label50.Visible;
            timer1.Enabled = !timer1.Enabled;
        }

        private void TrackbarTimer_Load(object sender, EventArgs e)
        {
            trackBar1.Visible = false;
            label0.Visible = false;
            label25.Visible = false;
            label50.Visible = false;
            
            timer1.Interval = trackBar1.Value * 10;
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            imgRandLoc.Left = maakRand.Next(0, this.ClientSize.Width - imgRandLoc.Width);
            imgRandLoc.Top = maakRand.Next(0, this.ClientSize.Height - imgRandLoc.Height);
        }
    }
}
