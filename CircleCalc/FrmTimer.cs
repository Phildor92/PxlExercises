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
    public partial class FrmTimer : Form
    {
        private int teller = 0;

        public FrmTimer()
        {
            InitializeComponent();
        }

        private void wisBtn_Click(object sender, EventArgs e)
        {
            tellerTxt.Clear();
            intervalTxt.Text = "100";
            aftellenTmr.Interval = 100;
            stopTeller();
            teller = 0;
        }

        private void sluitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            aftellenTmr.Interval = Convert.ToInt32(intervalTxt.Text);
            startTeller();
            
        }

        private void FrmTimer_Load(object sender, EventArgs e)
        {
            intervalTxt.Text = "100";
            aftellenTmr.Interval = 100;
            stopTeller();
            afbeeldingTmr.Enabled = true;
            toonAfbeelding();
        }

        private void aftellenTmr_Tick(object sender, EventArgs e)
        {
            teller++;
            tellerTxt.Text = teller + "";           
            if(teller == 1000)
            {
                stopTeller();
                teller = 0;
            }
            
        }

        private void eindeBtn_Click(object sender, EventArgs e)
        {
            stopTeller();
        }

        private void startTeller()
        {
            startBtn.Enabled = false;
            eindeBtn.Enabled = true;
            aftellenTmr.Enabled = true;
        }
        private void stopTeller()
        {
            startBtn.Enabled = true;
            eindeBtn.Enabled = false;
            aftellenTmr.Enabled = false;
        }

        private void afbeeldingTmr_Tick(object sender, EventArgs e)
        {
            toonAfbeelding();
        }

        private void toonAfbeelding()
        {
            Random pickRand = new Random();
            int randPicNum = pickRand.Next(1, 21);
            string fileName = @"C:\Users\philip.evans\Documents\PCVO Limburg - HBO5 Informatica\programmeren\img\beeld " + randPicNum.ToString() + ".jpg";
            afbeeldingPic.Image = Image.FromFile(fileName);
        }

        private void timeTmr_Tick(object sender, EventArgs e)
        {
            tijdLbl.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
