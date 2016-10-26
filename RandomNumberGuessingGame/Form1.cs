using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Random generator = new Random();
            number = generator.Next(1, 100);

            MessageBox.Show("Try to guess a number between 1 and 100");
        }

        int number;
        int numberoftries = 1;
       
        private void btnGuess_Click(object sender, EventArgs e)
        {
            int guess = Convert.ToInt32(txtEnterGuess.Text);
            
            if (guess > number)
            {
                if (number % 2 == 0)
                {
                    txtAnswer.Text = ("Guess was too high, try again! the number is an even number!");
                }
                else if (number % 2 == 1)
                {
                    txtAnswer.Text = ("Guess was too high, try again! the number is an odd number!");
                }
            }

            if (guess < number)
            {
                if (number % 2 == 0)
                {
                    txtAnswer.Text = ("Guess was too low, try again! the number is an even number!");
                }
                else if (number % 2 == 1)
                {
                    txtAnswer.Text = ("Guess was too low, try again! the number is an odd number!");
                }
            }

            if (guess == number)
            {
                txtAnswer.Text = ("Awesome, guess was right!");

                MessageBox.Show("It took you " + Convert.ToString(numberoftries) + " tries to guess the right number!");
                btnStartOver.Focus();
            }
            ++numberoftries;
            txtAttemptNumber.Text = numberoftries.ToString();
            txtEnterGuess.Text = "";
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartOver_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = "";
            txtEnterGuess.Text = "";
            txtAttemptNumber.Text = "";
            numberoftries = 1;

            txtEnterGuess.Focus();

            Random generator = new Random();
            number = generator.Next(1, 100);

            MessageBox.Show("Try to guess a number between 1 and 100");

        }
    }
}
