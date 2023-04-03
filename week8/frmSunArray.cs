using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Module8ProjectsOfArrays
{
    public partial class frmSunArray : Form
    {
        private List<int> numbers = new List<int>();
        public frmSunArray()
        {
            InitializeComponent();
        }

        private void extBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isValidData()
        {
            bool success = true;
            string errorMessage = "";
            
            errorMessage += isInt(numTxtBox.Text);
            errorMessage += isWithinRange(numTxtBox.Text, -1125, 1125);

            if (errorMessage != "")
            {
                success = false;
                arrayStatsLbl.Text = errorMessage;
            }
            return success;
        }

        private string isWithinRange(string value, int min, int max)
        {
            string msg = "";
            if (int.TryParse(value, out int number))
            {
                if (number < min || number > max)
                {
                    msg += "Number must be between " + Convert.ToString(min) + " and " + Convert.ToString(max) + ".\n";
                }
            }
            return msg;
        }

        private string isInt(string value)
        {
            string msg = "";
            if (!int.TryParse(value, out _))
            {
                msg += "Please only enter numbers.\n";
            }
            return msg;
        }

        private void addNumToArray_Click(object sender, EventArgs e)
        {
            arrayStatsLbl.Text = "Array Statistics";
            if (isValidData())
            {
                int num = Convert.ToInt32(numTxtBox.Text);
                numbers.Add(num);
                numTxtBox.Clear();
                numTxtBox.Focus();
            }
        }

        private void showArrayStatsBtn_Click(object sender, EventArgs e)
        {
            if (numbers.Count > 0)
            {

                arrayStatsLbl.Text = "";
                string message = "";
                foreach (int num in numbers)
                {
                    message += num.ToString() + "\n";
                }
                message = message.TrimEnd(',', ' ');
                arrayContentsLbl.Text = message;

                // average of array contents
                int sum = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                }
                arrayStatsLbl.Text += "Average: " + sum / numbers.Count + "\n";

                // the highest number in array
                int highest = numbers[0];
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] > highest)
                    {
                        highest = numbers[i];
                    }
                }
                arrayStatsLbl.Text += "Highest Number: " + highest + "\n";

                // the lowest number in array
                int lowest = numbers[0];
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] < lowest)
                    {
                        lowest = numbers[i];
                    }
                }
                arrayStatsLbl.Text += "Lowest Number: " + lowest + "\n";

                // the number of the numbers in the array
                arrayStatsLbl.Text += "Number of numbers: " + numbers.Count + "\n";
            }
            else
            {
                arrayStatsLbl.Text = "No numbers added.";
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            arrayStatsLbl.Text = "Array contents have been cleared.";
        }
    }
}
