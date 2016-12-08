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
    public partial class FrmMaandNamen : Form
    {
        private string[] maanden = new string[] { "januari", "februari", "maart", "april", "mei", "juni", "juli", "augustus", "september", "oktober", "november", "december" };
        

        public FrmMaandNamen()
        {
            InitializeComponent();
        }

        private void btnVulMetMaandNamen_Click(object sender, EventArgs e)
        {
            foreach (string item in maanden)
            {
                txtMaanden.Text += item + Environment.NewLine;
            }
        }

        private void btnGewoon_Click(object sender, EventArgs e)
        {
            txtMaanden.Text = "";
            for (int i = 0; i < maanden.Length; i++)
            {
                txtMaanden.Text += toonMaand(i);
            }
        }

        private void btnOmgekeerd_Click(object sender, EventArgs e)
        {
            txtMaanden.Text = "";
            for(int i = maanden.Length-1; i>=0; i--)
            {
                txtMaanden.Text += toonMaand(i);
            }
        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            txtMaanden.Text = "";
            for (int i = 0; i < maanden.Length; i++)
            {
                if (i % 2 > 0)
                {
                    txtMaanden.Text += toonMaand(i);
                }
                
            }
        }

        private void btnOneven_Click(object sender, EventArgs e)
        {
            txtMaanden.Text = "";
            for (int i = 0; i < maanden.Length; i++)
            {
                if (i % 2 == 0)
                {
                    txtMaanden.Text += toonMaand(i);
                }
            }
        }

        private string toonMaand(int i)
        {
            return i + 1 + " - " + maanden[i] + Environment.NewLine;            
        }

        private void btnAlfabetisch_Click(object sender, EventArgs e)
        {
            //optionally sort this array: string[] sorteerbaarMaanden = maanden;
            int[] maandnr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Array.Sort(maanden, maandnr); //permanent change obviously
            txtMaanden.Text = "";
            for (int i = 0; i < maanden.Length; i++)
            {
                txtMaanden.Text += maandnr[i] + " - " + maanden[i] + Environment.NewLine;
            }
            Array.Sort(maandnr, maanden); //sort reverted to original order based on month number array
        }

        private void btnWissen_Click(object sender, EventArgs e)
        {
            txtMaanden.Clear();
        }

        private void btnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
