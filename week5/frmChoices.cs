using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module5ProjectIFS
{
    public partial class frmChoices : Form
    {

        public frmChoices()
        {
            InitializeComponent();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            MessageLbl.Text = "";
            LeftNumRangeTxt.Text = "";
            RightNumRangeTxt.Text = "";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {

            //Checking if the text entered is equal to the text in the left text box
            if (int.Parse(NumCheckTxt.Text) == int.Parse(LeftNumRangeTxt.Text))
            {
                MessageLbl.Text = "The number is equal to the lower end of the range!";
            }

            //Checking if the text entered is equal to the text in the right text box
            if (int.Parse(NumCheckTxt.Text) == int.Parse(RightNumRangeTxt.Text))
            {
                MessageLbl.Text = "The number is equal to the upper end of the range!";
            }

            //Checking if the text entered is less than the text in the left text box
            if (int.Parse(NumCheckTxt.Text) < int.Parse(LeftNumRangeTxt.Text))
            {
                MessageLbl.Text = "The number is less than the lowest end of the range!";
            }

            //Checking if the text entered is greater than the text in the left text box
            if (int.Parse(NumCheckTxt.Text) > int.Parse(RightNumRangeTxt.Text))
            {
                MessageLbl.Text = "The number is greater than the highest end of the range!";
            }

            //Checking if the text entered is in between the text in the left text box and the text entered into the right text box
            if (int.Parse(NumCheckTxt.Text) > int.Parse(LeftNumRangeTxt.Text) && int.Parse(NumCheckTxt.Text) < int.Parse(RightNumRangeTxt.Text))
            {
                MessageLbl.Text = "The number is in the range of " + int.Parse(LeftNumRangeTxt.Text) + " and " + int.Parse(RightNumRangeTxt.Text) + "!";
            }

            //Clearing the text box that checks the numbers
            NumCheckTxt.Text = "";
        }
    }
}
