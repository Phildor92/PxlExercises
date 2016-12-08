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
    public partial class FrmOmzetWoord : Form
    {
        public FrmOmzetWoord()
        {
            InitializeComponent();
        }

        private void btnOmzet1_Click(object sender, EventArgs e)
        {
            string naam = txtInvoer.Text;
            string[] letters = new string[naam.Length];
            string resultaat = "";

            for(int j = 0; j < naam.Length; j++)
            {
                letters[j] = naam.Substring(j, 1);
            }

            for (int i = 0; i < naam.Length; i++)
            {
                if (i == 0 || letters[i - 1] == " ")
                {
                    letters[i] = letters[i].ToUpper();
                } else
                {
                    letters[i] = letters[i].ToLower();
                }
            }

            for(int k = 0; k < letters.Length; k++)
            {
                resultaat += letters[k];
            }

            txtNaamOmzet.Text = resultaat;
        }

        private string NaamOmzet(string naam)
        {
            string resultaat = "";
            Boolean naarHoofdletter = true;

            for (int i = 0; i < naam.Length; i++)
            {
                if (naarHoofdletter == true)
                {
                    resultaat += naam.Substring(i, 1).ToUpper();
                }
                else
                {
                    resultaat += naam.Substring(i, 1).ToLower();
                }
                if(naam.Substring(i,1) == " ")
                {
                    naarHoofdletter = true;
                } else
                {
                    naarHoofdletter = false;
                }                    
            }

            return resultaat;
        }

        private void btnAltOmzet1_Click(object sender, EventArgs e)
        {
            string naam = txtInvoer.Text;
            txtNaamOmzet.Text = NaamOmzet(naam);
        }

        private void btnOmzet2_Click(object sender, EventArgs e)
        {
            string naam = txtInvoer.Text;
            string resultaat = "";
            char[] letters = naam.ToCharArray();
                        
            for(int i = 0; i<letters.Length; i++)
            {
                if(letters[i] >= 'A' && letters[i] <= 'z')
                {
                    resultaat += letters[i];
                }               
            }
            

            txtNaamOmzet.Text = resultaat.ToLower();
        }
    }
}
