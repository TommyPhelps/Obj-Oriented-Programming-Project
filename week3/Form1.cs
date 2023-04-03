using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module3Exercise2Project
{
    public partial class Form1 : Form
    {
        private object lblMessage;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            // Changed to label1.Text
            label1.Text = btnR.Text;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            // Changed to label1.Text
            label1.BackColor = btnRed.BackColor;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            // Changed to label1.Text
            label1.BackColor = btnBlue.BackColor;

        }

        private void btnL_Click(object sender, EventArgs e)
        {
            // Changed to label1.Text
            label1.Text = btnL.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
