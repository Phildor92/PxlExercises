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
    public partial class Raadspel : Form
    {
        private int totGuesses = 0;
        private int randNum = 1;
        private int teller;

        public Raadspel()
        {
            InitializeComponent();
        }

        private void eval_Click(object sender, EventArgs e)
        {
            totGuesses++;
            numGuesses.Text = "Aantal keren geraden: " + totGuesses;

            int guess = Convert.ToInt32(guessNumTxt.Text);
            
            if(guess == randNum)
            {
                result.Text = "U heeft het geraden in " + totGuesses + " beurten.";
                numGuesses.Text = "Geraden in: " + teller + " seconden";
                totGuesses = 0;
            } else if (guess < randNum)
            {
                result.Text = "De te zoeken waarde is hoger";
            } else
            {
                result.Text = "De te zoeken waarde is lager";
            }
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            randNum = rand.Next(101);
            result.Text = "";
            numGuesses.Text = "";
            guessNumTxt.Text = "";
            teller = 0;
        }

        private void End_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Raadspel_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            randNum = rand.Next(101);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            teller++;
        }
    }
}
