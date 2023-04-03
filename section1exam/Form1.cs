using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section1Exam_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LetButtA_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtA.Text;
        }

        private void LetButtB_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtB.Text;
        }

        private void LetButtC_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtC.Text;
        }

        private void LetButtD_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtD.Text;
        }

        private void LetButtE_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtE.Text;
        }

        private void LetButtF_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtF.Text;
        }

        private void LetButtG_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtG.Text;
        }

        private void LetButtH_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtH.Text;
        }

        private void LetButtI_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtI.Text;
        }

        private void LetButtJ_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtJ.Text;
        }

        private void LetButtK_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtK.Text;
        }

        private void LetButtL_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtL.Text;
        }

        private void LetButtM_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtM.Text;
        }

        private void LetButtN_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtN.Text;
        }

        private void LetButtO_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtO.Text;
        }

        private void LetButtP_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtP.Text;
        }

        private void LetButtQ_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtQ.Text;
        }

        private void LetButtR_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtR.Text;
        }

        private void LetButtS_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtS.Text;
        }

        private void LetButtT_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtT.Text;
        }

        private void LetButtU_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtU.Text;
        }

        private void LetButtV_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtV.Text;
        }

        private void LetButtW_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtW.Text;
        }

        private void LetButtX_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtX.Text;
        }

        private void LetButtY_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtY.Text;
        }

        private void LetButtZ_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtZ.Text;
        }

        private void LetButtPeriod_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + LetButtPeriod.Text;
        }

        private void NumButt1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + NumButt1.Text;
        }

        private void NumButt2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + NumButt2.Text;
        }

        private void NumButt3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + NumButt3.Text;
        }

        private void NumButt4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + NumButt4.Text;
        }

        private void NumButt5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + NumButt5.Text;
        }

        private void NumButt6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + NumButt6.Text;
        }

        private void NumButt7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + NumButt7.Text;
        }

        private void NumButt8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + NumButt8.Text;
        }

        private void NumButt9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + NumButt9.Text;
        }

        private void NumButt0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + NumButt0.Text;
        }

        private void ActButtBlank_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " ";
        }

        private void ActButtSend_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            textBox1.Text = "";
        }

        private void ActButtClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /*
         * Tommy Phelps
         * Obj-Orient Prg Using C# - ITD-1253
         * Spring Trimester
         * 2/5/2023
         */
    }
}
