using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2_60438Project
{
    public partial class frm60438 : Form
    {
        public frm60438()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Clear the label
        private void button1_Click(object sender, EventArgs e)
        {
            lblText.Text = "";
        }

        // Add text from text box to label
        private void button2_Click(object sender, EventArgs e)
        {
            lblText.Text = txtBox.Text;
        }

        // Clear the text box
        private void button3_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";
        }

        // Closes program
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
