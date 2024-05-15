using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReverseNumbersProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReverseNumbers_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse integers from textboxes
                int num1 = int.Parse(txtNum1.Text);
                int num2 = int.Parse(txtNum2.Text);
                int num3 = int.Parse(txtNum3.Text);

                // Display numbers in reverse order
                // string reversedNumbers = $"The numbers are {num3} {num2} {num1} in reverse order.";
                // MessageBox.Show(reversedNumbers, "Reversed Numbers");
                reversedLabel.Text = $"The numbers are {num3} {num2} {num1}";

            }
            catch (FormatException)
            {
                // Display error message if non-numeric value is entered
                MessageBox.Show("Please enter valid numeric values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
