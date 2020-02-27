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
    public partial class Form1 : Form
    {
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
        public static Random rnd = new Random();

        public static int[] TakeNumbers(int[] numbers, int howMany, int shuffles = 1)
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
                    randomPosition = rnd.Next(numberOfElements);

                    buffer = numbers[i];
                    numbers[i] = numbers[randomPosition];
                    numbers[randomPosition] = buffer;

                }
            }
            for (int k = 0; k < howMany; k++)
                returnValues[k] = numbers[k];

            return returnValues;
        }
        private int nLargeNumbers;
        public Form1()
        {
            this.Text = "Welcome to Countdown.";
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nLargeNumbers = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nLargeNumbers = 1;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            nLargeNumbers = 4;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            nLargeNumbers = 2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(rnd.Next(1,10).ToString() + "\n" + nLargeNumbers.ToString());
            Form2 form2 = new Form2(nLargeNumbers);
            form2.Show();
        }

        private void rd2N_CheckedChanged(object sender, EventArgs e)
        {
            nLargeNumbers = 2;
        }

        private void rd3N_CheckedChanged(object sender, EventArgs e)
        {
            nLargeNumbers = 3;
        }

        private void btRecords_Click(object sender, EventArgs e)
        {
            Form4 recordsForm = new Form4();
            recordsForm.Show();
        }
    }
}
