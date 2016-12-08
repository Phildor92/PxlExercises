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
    public partial class Frm_Rekenmenu : Form
    {
        private int aantalJuisteBerekeningen = 0;
        private int aantalOefeningen = 0;
        private int aantalTellen;

        public Frm_Rekenmenu()
        {
            InitializeComponent();

        }

        private void eindeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright " + Convert.ToChar(169) + " 2016\r\nPhilip Evans");
        }

        private void aftrekkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aftrekkenToolStripMenuItem.Checked = true;
            optellenToolStripMenuItem.Checked = false;
            vermenigvuldigenToolStripMenuItem.Checked = false;
            lblBewerking.Text = "-";
        }

        private void vermenigvuldigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aftrekkenToolStripMenuItem.Checked = false;
            optellenToolStripMenuItem.Checked = false;
            vermenigvuldigenToolStripMenuItem.Checked = true;
            lblBewerking.Text = "*";
        }

        private void optellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aftrekkenToolStripMenuItem.Checked = false;
            optellenToolStripMenuItem.Checked = true;
            vermenigvuldigenToolStripMenuItem.Checked = false;
            lblBewerking.Text = "+";
        }

        private void btnVolgende_Click(object sender, EventArgs e)
        {
            Random maakRand = new Random();
            txtGetal1.Text = maakRand.Next(0,21).ToString();
            txtGetal2.Text = maakRand.Next(0,21).ToString();
            txtResultaat.Clear();
            lblResultaat.Visible = false;
            txtResultaat.Focus();
            timer1.Stop();
            lblAantalJuist.Visible = false;
        }

        private void Frm_Rekenmenu_Load(object sender, EventArgs e)
        {
            txtResultaat.Focus();
        }

        private void btnControle_Click(object sender, EventArgs e)
        {
            int juistAntwoord = 0;
            int nummer1 = Convert.ToInt32(txtGetal1.Text);
            int nummer2 = Convert.ToInt32(txtGetal2.Text);

            switch (lblBewerking.Text)
            {
                case "+": juistAntwoord = nummer1 + nummer2;break;
                case "-": juistAntwoord = nummer1 - nummer2;break;
                case "*": juistAntwoord = nummer1 * nummer2;break; 
            }
            int gegevenResultaat = Convert.ToInt32(txtResultaat.Text);
            if(gegevenResultaat == juistAntwoord)
            {
                lblResultaat.Text = "juist";
                aantalJuisteBerekeningen++;
                aantalOefeningen++;
            } else
            {
                lblResultaat.Text = "fout";
                aantalOefeningen++;               
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblResultaat.Visible = !lblResultaat.Visible;
            aantalTellen++;
            if(aantalTellen == 10)
            {
                timer1.Stop();
                aantalTellen = 0;
                lblResultaat.Visible = false;
            }
            //not best way
            /*if (lblResultaat.Visible) {
                lblResultaat.Visible = false;
            } else
            {
                lblResultaat.Visible = true;
            }*/
        }

        private void btnResultaat_Click(object sender, EventArgs e)
        {
            lblAantalJuist.Text = "Aantal juiste antwoorden: " + aantalJuisteBerekeningen + " van de " + aantalOefeningen + " oefening(en)";
            lblAantalJuist.Visible = true;
            lblResultaat.Visible = false;
            nieuweReeksToolStripMenuItem.Enabled = true;
        }

        private void nieuweReeksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nieuweReeksToolStripMenuItem.Enabled = false;
            aantalOefeningen = 0;
            aantalJuisteBerekeningen = 0;
            lblAantalJuist.Visible = false;
            txtGetal1.Clear();
            txtGetal2.Clear();
            txtResultaat.Clear();
            timer1.Stop();
        }
    }
}
