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
    public partial class Studiebeursberekening : Form
    {
        private int juisteBerekeningen = 0;

        public Studiebeursberekening()
        {
            InitializeComponent();
        }

        private void berekenBtn_Click(object sender, EventArgs e)
        {
            if(naamTxt.Text == "" || brutobelastbaarTxt.Text == "")
            {
                resultaatTxt.Text = "Velden mogen niet leeg zijn";
            } else
            {
                juisteBerekeningen++;
                resultaatTxt.Text = berekenBeurs();
            }
        }

        private string berekenBeurs()
        {
            double brutobelastbaarD = Convert.ToDouble(brutobelastbaarTxt.Text);
            int aantalKinderenInt = Convert.ToInt32(aantalKinderenTxt.Text);
            double basisbedrag = 0.0;
            string opleidingsString = "";
            double toeslagOpleiding = 0.0;
            double toeslagKotstudent = 0.0;

            if (aantalKinderenInt == 2)
            {
                brutobelastbaarD = brutobelastbaarD - 1500;
            } else if (aantalKinderenInt > 2)
            {
                brutobelastbaarD = brutobelastbaarD - 1500 + 2000 * (aantalKinderenInt - 2);
            }

            if(brutobelastbaarD < 20000)
            {
                basisbedrag = 2000;
            } else if (brutobelastbaarD < 25000)
            {
                basisbedrag = 1000;
            } else if (brutobelastbaarD < 30000)
            {
                basisbedrag = 500;
            }

            if (algOpleidingRad.Checked)
            {
                opleidingsString = "Algemene opleiding";
            } else if (techOpleidingRad.Checked)
            {
                opleidingsString = "Technische opleiding";
                if (!bisStudentCb.Checked && basisbedrag > 0)
                {
                    toeslagOpleiding = 200;
                }
            } else
            {
                opleidingsString = "Kunst opleiding";
                if(!bisStudentCb.Checked && basisbedrag > 0)
                {
                    toeslagOpleiding = 300;
                }
            }

            if(kotstudentCb.Checked && basisbedrag > 0)
            {
                toeslagKotstudent = 500;
            }

            return naamTxt.Text + "\r\n" + basisbedrag + toeslagOpleiding + toeslagKotstudent + "\r\n" + opleidingsString;
        }
    }
}
