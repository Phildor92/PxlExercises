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
    public partial class FrmRandom : Form
    {
        private int somWaarden;       
        private int aantalBepalingen = 0;

        public FrmRandom()
        {
            InitializeComponent();
        }

        private void btnNieuweWaarde_Click(object sender, EventArgs e)
        {
            double gemiddelde;
            aantalBepalingen ++;
            Random willekeurigBepaling = new Random();
            int willekeurigGetal = willekeurigBepaling.Next(200,401);
            randTxt.Text = willekeurigGetal.ToString();

            somWaarden += willekeurigGetal;
            somWaardenTxt.Text = somWaarden.ToString();

            gemiddelde = Convert.ToDouble(somWaarden) / aantalBepalingen; //division make sure double is involved
            gemiddeldeTxt.Text = String.Format("{0:0.00}",gemiddelde);
        }
    }
}
