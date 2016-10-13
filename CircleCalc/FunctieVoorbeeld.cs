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
    public partial class FunctieVoorbeeld : Form
    {
        public FunctieVoorbeeld()
        {
            InitializeComponent();
        }

        private void berekenBtn_Click(object sender, EventArgs e)
        {
            double oppCyl = berekenOppervlakteCylinder(straalTxt1.Text, hoogteTxt1.Text);
            oppTxt1.Text = Convert.ToString(oppCyl);
            double oppCy2 = berekenOppervlakteCylinder(straalTxt2.Text, hoogteTxt2.Text);
            oppTxt2.Text = Convert.ToString(oppCy2);
            double oppCy3 = berekenOppervlakteCylinder(straalTxt3.Text, hoogteTxt3.Text);
            oppTxt3.Text = Convert.ToString(oppCy3);

            //prijs1.Text = Convert.ToString(oppCyl * 2);
            prijs1.Text = String.Format("{0:c}", prijsVoorVerven(oppCyl));
            prijs2.Text = String.Format("{0:c}", (oppCy2 * 2));
            prijs3.Text = String.Format("{0:c}", (oppCy3 * 2));
        }

        private double berekenOppervlakteCylinder(string straalTxt, string hoogteTxt)
        {
            double straalDouble = Convert.ToDouble(straalTxt);
            double hoogteDouble = Convert.ToDouble(hoogteTxt);
            double oppMantel, oppCirc, totOpp;

            oppCirc = (straalDouble * straalDouble) * Math.PI;
            oppMantel = straalDouble * 2 * Math.PI * hoogteDouble;
            totOpp = (oppCirc * 2) + oppMantel;

            return totOpp;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private double prijsVoorVerven(double oppervlakte)
        {
            return oppervlakte * 2;
        }
    }
}
