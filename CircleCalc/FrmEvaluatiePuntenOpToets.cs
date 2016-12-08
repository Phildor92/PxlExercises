using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CircleCalc
{
    public partial class FrmEvaluatiePuntenOpToets : Form
    {
        

        public FrmEvaluatiePuntenOpToets()
        {
            InitializeComponent();
        }

        private void FrmEvaluatiePuntenOpToets_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] aantal = new int[11];

            int totalPoints = 0;
            double tallyPoints = 0.0;
            double average = 0.0;
            string entry = Interaction.InputBox("Geef het behaalde resultaat tussen 0 en 10, of 99 om te stoppen", "Input");
            while (entry != "99")
            {
                aantal[Convert.ToInt32(entry)]++;
                tallyPoints++;
                totalPoints += Convert.ToInt32(entry);
                entry = Interaction.InputBox("Geef het behaalde resultaat tussen 0 en 10, of 99 om te stoppen", "Input");
            }
            average = totalPoints / tallyPoints;
            txtResultaat.Text = "Klas gemiddelde is " + average + Environment.NewLine;
            txtResultaat.Text += "Totaal is " + totalPoints + " teller is " + tallyPoints + Environment.NewLine;

            for(int i = 0; i<aantal.Length; i++)
            {
                txtResultaat.Text += "Aantal keer " + i + ": " + aantal[i] + Environment.NewLine;
            }
        }
    }
}
