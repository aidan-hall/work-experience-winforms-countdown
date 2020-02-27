using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_Countdown
{
    internal class NumberButton : Button
    {
        // A button with a number on it (for the number game).
        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; Text = value.ToString(); }

        }

        public NumberButton(int number) : base()
        {
            this.number = number;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}