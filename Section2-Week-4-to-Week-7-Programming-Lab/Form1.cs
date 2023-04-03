using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sec2ProgramLab_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void processBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int number = int.Parse(conTxtBox.Text);
                int fromBase = int.Parse(baseTxtBox.Text);

                string result = convertToBase(number, fromBase);

                msgLbl.Text = result;
            }
        }

        private void octalBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(conTxtBox.Text))
            {
                int number = int.Parse(conTxtBox.Text);

                string result = convertToBase(number, 8);

                msgLbl.Text = result;
            }
        }

        private void hexBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(conTxtBox.Text))
            {
                int number = int.Parse(conTxtBox.Text);

                string result = convertToHex(number);

                msgLbl.Text = "0x" + Convert.ToString(result);
            }
        }

        private void binaryBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(conTxtBox.Text))
            {
                int number = int.Parse(conTxtBox.Text);

                string result = convertToBinary(number);

                msgLbl.Text = Convert.ToString(result);
            }
        }

        private void base6Btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(conTxtBox.Text))
            {
                int number = int.Parse(conTxtBox.Text);

                string result = convertToBase6(number);

                msgLbl.Text = Convert.ToString(result);
            }
        }

        private void base9Btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(conTxtBox.Text))
            {
                int number = int.Parse(conTxtBox.Text);

                string result = convertToBase9(number);

                msgLbl.Text = Convert.ToString(result);
            }
        }

        private bool ValidateInput()
        {
            if (!int.TryParse(conTxtBox.Text, out int number))
            {
                msgLbl.Text = "Error: Invalid input for number to convert";
                return false;
            }

            if (!int.TryParse(baseTxtBox.Text, out int fromBase))
            {
                msgLbl.Text = "Error: Invalid input for base";
                return false;
            }

            if (number < 0 || fromBase < 2 || fromBase > 16)
            {
                msgLbl.Text = "Error: Invalid input";
                return false;
            }

            if (conTxtBox.Text.Contains(".") || baseTxtBox.Text.Contains("."))
            {
                msgLbl.Text = "Error: Decimal input not allowed";
                return false;
            }

            return true;
        }

        private string convertToBase(int number, int fromBase)
        {
            string result = "";

            while (number > 0)
            {
                int remainder = number % fromBase;

                if (remainder < 10)
                {
                    result = remainder + result;
                }
                else
                {
                    result = ((char)('A' + remainder - 10)).ToString() + result;
                }

                number /= fromBase;
            }

            if (result == "")
            {
                result = "0";
            }

            return result;
        }

        private string convertToHex(int number)
        {
            string hexString = "";
            int quotient = number;
            int remainder;

            while (quotient > 0)
            {
                remainder = quotient % 16;
                hexString = HexDigit(remainder) + hexString;
                quotient /= 16;
            }

            return hexString;
        }

        private static char HexDigit(int value)
        {
            if (value < 10)
            {
                return (char)('0' + value);
            }
            else
            {
                return (char)('A' + (value - 10));
            }
        }

        public static string convertToBinary(int number)
        {
            string binaryString = "";
            int quotient = number;
            int remainder;

            while (quotient > 0)
            {
                remainder = quotient % 2;
                binaryString = remainder.ToString() + binaryString;
                quotient /= 2;
            }

            return binaryString;
        }

        private string convertToBase6(int number)
        {
            string base6String = "";
            int quotient = number;
            int remainder;

            while (quotient > 0)
            {
                remainder = quotient % 6;
                base6String = remainder.ToString() + base6String;
                quotient /= 6;
            }

            return base6String;
        }

        private string convertToBase9(int number)
        {
            string base9String = "";
            int quotient = number;
            int remainder;

            while (quotient > 0)
            {
                remainder = quotient % 9;
                base9String = remainder.ToString() + base9String;
                quotient /= 9;
            }

            return base9String;
        }

        private void extBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void conTxtBox_TextChanged(object sender, EventArgs e)
        {
            ClrBtn.Enabled = !string.IsNullOrEmpty(conTxtBox.Text);
            binaryBtn.Enabled = !string.IsNullOrEmpty(conTxtBox.Text);
            hexBtn.Enabled = !string.IsNullOrEmpty(conTxtBox.Text);
            octalBtn.Enabled = !string.IsNullOrEmpty(conTxtBox.Text);
            base6Btn.Enabled = !string.IsNullOrEmpty(conTxtBox.Text);
            base9Btn.Enabled = !string.IsNullOrEmpty(conTxtBox.Text);
            processBtn.Enabled = !string.IsNullOrEmpty(conTxtBox.Text) && !string.IsNullOrEmpty(baseTxtBox.Text);
        }

        private void baseTxtBox_TextChanged(object sender, EventArgs e)
        {
            processBtn.Enabled = !string.IsNullOrEmpty(conTxtBox.Text) && !string.IsNullOrEmpty(baseTxtBox.Text);
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            conTxtBox.Text = "";
            baseTxtBox.Text = "";
        }
    }
}
