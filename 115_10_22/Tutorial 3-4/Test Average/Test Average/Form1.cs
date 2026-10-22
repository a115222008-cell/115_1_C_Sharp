using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            double test1, test2, test3, average;// Declare variables to hold the test scores and average.

            try
            {
                test1 = double.Parse(test1TextBox.Text); // Get the first test score from the input control.
                test2 = double.Parse(test2TextBox.Text); // Get the second test score from the input control.
                test3 = double.Parse(test3TextBox.Text); // Get the third test score from the input control.

                average = (test1 + test2 + test3) / 3; // Calculate the average of the three test scores.

                averageLabel.Text = average.ToString("F1"); // Display the average in the output label.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the input and output controls.
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void test1PromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void test1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void averageLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
