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
    public partial class FrmMeetkundigeFiguur : Form
    {
        int vormGrootteTim = 0;
        int tellerHor = 0;
        int tellerVert = 0;

        public FrmMeetkundigeFiguur()
        {
            InitializeComponent();
        }

        private void volVierkant_Click(object sender, EventArgs e)
        {
            int vormGrootte = Convert.ToInt32(txtGrootte.Text);

            for(int i = 0; i<vormGrootte; i++)
            {
                for(int j = 0; j<vormGrootte; j++)
                {
                    txtResultaat.AppendText("* ");
                }
                txtResultaat.AppendText(Environment.NewLine);
            }
        }

        private void btnVierkant_Click(object sender, EventArgs e)
        {
            int vormGrootte = Convert.ToInt32(txtGrootte.Text);

            for (int i = 0; i < vormGrootte; i++)
            {
                txtResultaat.AppendText("* ");
            }
            txtResultaat.AppendText(Environment.NewLine);
            for (int i = 0; i < vormGrootte - 2; i++)
            {
                txtResultaat.AppendText("* ");
                for (int j = 0; j < vormGrootte - 2; j++)
                {
                    txtResultaat.AppendText("  ");
                }
                txtResultaat.AppendText("* ");
                txtResultaat.AppendText(Environment.NewLine);
            }
            for (int i = 0; i < vormGrootte; i++)
            {
                txtResultaat.AppendText("* ");
            }
              
        }

        private void btnDriehoek_Click(object sender, EventArgs e)
        {
            int vormGrootte = Convert.ToInt32(txtGrootte.Text);

            for (int i = 1; i <= vormGrootte; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    txtResultaat.AppendText("* ");
                }
                txtResultaat.AppendText(Environment.NewLine);
            }
        }

        private void btnOpbouw_Click(object sender, EventArgs e)
        {
            txtResultaat.Clear();
            vormGrootteTim = Convert.ToInt32(txtGrootte.Text);
            tellerHor = 0;
            tellerVert = 1;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
            if (tellerHor < vormGrootteTim)
            {
                txtResultaat.AppendText("* ");
                tellerHor++;
            } else if(tellerVert < vormGrootteTim)
            {
                txtResultaat.AppendText(Environment.NewLine);
                tellerHor = 0;
                tellerVert++;
            }          
        }

        private void btnRuit_Click(object sender, EventArgs e)
        {
            int vormGrootte = Convert.ToInt32(txtGrootte.Text);

            txtResultaat.AppendText("*");
            txtResultaat.AppendText(Environment.NewLine);
            for (int i = 1; i <= vormGrootte; i++)
            {
                txtResultaat.AppendText("*");
                for (int j = 0; j < i; j++)
                {
                    txtResultaat.AppendText("**");
                }
                txtResultaat.AppendText(Environment.NewLine);
            }
            for (int i = vormGrootte-1; i >= 0; i--)
            {
                txtResultaat.AppendText("*");
                for (int j = 0; j < i; j++)
                {
                    txtResultaat.AppendText("**");
                }
                txtResultaat.AppendText(Environment.NewLine);
            }
        }
    }
}
