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
    public partial class Leeftijd : Form
    {
        public Leeftijd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Leeftijd_Load(object sender, EventArgs e)
        {
            this.Text += "      " + DateTime.Now.DayOfWeek + " " + DateTime.Now.ToLongDateString() /*DateTime.Now.DayOfWeek + " " + DateTime.Now.Day + " " + DateTime.Now.Month + " " + DateTime.Now.Year*/;
        }

        private void bereken_Click(object sender, EventArgs e)//inaccurate
        {
            String birthdate = geboorteTxt.Text;
            Int32 year = Convert.ToInt32(birthdate.Substring(6));
            Int32 month = Convert.ToInt32(birthdate.Substring(3,2));
            Int32 day = Convert.ToInt32(birthdate.Substring(0,2));

            DateTime datumGB = new DateTime(year, month, day);
            DateTime datumNow = DateTime.Now;
            TimeSpan verschil;

            verschil = datumNow - datumGB;

            //Int32 difYears = Convert.ToInt32(verschil.TotalDays / 365);//incorrect
            //Int32 difMonths = Convert.ToInt32(verschil.TotalDays / 30.42);
            Int32 difDays = Convert.ToInt32(verschil.TotalDays);

            //jaarTxt.Text = String.Format("{0} years", difYears);
            //maandTxt.Text = String.Format("{0} months", difMonths);
            dagTxt.Text = String.Format("{0} days", difDays);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTijd.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            DateTime gbdatum = Convert.ToDateTime(geboorteTxt.Text);
            DateTime nu = DateTime.Today;//only the date

            long jaren = DateAndTime.DateDiff("yyyy", gbdatum, nu);
            long maanden = DateAndTime.DateDiff("m", gbdatum, nu);
            long dagen = DateAndTime.DateDiff("d", gbdatum, nu);

            txtJaren.Text = String.Format("{0} years", jaren);
            txtMaanden.Text = String.Format("{0} months", maanden);
            txtDagen.Text = String.Format("{0} days", dagen);
        }
    }
}
