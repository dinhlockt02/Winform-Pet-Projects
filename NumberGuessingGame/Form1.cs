using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class Form1 : Form
    {
        static int randomNumber;
        public Form1()
        {
            InitializeComponent();
            InitialGame();
            this.AcceptButton = btn;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                CheckingWinning();
            }
            catch
            {
                answerLb.Text = "Please enter a number from 1 to 10";
                answerLb.ForeColor = Color.Brown;
            }
        }

        void CheckingWinning()
        {
            int number = int.Parse(txb.Text);
            if (number == randomNumber)
            {
                WinGame();
            }
            else
            {
                if (number < randomNumber)
                {
                    answerLb.Text = "A bit higher!";
                }
                else
                {
                    answerLb.Text = "A bit lower!";
                }
                answerLb.ForeColor = Color.Red;
            }
        }

        void GenerateRandomNumber()
        {
            Random rand = new Random();
            randomNumber = rand.Next(1, 11);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            InitialGame();
        }

        void InitialGame()
        {
            GenerateRandomNumber();
            this.Text = "Number Guessing Game !";
            lb.Text = "Guessing: ";
            btn.Text = "Check";
            answerLb.Text = "";
            btn2.Text = "Restart";
            txb.Text = "";
        }

        void WinGame()
        {
            answerLb.Text = "You got it!";
            answerLb.ForeColor = Color.Green;
            MessageBox.Show("You win!");
            InitialGame();
        }
    }
}
