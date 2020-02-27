using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Windows_Forms_Countdown
{
    public partial class Form3 : Form
    {
        string tab = "        ";
        string fileName = "records.txt";
        int points;
        int difference;
        string playerName;
        public Form3(int points, int difference)
        {
            this.points = points;
            this.difference = difference;
            InitializeComponent();
            this.Text = "Save Results.";
            this.differenceLabel.Text = "Difference: " + this.difference.ToString();
            this.pointsDisplay.Text = "Points: " + this.points.ToString();
        }

        private void playerNameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void nameConfirmationButton_Click(object sender, EventArgs e)
        {
            this.playerName = playerNameTextBox.Text;
            string playerRecord = this.playerName + tab + points.ToString() + tab + tab + this.difference.ToString() + "\n";
            File.AppendAllText(this.fileName, playerRecord);
            this.label2.Text = "Results saved.";
            this.Close();
            
        }
    }
}
