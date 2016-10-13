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
    public partial class SchrikkelJaar : Form
    {
        public SchrikkelJaar()
        {
            InitializeComponent();
        }

        private void schrikkelJaar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void testBtn1_Click(object sender, EventArgs e)
        {
            int[] jaren = new int[] {Convert.ToInt32(jaar1Txt.Text), Convert.ToInt32(jaar2Txt.Text), Convert.ToInt32(jaar3Txt.Text), Convert.ToInt32(jaar4Txt.Text), Convert.ToInt32(jaar5Txt.Text), Convert.ToInt32(jaar6Txt.Text) };
            TextBox[] resultaten = new TextBox[] { result1Txt, result2Txt, result3Txt, result4Txt, result5Txt, result6Txt};
            for (int i = 0; i < jaren.Length; i++)
            {
                if (BepaalSchrikkeljaar(jaren[i]))
                {
                    resultaten[i].Text = "Schrikkel";
                } else
                {
                    resultaten[i].Text = "Niet schrikkel";
                }
            }
        }

        private bool BepaalSchrikkeljaar (int year)
        {
            bool isLeap;
            if (year % 4 == 0)
            {
                isLeap = true;
                if (year % 100 == 0 && year % 400 != 0)
                {
                    isLeap = false;
                }
            }
            else
            {
                isLeap = false;
            }
            return isLeap;
        }

        private void testBtn2_Click(object sender, EventArgs e)
        {
            if (DateTime.IsLeapYear(Convert.ToInt32(jaar1Txt.Text)))
            {
                result1Txt.Text = "Leap year";
            } else
            {
                result1Txt.Text = "Not Leap";
            }
        }

        private void testBtn3_Click(object sender, EventArgs e)
        {
            result1Txt.Text = String.Format("{0:d}", BepaalSchrikkeljaar(Convert.ToInt32(jaar1Txt.Text)));
            result2Txt.Text = String.Format("{0:d}", BepaalSchrikkeljaar(Convert.ToInt32(jaar2Txt.Text)));
            result3Txt.Text = String.Format("{0:d}", BepaalSchrikkeljaar(Convert.ToInt32(jaar3Txt.Text)));
            result4Txt.Text = String.Format("{0:d}", BepaalSchrikkeljaar(Convert.ToInt32(jaar4Txt.Text)));
            result5Txt.Text = String.Format("{0:d}", BepaalSchrikkeljaar(Convert.ToInt32(jaar5Txt.Text)));
            result6Txt.Text = String.Format("{0:d}", BepaalSchrikkeljaar(Convert.ToInt32(jaar6Txt.Text)));
        }

        private void wissenBtn_Click(object sender, EventArgs e)
        {
            result1Txt.Clear();
            result2Txt.Clear();
            result3Txt.Clear();
            result4Txt.Clear();
            result5Txt.Clear();
            result6Txt.Clear();

            jaar1Txt.Clear();
            jaar2Txt.Clear();
            jaar3Txt.Clear();
            jaar4Txt.Clear();
            jaar5Txt.Clear();
            jaar6Txt.Clear();
        }
    }
}
