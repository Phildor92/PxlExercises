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
    public partial class BerekeningFietsvergoeding : Form
    {
        public BerekeningFietsvergoeding()
        {
            InitializeComponent();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void berekenBtn_Click(object sender, EventArgs e)
        {
            resultaatTxt.Clear();
            String[] personen = new String[] { naamTxt1.Text, naamTxt2.Text, naamTxt3.Text, naamTxt4.Text, naamTxt5.Text, naamTxt6.Text };
            Int32[] aantalVerpl = new Int32[] { Convert.ToInt32(totAantal1.Text), Convert.ToInt32(totAantal2.Text), Convert.ToInt32(totAantal3.Text), Convert.ToInt32(totAantal4.Text), Convert.ToInt32(totAantal5.Text), Convert.ToInt32(totAantal6.Text) };
            Double[] aantalKm = new Double[] { Convert.ToDouble(kmPerVerpl1.Text), Convert.ToDouble(kmPerVerpl2.Text), Convert.ToDouble(kmPerVerpl3.Text), Convert.ToDouble(kmPerVerpl4.Text), Convert.ToDouble(kmPerVerpl5.Text), Convert.ToDouble(kmPerVerpl6.Text) };

            Double[] totaalKms = new Double[personen.Length];
            String[] resultaten = new String[personen.Length];
            Double[] kosten = new Double[personen.Length];

            for (int i = 0; i < personen.Length; i++)
            {
                totaalKms[i] = aantalVerpl[i] * aantalKm[i] * 2;
                kosten[i] = aantalVerpl[i] * aantalKm[i] * 2 * 0.15;
                resultaten[i] = personen[i] + "\t\t : " + String.Format("{0:00}",aantalVerpl[i]) + " verplaatsingen -  " + String.Format("{0:00}", totaalKms[i]) + " km in totaal afgelegd -\t vergoeding: \t" + String.Format("{0:c}", kosten[i]); 
            }

            resultaatTxt.Lines = resultaten;
        }

        private void wissen_Click(object sender, EventArgs e)
        {
            naamTxt1.Text = "";
            naamTxt2.Text = "";
            naamTxt3.Text = "";
            naamTxt4.Text = "";
            naamTxt5.Text = "";
            naamTxt6.Text = "";
            totAantal1.Text = "0";
            totAantal2.Text = "0";
            totAantal3.Text = "0";
            totAantal4.Text = "0";
            totAantal5.Text = "0";
            totAantal6.Text = "0";
            kmPerVerpl1.Text = "0";
            kmPerVerpl2.Text = "0";
            kmPerVerpl3.Text = "0";
            kmPerVerpl4.Text = "0";
            kmPerVerpl5.Text = "0";
            kmPerVerpl6.Text = "0";
        }

        private void altBereken_Click(object sender, EventArgs e)
        {
            resultaatTxt.Clear();
            BerekenEnVoegToeAanTxtReusltaat(naamTxt6.Text, totAantal6.Text, kmPerVerpl6.Text);
            //... 6x 


        }

        private void BerekenEnVoegToeAanTxtReusltaat(string naam, string totAantal, string kmPerVerpl)
        {
            double totaalKm;
            double vergoeding;

            totaalKm = Convert.ToDouble(totAantal) * Convert.ToDouble(kmPerVerpl) * 2;
            vergoeding = totaalKm * 0.15;

            resultaatTxt.AppendText("\n" + naam + " verplaatsingen: " + totAantal + " totale km: " + totaalKm + " km en vergoeding: " + vergoeding);
            //resultaatTxt.Text = "This\r\nshould\nbe\non\nnew\nlines" + Environment.NewLine + "As should this";
            //\n on its own does not add new line in a text box, but Environment.NewLine or \r\n does...
        }
    }
}
