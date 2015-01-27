using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        // Generates our random numbers.
        private Random randomizer = new Random();

        // Addition operands.
        private int addend1 = 0;
        private int addend2 = 0;

        // Subtraction operands.
        private int minuend = 0;
        private int subtrahend = 0;

        // Multiplication operands.
        private int multiplicand = 0;
        private int multiplier = 0;

        // Division operands.
        private int dividend = 0;
        private int divisor = 0;


        // Tracks how much time is left.
        private int timeLeft = 0;

        public Form1()
        {
            InitializeComponent();

            // Keep the user from messing around with the form's values before the quiz has been started.
            sum.Enabled = false;
            difference.Enabled = false;
            product.Enabled = false;
            quotient.Enabled = false;
        }

        // Initialization and state management.

        public void StartTheQuiz()
        {
            

            // Initialize operands with random numbers, update labels, and initialize answer vars.
            // Set labels, and set background colors of the NumberUpDown control.

            // Addition problem:
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            leftPlusLabel.Text = addend1.ToString();
            rightPlusLabel.Text = addend2.ToString();
            sum.Value = 0;
            sum.BackColor = Color.Red;

            // Subtraction problem:
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            leftSubtractLabel.Text = minuend.ToString();
            rightSubtractLabel.Text = subtrahend.ToString();
            difference.Value = 0;
            difference.BackColor = Color.Red;

            // Multiplication problem:
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            leftMulLabel.Text = multiplicand.ToString();
            rightMulLabel.Text = multiplier.ToString();
            product.Value = 0;
            product.BackColor = Color.Red;

            // Division problem:
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            leftDivLabel.Text = dividend.ToString();
            rightDivLabel.Text = divisor.ToString();
            quotient.Value = 0;
            quotient.BackColor = Color.Red;

            // Start our timer.
            // Hardcoded to 30 seconds.
            timeLeft = 30;
            timeLabel.Text = timeLeft + " seconds!";
            timer1.Start();
        }

        private void EnableApp()
        {
            // Enable NumericUpDown controls.
            sum.Enabled = true;
            difference.Enabled = true;
            product.Enabled = true;
            quotient.Enabled = true;
        }

        private void DisableApp()
        {

        }

        // Functions to check the individual problems.

        /**
         * Checks to see if the addition problem's solution is correct.
         */
        private bool CheckAnswer()
        {
            return (CheckAdditionProblem()
                && CheckSubtractionProblem()
                && CheckMultiplicationProblem()
                && CheckDivisionProblem());
        }

        private bool CheckAdditionProblem()
        {
            return (addend1 + addend2 == sum.Value);
        }

        private bool CheckSubtractionProblem()
        {
            return (minuend - subtrahend == difference.Value);
        }

        private bool CheckMultiplicationProblem()
        {
            return(multiplicand * multiplier == product.Value);
        }

        private bool CheckDivisionProblem()
        {
            return (dividend / divisor == quotient.Value);
        }

        // Events.  Registered and fired when the user interacts with the app.

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Check the answers.
            if (CheckAnswer())
            {
                // The user got the answers correct.
                // Stop the timer, and display a message to the user.
                timer1.Stop();
                MessageBox.Show("You got all the answers correct!", "Yay!");

                // Disable NumericUpDown controls.
                // Keep the user from messing around with the form's values before the quiz has been started.
                sum.Enabled = false;
                difference.Enabled = false;
                product.Enabled = false;
                quotient.Enabled = false;

                // Enable the start button.
                startButton.Enabled = true;
            }
            // The user doesn't have the correct answers, but has time left.
            else if (timeLeft > 1)
            {
                // Less than 5 seconds?  Change BackColor.
                if (timeLeft <= 5)
                {
                    timeLabel.BackColor = Color.Red;
                }
                // Update timeLeft, and timeLabel.
                timeLeft--;
                timeLabel.Text = timeLeft.ToString() + " seconds!";
            }
            // The user doesn't have the correct answers, and is out of time!
            else
            {
                // User ran out of time.
                timer1.Stop();

                // Update timeLabel.
                timeLabel.Text = "Time's up!";

                // Display the correct answer.
                sum.Value = addend1 + addend2;

                difference.Value = minuend - subtrahend;

                product.Value = multiplicand * multiplier;

                quotient.Value = dividend / divisor;

                // Display a message box to the user.
                MessageBox.Show("You didn't finish in time", "Sorry!");

                // Reset timerLabel.
                timeLabel.BackColor = Color.White;

                // Enable the start button.
                startButton.Enabled = true;
            }
        }

        /*
         * Called when the user strikes enter.
         */
        private void answer_Enter(object sender, EventArgs e)
        {
            answer_Fill(sender);
        }

        /*
         * Called when the user clicks on the NumericUpDown control
         */
        private void answer_Click(object sender, MouseEventArgs e)
        {
            answer_Fill(sender);
        }

        /* 
         * Handles autoselection of the NumberUpDown's contents.
         */
        private void answer_Fill( object sender)
        {
            // Cast generic object to NumericUpDown.
            NumericUpDown answerBox = sender as NumericUpDown;

            // If answerBox is not null, do something interesting with answerBox.
            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        /**
         * Not needed.
         */
        private void difference_Enter(object sender, EventArgs e)
        {
            /*
            // Cast generic object to NumericUpDown.
            NumericUpDown answerBox = sender as NumericUpDown;

            // If answerBox is not null, do something interesting with answerBox.
            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
            */
        }

        private void sum_ValueChanged(object sender, EventArgs e)
        {
            if (addend1 + addend2 == sum.Value)
            {
                sum.BackColor = Color.Green;
            }
            else
            {
                sum.BackColor = Color.Red;
            }
        }

        private void difference_ValueChanged(object sender, EventArgs e)
        {
            if (minuend - subtrahend == difference.Value)
            {
                difference.BackColor = Color.Green;
            }
            else
            {
                difference.BackColor = Color.Red;
            }
        }

        private void product_ValueChanged(object sender, EventArgs e)
        {
            if (multiplicand * multiplier == product.Value)
            {
                product.BackColor = Color.Green;
            }
            else
            {
                product.BackColor = Color.Red;
            }
        }

        private void quotient_ValueChanged(object sender, EventArgs e)
        {
            if(dividend / divisor == quotient.Value )
            {
                quotient.BackColor = Color.Green;
            }
            else
            {
                quotient.BackColor = Color.Red;
            }
        }
    }
}
