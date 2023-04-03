using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module6MethodsProjectDL
{
    public partial class frmRealID : Form
    {
        // Public Contsants to use
        const byte ADD = 0;
        const byte SUBTRACT = 1;
        const byte MULTIPLY = 2;
        const byte DIVIDE = 3;
        const byte MODULUS = 4;

        public frmRealID()
        {
            InitializeComponent();
        }

        //Put Your method here
        /*
         * Name: Shyan Phelps
         * Class info: Obj-Orient Prg Using C# ITD-2343
         * Due date: 02-26-2023
         */

        private void modBtn_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            try
            {
                szLeft = leftOperandTxt.Text;
                szRight = rightOperandTxt.Text;

                dLeft = Convert.ToDecimal(szLeft);
                dRight = Convert.ToDecimal(szRight);

                if (dLeft < 0 || dRight < 0)
                {
                    throw new Exception("The values in the textboxes must be greater than 0");
                }

                dAnswer = dLeft % dRight;

                szAnswer = dAnswer.ToString();

                szEquation = szLeft + " % " + szRight + " = " + szAnswer;

                ansLbl.Text = "";
                ansLbl.Text = szEquation;
            }

            catch (FormatException)
            {
                ansLbl.Text = "Please enter a numeric value in the text box";
            }

            catch (DivideByZeroException)
            {
                ansLbl.Text = "You can't divide by zero";
            }

            catch (Exception ex)
            {
                ansLbl.Text = ex.Message;
            }

        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            try
            {
                szLeft = leftOperandTxt.Text;
                szRight = rightOperandTxt.Text;

                dLeft = Convert.ToDecimal(szLeft);
                dRight = Convert.ToDecimal(szRight);

                dAnswer = dLeft / dRight;

                szAnswer = dAnswer.ToString();

                szEquation = szLeft + " / " + szRight + " = " + szAnswer;

                ansLbl.Text = "";
                ansLbl.Text = szEquation;
            }

            catch(DivideByZeroException)
            {
                ansLbl.Text = "You can't divide by zero";
            }

            catch (FormatException)
            {
                ansLbl.Text = "Please enter a numeric value into the textbox";
            }

            catch (Exception ex)
            {
                ansLbl.Text = ex.Message;
            }
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            try
            {
                szLeft = leftOperandTxt.Text;
                szRight = rightOperandTxt.Text;

                dLeft = Convert.ToDecimal(szLeft);
                dRight = Convert.ToDecimal(szRight);

                dAnswer = dLeft * dRight;

                szAnswer = dAnswer.ToString();

                szEquation = szLeft + " * " + szRight + " = " + szAnswer;

                ansLbl.Text = "";
                ansLbl.Text = szEquation;
            }

            catch (FormatException)
            {
                ansLbl.Text = "Please enter a numeric value into the textbox";
            }

            catch (Exception ex)
            {
                ansLbl.Text = ex.Message;
            }
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            try
            {
                szLeft = leftOperandTxt.Text;
                szRight = rightOperandTxt.Text;

                dLeft = Convert.ToDecimal(szLeft);
                dRight = Convert.ToDecimal(szRight);

                dAnswer = dLeft - dRight;

                szAnswer = dAnswer.ToString();

                szEquation = szLeft + " - " + szRight + " = " + szAnswer;

                ansLbl.Text = "";
                ansLbl.Text = szEquation;
            }

            catch (FormatException)
            {
                ansLbl.Text = "Please enter a numeric value into the textbox";
            }

            catch (Exception ex)
            {
                ansLbl.Text = ex.Message;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            try
            {
                szLeft = leftOperandTxt.Text;
                szRight = rightOperandTxt.Text;

                dLeft = Convert.ToDecimal(szLeft);
                dRight = Convert.ToDecimal(szRight);

                dAnswer = dLeft + dRight;

                szAnswer = dAnswer.ToString();

                szEquation = szLeft + " + " + szRight + " = " + szAnswer;

                ansLbl.Text = "";
                ansLbl.Text = szEquation;
            }

            catch (FormatException)
            {
                ansLbl.Text = "Please enter a numeric value into the textbox";
            }

            catch (Exception ex)
            {
                ansLbl.Text = ex.Message;
            }
        }

        private void extBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
