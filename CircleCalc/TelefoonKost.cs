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
            int beginMinInt = Convert.ToInt32(beginMinTxt.Text);
            int eindMinInt = Convert.ToInt32(eindMinTxt.Text);
            bool isDal = false;
            double gespreksPrijs = 0.0;
            string typGesprek = soortGesprekTxt.Text;
            bool juistGesprekType = true;

            if (beginUurInt <= eindUurInt)
            {
                duurVanGesprekMin = (eindUurInt*60 + eindMinInt) - (beginUurInt*60 + beginMinInt);
              
            } else 
            {
                //duurVanGesprek for times between different days
                duurVanGesprekMin = ((eindUurInt+24) * 60 + eindMinInt) - (beginUurInt * 60 + beginMinInt);
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
                default: juistGesprekType = false; break;
            }
            if (juistGesprekType)
            {
                resultaatTxt.Text = "Duur van oproep: " + duurVanGesprekMin + " minuten\r\nKosten van oproep: " + String.Format("{0:c}", gespreksPrijs);
                if (!isDal)
                {
                    resultaatTxt.Text += "\r\nPiekgesprek"; 
                }
            }
            else
            {
                resultaatTxt.Text = "Fout gesprektype!";
            }
        }

        private void wissenBtn_Click(object sender, EventArgs e)
        {
            resultaatTxt.Clear();
            soortGesprekTxt.Clear();
            eindMinTxt.Text = "0";
            eindUurTxt.Text = "0";
            beginMinTxt.Text = "0"; ;
            beginUurTxt.Text  = "0";;
            beginUurTxt.Focus();
        }
    }
}
