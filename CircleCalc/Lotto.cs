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
    public partial class Lotto : Form
    {
        private Random maakRand = new Random();
        public Lotto()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtResultaat.Text = "De 6 LOTTO-getallen zijn: \r\n";
            int volgnr = 1;
            RegelToevoegen(volgnr);
            volgnr++;
            RegelToevoegen(volgnr);
            volgnr++;
            RegelToevoegen(volgnr);
            volgnr++;
            RegelToevoegen(volgnr);
            volgnr++;
            RegelToevoegen(volgnr);
            volgnr++;
            RegelToevoegen(volgnr);
            volgnr++;
        }

        private void RegelToevoegen(int nr)
        {
            int lottogetal = maakRand.Next(1, 46);
            txtResultaat.AppendText("Getal " + nr + " : " + lottogetal + "\r\n");
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            txtResultaat.Text = "De 6 LOTTO-getallen zijn: \r\n";
            for(int i = 1; i < 7; i++)
            {
                RegelToevoegen(i);
            }
        }

        private void btnStart3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtResultaat.Text = "De LOTTO-getallen zijn: \r\n";
            for (int i = 1; i < 1000; i++)
            {
                RegelToevoegen(i);
            }
            timer1.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
