using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_Countdown
{

    public partial class Form2 : Form
    {
        private int nLargeNumbers;
        bool[] usedNumbers = new bool[] { false, false, false, false, false, false, };
        int[] numbers;
        int targetValue;
        int runningTotal = -1;
        Operator chosenOperator;
        bool selectingNumber;
        Random rnd = new Random();
        int[] TakeNumbers(int[] numbers, int howMany, int shuffles = 1)
        {
            // Return a set of randomly selected numbers from 'numbers' of length 'howMany'.

            var numberOfElements = numbers.Length;
            int buffer;
            int randomPosition;
            int[] returnValues = new int[howMany];

            for (int repeats = 0; repeats < shuffles; repeats++) // Re-shuffles the numbers for extra randomness, at a time cost.
            {
                for (int i = 0; i < numberOfElements; i++)
                {
                    randomPosition = this.rnd.Next(numberOfElements);

                    buffer = numbers[i];
                    numbers[i] = numbers[randomPosition];
                    numbers[randomPosition] = buffer;

                }
            }
            for (int k = 0; k < howMany; k++)
                returnValues[k] = numbers[k];

            return returnValues;
        }
        int[] generateNumbers()
        {

            int[] playerNumbers = new int[6];

            // Obtaining the set of numbers.
            int[] largeNumbers = new int[] { 25, 50, 75, 100 };
            int[] smallNumbers = new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10 };


            // Obtain a set of random numbers, selected using Countdown rules.
            this.TakeNumbers(largeNumbers, this.nLargeNumbers, 3).CopyTo(playerNumbers, 0);
            this.TakeNumbers(smallNumbers, 6 - this.nLargeNumbers, 3).CopyTo(playerNumbers, this.nLargeNumbers);

            return playerNumbers;
        }
        public Form2(int nLargeNumbers)
        {
            int[] largeNumbers = new int[] { 25, 50, 75, 100 };
            int[] smallNumbers = new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10 };
            this.nLargeNumbers = nLargeNumbers;
            InitializeComponent();
            this.Text = "Countdown Number Game.";
            this.numbers = this.generateNumbers();
            this.button5    .Text = this.numbers[0].ToString();
            this.button6    .Text = this.numbers[1].ToString();
            this.button7    .Text = this.numbers[2].ToString();
            this.button8    .Text = this.numbers[3].ToString();
            this.button9    .Text = this.numbers[4].ToString();
            this.button10   .Text = this.numbers[5].ToString();
            this.targetValue = rnd.Next(101, 1000);
            this.label1.Text = targetValue.ToString();
            this.selectingNumber = true;
        }

        public static int applyOperator (int cummulativeValue, int nextValue, Operator @operator)
        {
            switch(@operator)
            {
                case Operator.ADD:
                    return (cummulativeValue + nextValue);
                case Operator.SUB:
                    return (cummulativeValue - nextValue);
                case Operator.MUL:
                    return (cummulativeValue * nextValue);
                case Operator.DIV: // Return -1 if the division results in a non-integer value.
                    return (cummulativeValue % nextValue == 0) ? (cummulativeValue/nextValue) : -1;
                default: // Theoretically, this should never run.
                    return -1;
            }
        }
        bool selectNumber(int index)
        {
            if (!this.usedNumbers[index] && this.selectingNumber)
            {
                this.usedNumbers[index] = true;
                this.selectingNumber = false;

                if (this.runningTotal == -1) // If the first value hasn't been chosen.
                    this.runningTotal = this.numbers[index];
                else
                {
                    this.runningTotal = applyOperator(this.runningTotal, this.numbers[index], this.chosenOperator);
                    if (this.runningTotal < 0)
                    {
                        MessageBox.Show("You can't do that. Goodbye.");
                        this.Close();
                    }
                }
                this.label3.Text = this.runningTotal.ToString();
                this.label4.Text = " ";
                this.label6.Text = "Select an operator.";
                if (this.usedNumbers.All(b => b))
                {
                    this.label6.Text = "All numbers used.\nClick done to submit your answer.";
                    this.selectingNumber = true;
                }
                return true;
            }
            else
                return false;
        }

        string operatorString()
        {
            // A neat way of getting the text version of an operator.
            switch (this.chosenOperator)
            {
                case Operator.ADD:
                    return ("+");
                case Operator.SUB:
                    return ("-");
                case Operator.MUL:
                    return ("*");
                case Operator.DIV:
                    return ("/");
                default:
                    return ("?");
            }
        }

        void selectOperator(Operator @operator)
        {
            if (!this.selectingNumber) // Only acts if the user is meant to be selecting an operator.
            {
                this.chosenOperator = @operator;
                this.label4.Text = this.operatorString();
                this.label6.Text = "Select a number.";
                this.selectingNumber = true;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {

            if (this.selectNumber(1))
                this.button6.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (this.selectNumber(2))
                this.button7.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (this.selectNumber(3))
                this.button8.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (this.selectNumber(4))
                this.button9.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (this.selectNumber(5))
                this.button10.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void numberView_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.selectNumber(0))
                this.button5.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.selectOperator(Operator.ADD);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.selectOperator(Operator.SUB);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.selectOperator(Operator.MUL);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.selectOperator(Operator.DIV);
        }

        private void operatorSelector_Enter(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (this.runningTotal != -1)
            {
                int finalDifference = Math.Abs(this.targetValue - this.runningTotal);

                int points;
                if (finalDifference == 0)
                    points = 10;
                else if (finalDifference <= 5)
                    points = 7;
                else if (finalDifference <= 10)
                    points = 5;
                else
                    points = 0;

                Form3 savingForm = new Form3(points, finalDifference);
                savingForm.Show();
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
