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
            GenerateRandomNumber();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txb.Text);
            if (number == randomNumber)
            {
                answerLb.Text = "You got it!";
                answerLb.ForeColor = Color.Green;
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
    }
}
