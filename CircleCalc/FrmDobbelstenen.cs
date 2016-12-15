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
    public partial class FrmDobbelstenen : Form
    {
        int[] aantalWorpen = new int[11];
        int worpenTeller;

        public FrmDobbelstenen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtInterval.Text != "")
            {
                Array.Clear(aantalWorpen, 0, aantalWorpen.Length);
                txtDebug.Clear();
                txt100Worpen.Clear();
                worpenTeller = 0;
                rollTimer.Interval = Convert.ToInt32(txtInterval.Text);
                rollTimer.Start();
            }
        }

        private void btnWorp_Click(object sender, EventArgs e)
        {
            rollDice();           
        }

        private void FrmDobbelstenen_Load(object sender, EventArgs e)
        {
            txtInterval.Text = "100";
            txtKiesAantal.Text = "100";
            txtDebug.Visible = false;
        }

        private void rollTimer_Tick(object sender, EventArgs e)
        {
            if(worpenTeller < Convert.ToInt32(txtKiesAantal.Text))
            {
                aantalWorpen[rollDice()-2]++;
                worpenTeller++;
            } else
            {
                rollTimer.Stop();
                for(int i = 0; i < aantalWorpen.Length; i++)
                {
                    txt100Worpen.AppendText("Aantaal keer " + (i + 2) + " = " + aantalWorpen[i] + Environment.NewLine);
                }
            }
            
        }

        private int rollDice()
        {
            Random randGen = new Random();
            int worp1 = randGen.Next(1, 7);
            int worp2 = randGen.Next(1, 7);

            txtWorp.AppendText("Worp 1 is: " + worp1 + ". Worp 2 is: " + worp2 + ". Som van de worpen is: " + (worp1 + worp2));
            txtDebug.AppendText(worpenTeller + " " +  worp1 + " " + worp2 + "\r\n");
            return worp1 + worp2;          
        }

        private void btnToggleDebug_Click(object sender, EventArgs e)
        {
            txtDebug.Visible = !txtDebug.Visible;
        }
    }
}
