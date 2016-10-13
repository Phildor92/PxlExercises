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
    public partial class Parking : Form
    {
        private int aantalBeschikbarePlaatsen;
        private const int aantalPlaatsen = 10;

        public Parking()
        {
            InitializeComponent();
        }
        private void inBtn_Click(object sender, EventArgs e)
        {
            if(aantalBeschikbarePlaatsen > 0)// not strictly necessary, as long as there is no way to re-activate the button without pressing the out button, and thereby increasing number of available spots.
            {                
                aantalBeschikbarePlaatsen--;
                //resultaatTxt.Text = "Geparkeerde autos: " + (aantalPlaatsen - aantalBeschikbarePlaatsen) + "\r\nBeschikbare plaatsen: " + aantalBeschikbarePlaatsen;
                uitBtn.Enabled = true;
                toonInfo();               
            }
            if(aantalBeschikbarePlaatsen == 0)
            {
                inBtn.Enabled = false;
            }
        }

        private void Parking_Load(object sender, EventArgs e)
        {
            aantalBeschikbarePlaatsen = aantalPlaatsen;
            inBtn.Enabled = true;
            uitBtn.Enabled = false;
        }

        private void uitBtn_Click(object sender, EventArgs e)
        {
            if(aantalBeschikbarePlaatsen < aantalPlaatsen)//ditto as for in button.
            {               
                aantalBeschikbarePlaatsen++;
                //resultaatTxt.Text = "Geparkeerde autos: " + (aantalPlaatsen - aantalBeschikbarePlaatsen) + "\r\nBeschikbare plaatsen: " + aantalBeschikbarePlaatsen;
                inBtn.Enabled = true;
                toonInfo();
            }
            if(aantalBeschikbarePlaatsen == aantalPlaatsen)
            {
                uitBtn.Enabled = false;
            }
        }

        private void toonInfo()
        {
            resultaatTxt.Text = "Geparkeerde autos: " + (aantalPlaatsen - aantalBeschikbarePlaatsen) + "\r\nBeschikbare plaatsen: " + aantalBeschikbarePlaatsen;
        }
    }
}
