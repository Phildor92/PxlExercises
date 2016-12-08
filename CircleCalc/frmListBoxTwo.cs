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
    public partial class FrmListBoxTwo : Form
    {        
        public FrmListBoxTwo()
        {
            InitializeComponent();
        }

        private void FrmListBoxTwo_Load(object sender, EventArgs e)
        {
            //namen can be assigned here as it is only needed to fill listboxes. The names are the accessible through the listboxes.
            String[] namen = new String[] { "Chris", "Inge", "Kristen", "Paul", "Marianne", "Patrizia", "Joachim", "Andrea", "Robert", "Simon", "Pieter", "Johan", "Karel", "Bob", "Bill", "Jebediah" };
            lstSimple.Items.AddRange(namen);
            chlstCheckedLB.Items.AddRange(namen);
            lblZoeken.Visible = false;
        }

        private void btnSorteren_Click(object sender, EventArgs e)
        {
            lstSimple.Sorted = false;
            lstSimple.Sorted = true;
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if(lstSimple.SelectedIndex >= 0)
            {
                if(MessageBox.Show("Wilt u " + lstSimple.SelectedItem + " verwijderen?", "Bevestiging", MessageBoxButtons.YesNo) == DialogResult.Yes)              
                {
                    lstSimple.Items.RemoveAt(lstSimple.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Geen naam geselecteerd");
            }
        }

        private void btnWissen_Click(object sender, EventArgs e)
        {
            lstSimple.Items.Clear();            
        }

        private void btnVervangen_Click(object sender, EventArgs e)
        {
            int sltIndex = lstSimple.SelectedIndex;
            if(sltIndex >= 0 && txtVervangen.Text != "")
            {
                lstSimple.Items.RemoveAt(sltIndex);
                lstSimple.Items.Insert(sltIndex, txtVervangen.Text);                
                lstSimple.SelectedIndex = sltIndex;
            }
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            int sltIndex = lstSimple.SelectedIndex;
            if (sltIndex >= 0 && txtVervangen.Text != "")
            {
                string toevoeging = lstSimple.SelectedItem.ToString();
                lstSimple.Items.RemoveAt(sltIndex);
                lstSimple.Items.Insert(sltIndex, toevoeging + txtToevoegen.Text);
                lstSimple.SelectedIndex = sltIndex;
            }
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            lblZoeken.Visible = false;
            if (lstSimple.Items.Contains(txtZoeken.Text))
            {
                lblZoeken.Text = "Gevonden!";
                lblZoeken.Visible = true;
            } else
            {
                MessageBox.Show("Naam niet gevonden");
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            
        }

        private void chlstCheckedLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtResultaat.Text = "";
            foreach (string element in chlstCheckedLB.CheckedItems)
            {
                txtResultaat.Text += element + Environment.NewLine;
            }
        }
    }
}
