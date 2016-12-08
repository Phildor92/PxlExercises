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
    public partial class FrmListBox : Form
    {
        private double[] kosten = new double[] { 200, 220, 220, 420, 350, 240 };
        private string[] sporten = new string[] { "zwemmen", "atletiek", "voetbal", "paardrijden", "kayak", "turnen" };
        private Dictionary<string, double> sportKosten = new Dictionary<string, double>();

        public FrmListBox()
        {
            InitializeComponent();
        }

        private void btnToon_Click(object sender, EventArgs e)
        {
            if (lstGemeente.SelectedIndex == -1 || lstSporttak.SelectedIndex == -1)
            {
                txtResultaat.Text = "Minstens een van de opties is niet geselecteerd";
            }
            else
            {
                //txtResultaat.Text = "De bestemming is : " + lstGemeente.SelectedItem
                  //  + "\r\nDe gekozen sporttak is : " + lstSporttak.SelectedItem + "\r\nEn de kosten zijn: " + sportKosten.TryGetValue(lstSporttak.SelectedItem.ToString());
            }
        }

        private void FrmListBox_Load(object sender, EventArgs e)
        {
            lstGemeente.SelectedIndex = 0;
            lstSporttak.SelectedIndex = 0;
            for(int i = 0; i<sporten.Length; i++)
            {
                sportKosten.Add(sporten[i], kosten[i]);

            }
        }
    }
}
