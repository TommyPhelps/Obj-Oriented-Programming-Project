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
    public partial class frmMethodActing : Form
    {
       /*
        * Name: Shyan Phelps
        * Class Info: Obj-Orient Prg Using C# ITD-2343
        * Due Date: 2/19/2023
        */

        // Public Contsants to use
        const byte ADD = 0;
        const byte SUBTRACT = 1;
        const byte MULTIPLY = 2;
        const byte DIVIDE = 3;
        const byte MODULUS = 4;

        public frmMethodActing()
        {
            InitializeComponent();
        }


        //Put Your method here
        private decimal Calculations(decimal num1, decimal num2, byte operation)
        {
            decimal answer = 0;

            if (operation == ADD)
            {
                answer = num1 + num2;
            }

            if (operation == SUBTRACT)
            {
                answer = num1 - num2;
            }

            if (operation == MULTIPLY)
            {
                answer = num1 * num2;
            }

            if (operation == DIVIDE)
            {
                answer = num1 / num2;
            }

            if (operation == MODULUS)
            {
                answer = num1 % num2;
            }

            return answer;
        }

        private void ModuloBtn_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = LeftOperandTxtBox.Text;
            szRight = RightOperandTxtBox.Text;

            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = Calculations(dLeft, dRight, MODULUS);

            szAnswer = dAnswer.ToString();

            szEquation = szLeft + " % " + szRight + " = " + szAnswer;

            AnswerLbl.Text = "";
            AnswerLbl.Text = szEquation;
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = LeftOperandTxtBox.Text;
            szRight = RightOperandTxtBox.Text;

            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = Calculations(dLeft, dRight, DIVIDE);

            szAnswer = dAnswer.ToString();

            szEquation = szLeft + " / " + szRight + " = " + szAnswer;

            AnswerLbl.Text = "";
            AnswerLbl.Text = szEquation;
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = LeftOperandTxtBox.Text;
            szRight = RightOperandTxtBox.Text;

            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = Calculations(dLeft, dRight, MULTIPLY);

            szAnswer = dAnswer.ToString();

            szEquation = szLeft + " * " + szRight + " = " + szAnswer;

            AnswerLbl.Text = "";
            AnswerLbl.Text = szEquation;
        }

        private void SubtractBtn_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = LeftOperandTxtBox.Text;
            szRight = RightOperandTxtBox.Text;

            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = Calculations(dLeft, dRight, SUBTRACT);

            szAnswer = dAnswer.ToString();

            szEquation = szLeft + " - " + szRight + " = " + szAnswer;

            AnswerLbl.Text = "";
            AnswerLbl.Text = szEquation;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = LeftOperandTxtBox.Text;
            szRight = RightOperandTxtBox.Text;

            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = Calculations(dLeft, dRight, ADD);

            szAnswer = dAnswer.ToString();

            szEquation = szLeft + " + " + szRight + " = " + szAnswer;

            AnswerLbl.Text = "";
            AnswerLbl.Text = szEquation;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
