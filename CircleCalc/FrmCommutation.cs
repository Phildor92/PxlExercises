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
    public partial class FrmCommutation : Form
    {
        const int aantalNummers = 10;

        public FrmCommutation()
        {
            InitializeComponent();
        }

        private void FrmCommutation_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random bepaalRand = new Random();           
            int[] getal1 = new int[aantalNummers];
            int[] getal2 = new int[aantalNummers];
            int[] som = new int[aantalNummers];
            txtResultaat.Clear();
            for (int i = 0; i < aantalNummers; i++)
            {
                getal1[i] = bepaalRand.Next(0, 11);
                getal2[i] = bepaalRand.Next(0, 11);
                som[i] = getal1[i] + getal2[i];
            }
            for (int i = 0; i < aantalNummers; i++)
            {
                txtResultaat.Text += String.Format(getal1[i].ToString().PadRight(3) + " + " + getal2[i].ToString().PadRight(3) + " = " + som[i].ToString().PadRight(3) + Environment.NewLine);
            }
            txtResultaat.Text += Environment.NewLine;
            for (int i = 0; i < aantalNummers; i++)
            {
                txtResultaat.Text += String.Format(getal2[i].ToString().PadRight(3) + " + " + getal1[i].ToString().PadRight(3) + " = " + som[i].ToString().PadRight(3) + Environment.NewLine);
            }
            
        }
    }
}
