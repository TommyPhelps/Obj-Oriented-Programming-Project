
namespace Module10Progress
{
    partial class frmRadioStar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.extBtn = new System.Windows.Forms.Button();
            this.rstBtn = new System.Windows.Forms.Button();
            this.lTxtBoxLbl = new System.Windows.Forms.Label();
            this.rTxtBoxLbl = new System.Windows.Forms.Label();
            this.lTxtBox = new System.Windows.Forms.TextBox();
            this.rTxtBox = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.msgLbl = new System.Windows.Forms.Label();
            this.mathGroupBox = new System.Windows.Forms.GroupBox();
            this.addRadBtn = new System.Windows.Forms.RadioButton();
            this.subRadBtn = new System.Windows.Forms.RadioButton();
            this.mulRadBtn = new System.Windows.Forms.RadioButton();
            this.divRadBtn = new System.Windows.Forms.RadioButton();
            this.modRadBtn = new System.Windows.Forms.RadioButton();
            this.verboseChkBox = new System.Windows.Forms.CheckBox();
            this.mathGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // extBtn
            // 
            this.extBtn.BackColor = System.Drawing.Color.LightCoral;
            this.extBtn.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extBtn.Location = new System.Drawing.Point(17, 74);
            this.extBtn.Name = "extBtn";
            this.extBtn.Size = new System.Drawing.Size(92, 31);
            this.extBtn.TabIndex = 0;
            this.extBtn.Text = "Exit";
            this.extBtn.UseVisualStyleBackColor = false;
            this.extBtn.Click += new System.EventHandler(this.extBtn_Click);
            // 
            // rstBtn
            // 
            this.rstBtn.BackColor = System.Drawing.Color.Thistle;
            this.rstBtn.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rstBtn.Location = new System.Drawing.Point(287, 74);
            this.rstBtn.Name = "rstBtn";
            this.rstBtn.Size = new System.Drawing.Size(92, 31);
            this.rstBtn.TabIndex = 1;
            this.rstBtn.Text = "Reset";
            this.rstBtn.UseVisualStyleBackColor = false;
            this.rstBtn.Click += new System.EventHandler(this.rstBtn_Click);
            // 
            // lTxtBoxLbl
            // 
            this.lTxtBoxLbl.AutoSize = true;
            this.lTxtBoxLbl.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTxtBoxLbl.Location = new System.Drawing.Point(12, 9);
            this.lTxtBoxLbl.Name = "lTxtBoxLbl";
            this.lTxtBoxLbl.Size = new System.Drawing.Size(166, 23);
            this.lTxtBoxLbl.TabIndex = 2;
            this.lTxtBoxLbl.Text = "Left Operand";
            // 
            // rTxtBoxLbl
            // 
            this.rTxtBoxLbl.AutoSize = true;
            this.rTxtBoxLbl.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtBoxLbl.Location = new System.Drawing.Point(200, 9);
            this.rTxtBoxLbl.Name = "rTxtBoxLbl";
            this.rTxtBoxLbl.Size = new System.Drawing.Size(179, 23);
            this.rTxtBoxLbl.TabIndex = 3;
            this.rTxtBoxLbl.Text = "Right Operand";
            // 
            // lTxtBox
            // 
            this.lTxtBox.BackColor = System.Drawing.Color.LightYellow;
            this.lTxtBox.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTxtBox.Location = new System.Drawing.Point(16, 35);
            this.lTxtBox.Name = "lTxtBox";
            this.lTxtBox.Size = new System.Drawing.Size(174, 31);
            this.lTxtBox.TabIndex = 4;
            // 
            // rTxtBox
            // 
            this.rTxtBox.BackColor = System.Drawing.Color.LightYellow;
            this.rTxtBox.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtBox.Location = new System.Drawing.Point(205, 35);
            this.rTxtBox.Name = "rTxtBox";
            this.rTxtBox.Size = new System.Drawing.Size(174, 31);
            this.rTxtBox.TabIndex = 5;
            // 
            // calcBtn
            // 
            this.calcBtn.BackColor = System.Drawing.Color.NavajoWhite;
            this.calcBtn.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtn.Location = new System.Drawing.Point(131, 74);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(137, 31);
            this.calcBtn.TabIndex = 6;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = false;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // msgLbl
            // 
            this.msgLbl.BackColor = System.Drawing.Color.LightGreen;
            this.msgLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLbl.Location = new System.Drawing.Point(13, 163);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(594, 278);
            this.msgLbl.TabIndex = 7;
            // 
            // mathGroupBox
            // 
            this.mathGroupBox.Controls.Add(this.modRadBtn);
            this.mathGroupBox.Controls.Add(this.divRadBtn);
            this.mathGroupBox.Controls.Add(this.mulRadBtn);
            this.mathGroupBox.Controls.Add(this.subRadBtn);
            this.mathGroupBox.Controls.Add(this.addRadBtn);
            this.mathGroupBox.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathGroupBox.Location = new System.Drawing.Point(385, 9);
            this.mathGroupBox.Name = "mathGroupBox";
            this.mathGroupBox.Size = new System.Drawing.Size(222, 137);
            this.mathGroupBox.TabIndex = 8;
            this.mathGroupBox.TabStop = false;
            this.mathGroupBox.Text = "Math Operations Available";
            // 
            // addRadBtn
            // 
            this.addRadBtn.AutoSize = true;
            this.addRadBtn.Checked = true;
            this.addRadBtn.Location = new System.Drawing.Point(6, 19);
            this.addRadBtn.Name = "addRadBtn";
            this.addRadBtn.Size = new System.Drawing.Size(119, 27);
            this.addRadBtn.TabIndex = 0;
            this.addRadBtn.TabStop = true;
            this.addRadBtn.Text = "Add (+)";
            this.addRadBtn.UseVisualStyleBackColor = true;
            // 
            // subRadBtn
            // 
            this.subRadBtn.AutoSize = true;
            this.subRadBtn.Location = new System.Drawing.Point(7, 43);
            this.subRadBtn.Name = "subRadBtn";
            this.subRadBtn.Size = new System.Drawing.Size(184, 27);
            this.subRadBtn.TabIndex = 1;
            this.subRadBtn.TabStop = true;
            this.subRadBtn.Text = "Subtract (-)";
            this.subRadBtn.UseVisualStyleBackColor = true;
            // 
            // mulRadBtn
            // 
            this.mulRadBtn.AutoSize = true;
            this.mulRadBtn.Location = new System.Drawing.Point(6, 67);
            this.mulRadBtn.Name = "mulRadBtn";
            this.mulRadBtn.Size = new System.Drawing.Size(184, 27);
            this.mulRadBtn.TabIndex = 2;
            this.mulRadBtn.TabStop = true;
            this.mulRadBtn.Text = "Multiply (*)";
            this.mulRadBtn.UseVisualStyleBackColor = true;
            // 
            // divRadBtn
            // 
            this.divRadBtn.AutoSize = true;
            this.divRadBtn.Location = new System.Drawing.Point(6, 90);
            this.divRadBtn.Name = "divRadBtn";
            this.divRadBtn.Size = new System.Drawing.Size(158, 27);
            this.divRadBtn.TabIndex = 3;
            this.divRadBtn.TabStop = true;
            this.divRadBtn.Text = "Divide (/)";
            this.divRadBtn.UseVisualStyleBackColor = true;
            // 
            // modRadBtn
            // 
            this.modRadBtn.AutoSize = true;
            this.modRadBtn.Location = new System.Drawing.Point(6, 114);
            this.modRadBtn.Name = "modRadBtn";
            this.modRadBtn.Size = new System.Drawing.Size(171, 27);
            this.modRadBtn.TabIndex = 4;
            this.modRadBtn.TabStop = true;
            this.modRadBtn.Text = "Modulus (%)";
            this.modRadBtn.UseVisualStyleBackColor = true;
            // 
            // verboseChkBox
            // 
            this.verboseChkBox.AutoSize = true;
            this.verboseChkBox.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verboseChkBox.Location = new System.Drawing.Point(17, 119);
            this.verboseChkBox.Name = "verboseChkBox";
            this.verboseChkBox.Size = new System.Drawing.Size(302, 27);
            this.verboseChkBox.TabIndex = 9;
            this.verboseChkBox.Text = "Verbose Mode (on/off)";
            this.verboseChkBox.UseVisualStyleBackColor = true;
            // 
            // frmRadioStar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.CancelButton = this.extBtn;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.verboseChkBox);
            this.Controls.Add(this.mathGroupBox);
            this.Controls.Add(this.msgLbl);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.rTxtBox);
            this.Controls.Add(this.lTxtBox);
            this.Controls.Add(this.rTxtBoxLbl);
            this.Controls.Add(this.lTxtBoxLbl);
            this.Controls.Add(this.rstBtn);
            this.Controls.Add(this.extBtn);
            this.Name = "frmRadioStar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radio Buttons in Action";
            this.mathGroupBox.ResumeLayout(false);
            this.mathGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button extBtn;
        private System.Windows.Forms.Button rstBtn;
        private System.Windows.Forms.Label lTxtBoxLbl;
        private System.Windows.Forms.Label rTxtBoxLbl;
        private System.Windows.Forms.TextBox lTxtBox;
        private System.Windows.Forms.TextBox rTxtBox;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label msgLbl;
        private System.Windows.Forms.GroupBox mathGroupBox;
        private System.Windows.Forms.RadioButton modRadBtn;
        private System.Windows.Forms.RadioButton divRadBtn;
        private System.Windows.Forms.RadioButton mulRadBtn;
        private System.Windows.Forms.RadioButton subRadBtn;
        private System.Windows.Forms.RadioButton addRadBtn;
        private System.Windows.Forms.CheckBox verboseChkBox;
    }
}

