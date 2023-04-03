using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module10Progress
{
    public partial class frmRadioStar : Form
    {
        /*
         * Name: Shyan Phelps
         * Class info: Obj-Orient Prg Using C# ITD-2343
         * Due date: 03-26-2023
         */

        public frmRadioStar()
        {
            InitializeComponent();
        }

        private void extBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rstBtn_Click(object sender, EventArgs e)
        {
            lTxtBox.Text = "";
            rTxtBox.Text = "";
            addRadBtn.Checked = true;
            msgLbl.Text = "";
            verboseChkBox.Checked = true;
            lTxtBox.Focus();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                int lTxtBoxInt = Convert.ToInt32(lTxtBox.Text);
                int rTxtBoxInt = Convert.ToInt32(rTxtBox.Text);

                if (addRadBtn.Checked)
                {
                    msgLbl.Text = addNums(lTxtBoxInt, rTxtBoxInt);
                }
                else if (subRadBtn.Checked)
                {
                    msgLbl.Text = subNums(lTxtBoxInt, rTxtBoxInt);
                }
                else if (mulRadBtn.Checked)
                {
                    msgLbl.Text = Convert.ToString(mulNums(lTxtBoxInt, rTxtBoxInt));
                }
                else if (divRadBtn.Checked)
                {
                    msgLbl.Text = Convert.ToString(divNums(lTxtBoxInt, rTxtBoxInt));
                }
                else if (modRadBtn.Checked)
                {
                    msgLbl.Text = Convert.ToString(modNums(lTxtBoxInt, rTxtBoxInt));
                }
                else
                {
                    msgLbl.Text = "Please enter a numeric value into the message box";
                }
            }
        }

        private bool isValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += isInt(lTxtBox.Text, rTxtBox.Text);
            errorMessage += isFilled(lTxtBox.Text, rTxtBox.Text);
            errorMessage += noDivisionByZero(rTxtBox.Text);

            if (errorMessage != "")
            {
                success = false;
                msgLbl.Text = errorMessage;
            }
            return success;
        }

        private string isInt(string lTxtBox, string rTxtBox)
        {
            if (lTxtBox != "" || rTxtBox != "")
            {
                string msg = "";
                if (!int.TryParse(rTxtBox, out _) && !int.TryParse(lTxtBox, out _))
                {
                    msg += "Please only enter numbers into both text boxes.\n";
                }
                else if (!int.TryParse(lTxtBox, out _))
                {
                    msg += "Please only enter numbers into the left text box.\n";
                }
                else if (!int.TryParse(rTxtBox, out _))
                {
                    msg += "Please only enter numbers into the right text box.\n";
                }
                return msg;
            }
            else
            {
                string msg = "";
                return msg;
            }
        }

        private string isFilled(string lTxtBox, string rTxtBox)
        {
            string msg = "";
            if (lTxtBox == "" && rTxtBox == "")
            {
                msg += "Please ensure that both text boxes are filled.\n";
            }
            else if(lTxtBox == "")
            {
                msg += "Please ensure that the left text box is filled.\n";
            }
            else if (rTxtBox == "")
            {
                msg += "Please ensure that the right text box is filled.\n";
            }
            return msg;
        }

        private string noDivisionByZero(string rTxtBox)
        {
            string msg = "";
            if (divRadBtn.Checked == true)
            {
                if (rTxtBox == "0")
                {
                    msg += "There is no division by zero.\n";
                }
            }
            return msg;
        }

        private string addNums(int num1, int num2)
        {
            string strNum1 = Convert.ToString(num1);
            string strNum2 = Convert.ToString(num2);
            if (verboseChkBox.Checked)
            {
                int result = num1 + num2;
                string strResult = Convert.ToString(result);
                string fullResult = strNum1 + " + " + strNum2 + " = " + strResult;
                return fullResult;
            }
            else
            {
                int result = num1 + num2;
                string strResult = Convert.ToString(result);
                string fullResult = "The answer is: " + strResult;
                return fullResult;
            }
        }

        private string subNums(int num1, int num2)
        {
            string strNum1 = Convert.ToString(num1);
            string strNum2 = Convert.ToString(num2);
            if (verboseChkBox.Checked)
            {
                int result = num1 - num2;
                string strResult = Convert.ToString(result);
                string fullResult = strNum1 + " - " + strNum2 + " = " + strResult;
                return fullResult;
            }
            else
            {
                int result = num1 - num2;
                string strResult = Convert.ToString(result);
                string fullResult = "The answer is: " + strResult;
                return fullResult;
            }
        }

        private string mulNums(int num1, int num2)
        {
            string strNum1 = Convert.ToString(num1);
            string strNum2 = Convert.ToString(num2);
            if (verboseChkBox.Checked)
            {
                int result = num1 * num2;
                string strResult = Convert.ToString(result);
                string fullResult = strNum1 + " * " + strNum2 + " = " + strResult;
                return fullResult;
            }
            else
            {
                int result = num1 * num2;
                string strResult = Convert.ToString(result);
                string fullResult = "The answer is: " + strResult;
                return fullResult;
            }
        }

        private string divNums(int num1, int num2)
        {
            string strNum1 = Convert.ToString(num1);
            string strNum2 = Convert.ToString(num2);
            if (verboseChkBox.Checked)
            {
                int result = num1 / num2;
                string strResult = Convert.ToString(result);
                string fullResult = strNum1 + " / " + strNum2 + " = " + strResult;
                return fullResult;
            }
            else
            {
                int result = num1 / num2;
                string strResult = Convert.ToString(result);
                string fullResult = "The answer is: " + strResult;
                return fullResult;
            }
        }

        private string modNums(int num1, int num2)
        {
            string strNum1 = Convert.ToString(num1);
            string strNum2 = Convert.ToString(num2);
            if (verboseChkBox.Checked)
            {
                int result = num1 % num2;
                string strResult = Convert.ToString(result);
                string fullResult = strNum1 + " % " + strNum2 + " = " + strResult;
                return fullResult;
            }
            else
            {
                int result = num1 % num2;
                string strResult = Convert.ToString(result);
                string fullResult = "The answer is: " + strResult;
                return fullResult;
            }
        }
    }
}
