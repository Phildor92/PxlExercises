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
    public partial class FrmVermenigvuldigingstafel : Form
    {
        public FrmVermenigvuldigingstafel()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtResultaat.Clear();
            for (int i = 1; i<13; i++)
            {
                for(int j = 1; j<13; j++)
                {                    
                    txtResultaat.AppendText(String.Format("{0,2} * {1,2}  = {2,3} \r\n", i ,  j , i * j));
                }
            }
        }
    }
}
