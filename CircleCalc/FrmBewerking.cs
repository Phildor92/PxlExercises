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
    public partial class FrmBewerking : Form
    {
        public FrmBewerking()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Int32 geheel = 3;
            Double decimaal = 3.6;

            MessageBox.Show(decimaal.ToString());
            Int32 resultaat;
            Double resultaat2;
            String resultaat3;
            /*

            //int = double * int -> rounds up, more precise
            resultaat = Convert.ToInt32(geheel * decimaal);//Convert.ToInt32 method rounds the numbers. Does not truncate.
            MessageBox.Show(resultaat.ToString());
            
            //int = double * int -> rounds down/truncates
            resultaat = (int)(geheel * decimaal); //this method truncates the double. More like usual Java casting.
            MessageBox.Show(resultaat.ToString());

            //double = double * int -> correct result
            resultaat2 = geheel * decimaal;
            MessageBox.Show(resultaat2.ToString());

            //without Convert.ToDouble(or 8.0 or 3.0), two ints will be divided (and 2 will be answer), since both are whole numbers. 
            resultaat2 = 8.0 / 3;
            MessageBox.Show(resultaat2.ToString());
            */

            String x = "x";
            x += x;
            x += x;
            MessageBox.Show(x);

            resultaat3 = "3" + (3 * geheel);
            MessageBox.Show(resultaat3);
        }
    }
}
