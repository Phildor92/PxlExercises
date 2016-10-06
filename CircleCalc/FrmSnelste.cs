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
    public partial class FrmSnelste : Form
    {
        SortedDictionary<Int32, String> athletes = new SortedDictionary<int, string>();
        SortedDictionary<Int32, String> emptyDictionary = new SortedDictionary<int, string>();
        public FrmSnelste()
        {
            InitializeComponent();
        }

        private void newEntryBtn_Click(object sender, EventArgs e)
        {
            //calculate with "selection"? Via array, if, then, loops, etc...
            fastRunnerTxt.Text = "";
            athletes.Add(Convert.ToInt32(totTimeTxt.Text), athlNameTxt.Text);
            athlNameTxt.Text = "";
            totTimeTxt.Text = "";
        }

        private void fastestAthlBtn_Click(object sender, EventArgs e)
        {
            Int32 seconds = athletes.First().Key;
            Int32 minutes = seconds / 60;
            Int32 hours = minutes / 60;
            String[] resultaat = new String[] { "De snelste atleet is " + athletes.First().Value,
                    "totaal aantal seconden: " + seconds,
                    "",
                    "aantal uren: " + hours,
                    "aantal minuten: " + (minutes - hours * 60),
                    "aantal seconden: " + (seconds - minutes * 60) };
            fastRunnerTxt.Lines = resultaat;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //Better method? Via for-loop? Dictionary/Collections method?
            athletes = emptyDictionary;
            fastRunnerTxt.Text = "Lijst is nu leeg";
        }

        private void closeAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmSnelste_Load(object sender, EventArgs e)
        {

        }
    }
}
