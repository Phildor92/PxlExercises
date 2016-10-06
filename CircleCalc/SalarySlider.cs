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
    public partial class SalarySlider : Form
    {
        public SalarySlider()
        {
            InitializeComponent();
        }

        private void salarisToolTIp_Popup(object sender, PopupEventArgs e)
        {

        }
        double salaris;
        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            double belasting = 0;
            salaris = trackBar1.Value;
            
            if(salaris < 10001){
                belasting = 0;
            } else if (salaris > 10000 && salaris < 50001)
            {
                belasting = salaris * 0.2;
            } else
            {
                belasting = salaris * 0.9;
            }
            
            belastingTxt.Text = String.Format(belasting+"");

            toolTip1.SetToolTip(trackBar1, Convert.ToString(salaris));
        }
    }
}
