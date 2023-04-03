using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section2Exam_Project
{
    public partial class Form1 : Form
    {
        /*
         * Name:      Shyan Phelps
         * Class:     ITD-2343
         * Trimester: Spring
         * Due Date:  3/5/2023
         */

        public Form1()
        {
            InitializeComponent();
            msgLbl.Text = "";
            txtBox1.Text = "";
            txtBox2.Text = "";
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            msgLbl.Text = "";
            msgLbl.Text = "Messages cleared!";
        }

        private async void extBtn_Click(object sender, EventArgs e)
        {
            msgLbl.Text = "Thanks for using the application!";
            await Task.Delay(3000);
            this.Close();
        }

        private void showModBtn_Click(object sender, EventArgs e)
        {
            msgLbl.Text = "Please enter the values for the Modulus operation in the text boxes above.";
            txtBox2.Enabled = true;
            doModBtn.Enabled = true;
            doFacBtn.Enabled = false;
            doFibBtn.Enabled = false;
        }

        private void showFacBtn_Click(object sender, EventArgs e)
        {
            msgLbl.Text = "Please enter the value for the Factorial operation in the text box above.";
            txtBox2.Enabled = false;
            doModBtn.Enabled = false;
            doFacBtn.Enabled = true;
            doFibBtn.Enabled = false;
        }

        private void showFibBtn_Click(object sender, EventArgs e)
        {
            msgLbl.Text = "Please enter the value for the Fibonacci operation in the text box above.";
            txtBox2.Enabled = false;
            doModBtn.Enabled = false;
            doFacBtn.Enabled = false;
            doFibBtn.Enabled = true;
        }

        private void doModBtn_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "")
            {
                MessageBox.Show("Please enter a value into the first text box.");
                txtBox1.Focus();
            }
            else if (txtBox2.Text == "")
            {
                MessageBox.Show("Please enter a value into the second text box.");
                txtBox2.Focus();
            }
            else
            {
                try
                {
                    int dividend = Convert.ToInt32(txtBox1.Text);
                    int divisor = Convert.ToInt32(txtBox2.Text);
                    int quotient = 0;
                    int remainder = 0;

                    for (int i = 0; i < dividend; i += divisor)
                    {
                        quotient++;
                        remainder = dividend - i - divisor;

                        if (remainder < divisor)
                        {
                            break;
                        }
                    }
                    msgLbl.Text = Convert.ToString(dividend) + " divided by " + Convert.ToString(divisor) + " is " + Convert.ToString(quotient) + " with a remainder of " + Convert.ToString(remainder);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
                }
            }
        }

        private void doFacBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBox1.Text == "")
                {
                    MessageBox.Show("Please enter a value into the first text box.");
                    txtBox1.Focus();
                }
                else if (Convert.ToInt32(txtBox1.Text) > 18)
                {
                    MessageBox.Show("Please enter a value lower than 18 into the text box that isn't a negative number into the first textbox.");
                    txtBox1.Text = "";
                    txtBox1.Focus();
                }
                else if (Convert.ToInt32(txtBox1.Text) < 0)
                {
                    MessageBox.Show("Please enter a positive number that is lower than 18 into the first textbox.");
                    txtBox1.Text = "";
                    txtBox1.Focus();
                }
                else
                {
                    try
                    {
                        int facValue = Convert.ToInt32(txtBox1.Text);
                        int m = 1;
                        int f = 1;

                        while (m <= facValue)
                        {
                            f *= m;
                            m += 1;
                        }
                        msgLbl.Text = "The answer to " + Convert.ToString(facValue + "! is " + Convert.ToString(f));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter an integer into the first textbox " + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
                txtBox1.Text = "";
                txtBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
        }

        private void doFibBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBox1.Text == "")
                {
                    MessageBox.Show("Please enter a value into the first text box.");
                    txtBox1.Focus();
                }
                else if (Convert.ToInt32(txtBox1.Text) > 99)
                {
                    MessageBox.Show("Please enter a value lower than 18 into the text box that isn't a negative number into the first textbox.");
                    txtBox1.Text = "";
                    txtBox1.Focus();
                }
                /*else if (Convert.ToInt32(txtBox1.Text) < 0)
                {
                    MessageBox.Show("Please enter a positive number that is lower than 99 into the first textbox.");
                    txtBox1.Text = "";
                    txtBox1.Focus();
                }*/
                else
                {
                    try
                    {
                        int fibValue = Convert.ToInt32(txtBox1.Text);
                        int i = 0;
                        int j = 1;
                        int k = 0;
                        int fib = 0;

                        while (i < fibValue)
                        {
                            fib = j + k;
                            msgLbl.Text = "Fibonacci(" + Convert.ToString(fibValue) + ") = Fibonacci(" + Convert.ToString(fibValue - 1) + ") + Fibonacci(" + Convert.ToString(fibValue - 2) + ") = " + Convert.ToString(k) + " + " + Convert.ToString(j) + " = " + Convert.ToString(fib);
                            j = k;
                            k = fib;
                            i += 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter an integer into the first textbox " + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
                txtBox1.Text = "";
                txtBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
        }
    }
}
