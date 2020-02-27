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
    public partial class Form4 : Form
    {
        string fileName = "records.txt";
        public Form4()
        {
            InitializeComponent();
            lbRecordsContent.Text = File.ReadAllText(fileName);
            this.Text = "Records.";
        }

        private void lbRecordsContent_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
