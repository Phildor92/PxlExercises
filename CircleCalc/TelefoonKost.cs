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
    public partial class TelefoonKost : Form
    {
        public TelefoonKost()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void berekenBtn_Click(object sender, EventArgs e)
        {
            int duurVanGesprekMin = 0;
            int beginUurInt = Convert.ToInt32(beginUurTxt.Text);
            int eindUurInt = Convert.ToInt32(eindUurTxt.Text);
            int beginMinInt = Convert.ToInt32(beginMinuutTxt.Text);
            int eindMinInt = Convert.ToInt32(eindMinTxt.Text);
            bool isDal = false;
            double gespreksPrijs = 0.0;
            string typGesprek = soortGesprekTxt.Text;

            if (beginUurInt <= eindUurInt)
            {
                duurVanGesprekMin = eindUurInt*60 - beginUurInt*60;
                if (beginMinInt <= eindMinInt)
                {
                    duurVanGesprekMin += eindMinInt - beginMinInt;
                }
                else
                {
                    duurVanGesprekMin += (eindMinInt + 60) - beginMinInt;
                }
            } else //does not account for start minute and end minute being the same
            {
                //duurVanGesprek for times between different days
                duurVanGesprekMin = (eindUurInt+24)*60 - beginUurInt*60;
                if (beginMinInt <= eindMinInt)
                {
                    duurVanGesprekMin += eindMinInt - beginMinInt;
                } else
                {
                    duurVanGesprekMin += (eindMinInt+60) - beginMinInt;
                }
            }

            if ((beginUurInt > 16 || beginUurInt < 8) && ((eindUurInt > 16) || (eindUurInt < 8)))
            {
                isDal = true;
            } else
            {
                isDal = false;
            }
            switch (typGesprek)
            {
                case "z":
                    if (isDal)
                    {
                        gespreksPrijs = 0;
                    } else
                    {
                        gespreksPrijs = duurVanGesprekMin*0.02;
                    };break;
                case "n":
                    if (isDal)
                    {
                        gespreksPrijs = duurVanGesprekMin * 0.02;
                    } else
                    {
                        gespreksPrijs = duurVanGesprekMin * 0.05;
                    };break;
                case "i":
                    gespreksPrijs = duurVanGesprekMin * 0.1;
                    break;
                case "g":
                    gespreksPrijs = duurVanGesprekMin * 0.15;
                    break;
                default: break;
            }
            

            resultaatTxt.Text = isDal + "\r\n" + String.Format("{0:00}",duurVanGesprekMin) + " minuten\r\n" + "\r\nPrijs van gesprek: " + String.Format("{0:c}",gespreksPrijs);
        }   
    }
}
