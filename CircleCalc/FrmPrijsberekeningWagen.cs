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
    public partial class FrmPrijsberekeningWagen : Form
    {
        private int[] aantalBerekeningen = new int[7];

        public FrmPrijsberekeningWagen()
        {
            InitializeComponent();
        }

        private void FrmPrijsberekeningWagen_Load(object sender, EventArgs e)
        {
            //radiale knoppen
            radBenzine.Checked = true;

            //Tijd initialiseren en timer starten
            lblTijd.Text = DateTime.Now.ToString("HH:mm:ss");
            tijdTimer.Start();

            //modellen lijst aanmaken en eerste selecteren
            String[] modellen = new String[] { "C1", "C3", "C3 Picasso", "C4", "C4 Picasso", "Cactus", "C5" };
            for (int i = 0; i<modellen.Length; i++)
            {
                lstModel.Items.Add(modellen[i]);
            }
            lstModel.SelectedIndex = 0;

            //Aantal jaren op nul zetten
            txtAantalJaren.Text = "0";

            //kleur op lichtblauw zetten
            this.BackColor = Color.LightBlue;
        }

        private void lstModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            picAfbeelding.Image = Image.FromFile("C:/pic/wagen" + lstModel.SelectedIndex + ".png");
        }

        private void tijdTimer_Tick(object sender, EventArgs e)
        {
            lblTijd.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            txtAantalJaren.Clear();
            txtResultaat.Clear();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            txtResultaat.Clear();
            int[] benzinePrijs = new int[] { 7500, 9200, 13200, 18000, 21500, 20000, 29000 };
            int[] dieselPrijs = new int[] { 8500, 11700, 15200, 21000, 24200, 21700, 31500 };
            int[] hybridePrijs = new int[] { 10000, 14700, 18200, 23400, 27200, 25300, 33900 };
            int[] toeslag = new int[] { 550, 700, 800, 800, 850, 820, 970 };

            int afbetaalJaren = Convert.ToInt32(txtAantalJaren.Text);
            string motortype = "";
            int prijsWagen = 0;
            int totalePrijs = 0;
            int model = lstModel.SelectedIndex;
            
            //bepalen motortype en prijs van wagen
            if (radBenzine.Checked)
            {
                motortype = "Benzine";
                prijsWagen = benzinePrijs[model];
            } else if (radDiesel.Checked)
            {
                motortype = "Diesel";
                prijsWagen = dieselPrijs[model];
            }
            else
            {
                motortype = "Hybride";
                prijsWagen = hybridePrijs[model];
            }
            
            

            //wijzigen van resultaat textbox
            txtResultaat.AppendText("Prijsberekening voor model " + lstModel.SelectedItem + "\r\n");
            txtResultaat.AppendText("Motortype: " + motortype + "\r\n");
            txtResultaat.AppendText(String.Format("Basisprijs: {0,00:c}\r\n", prijsWagen));

            //bepalen of toeslag nodig
            if (chkMetaalKleur.Checked)
            {
                txtResultaat.AppendText(String.Format("Toeslag metaalkleur: {0,00:c}\r\n", toeslag[model]));
                //bepalen totale prijs met toeslag
                totalePrijs = prijsWagen + toeslag[model];
            } else
            {
                txtResultaat.AppendText("Standaardkleur - geen toeslag\r\n");
                //totale prijs zonder toeslage
                totalePrijs = prijsWagen;
            }
            txtResultaat.AppendText(String.Format("Te betalen: {0,00:c}\r\n\r\n", totalePrijs));

            if(afbetaalJaren > 0)
            {
                txtResultaat.AppendText(String.Format("Omiddelijke betaling van 40%: {0:c}\r\n", totalePrijs * 0.4));
                for(int i = 0; i<afbetaalJaren; i++)
                {
                    txtResultaat.AppendText(String.Format("Na jaar {0}: {1,00:c}\r\n", i+1, (totalePrijs * 0.6 / afbetaalJaren +100)));
                }
            }

            aantalBerekeningen[model]++;
        }

        private void overzichtBerekeningenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtResultaat.Text = aantalBerekeningen.ToString();
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.BackColor == Color.LightBlue)
            {
                this.BackColor = Color.LightGreen;
            } else
            {
                this.BackColor = Color.LightBlue;
            }
        }

        private void willekeurigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random maakRand = new Random();
            int kleur = maakRand.Next(1, 5);

            switch (kleur)
            {
                case 1:
                    this.BackColor = Color.LightBlue;
                    break;
                case 2:
                    this.BackColor = Color.Yellow;
                    break;
                case 3:
                    this.BackColor = Color.LightGreen;
                    break;
                case 4:
                    this.BackColor = Color.White;
                    break;
            }
        }
    }
}
