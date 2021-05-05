using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amIPositive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            //calc postive or negative
            int number = Convert.ToInt32(intergerInput.Text);
            if (number > 0) 
            {
                positiveOrNegative.Text = $"{number} is a postive number";
            }
            else
            {
                positiveOrNegative.Text = $"{number} is a negative number";
            }

            //calc if it is divisible by 7
            if (number % 7 == 0)
            {
                divisible.Text = $"{number} is divisible by 7";
            }
            else
            {
                divisible.Text = $"{number} is not divisible by 7";
            }
        }
    }
}
