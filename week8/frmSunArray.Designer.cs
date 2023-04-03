
namespace Module8ProjectsOfArrays
{
    partial class frmSunArray
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
            this.resetBtn = new System.Windows.Forms.Button();
            this.numTxtBoxLbl = new System.Windows.Forms.Label();
            this.numTxtBox = new System.Windows.Forms.TextBox();
            this.addNumToArray = new System.Windows.Forms.Button();
            this.showArrayStatsBtn = new System.Windows.Forms.Button();
            this.arrayContentsLbl = new System.Windows.Forms.Label();
            this.arrayStatsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // extBtn
            // 
            this.extBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.extBtn.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extBtn.Location = new System.Drawing.Point(190, 88);
            this.extBtn.Name = "extBtn";
            this.extBtn.Size = new System.Drawing.Size(169, 23);
            this.extBtn.TabIndex = 0;
            this.extBtn.Text = "Exit";
            this.extBtn.UseVisualStyleBackColor = true;
            this.extBtn.Click += new System.EventHandler(this.extBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(190, 59);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(169, 23);
            this.resetBtn.TabIndex = 0;
            this.resetBtn.Text = "Reset Array";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // numTxtBoxLbl
            // 
            this.numTxtBoxLbl.AutoSize = true;
            this.numTxtBoxLbl.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTxtBoxLbl.Location = new System.Drawing.Point(12, 9);
            this.numTxtBoxLbl.Name = "numTxtBoxLbl";
            this.numTxtBoxLbl.Size = new System.Drawing.Size(228, 18);
            this.numTxtBoxLbl.TabIndex = 1;
            this.numTxtBoxLbl.Text = "Please enter a number:";
            // 
            // numTxtBox
            // 
            this.numTxtBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTxtBox.Location = new System.Drawing.Point(246, 6);
            this.numTxtBox.Name = "numTxtBox";
            this.numTxtBox.Size = new System.Drawing.Size(163, 26);
            this.numTxtBox.TabIndex = 2;
            // 
            // addNumToArray
            // 
            this.addNumToArray.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNumToArray.Location = new System.Drawing.Point(15, 59);
            this.addNumToArray.Name = "addNumToArray";
            this.addNumToArray.Size = new System.Drawing.Size(169, 23);
            this.addNumToArray.TabIndex = 0;
            this.addNumToArray.Text = "Add Number To Array";
            this.addNumToArray.UseVisualStyleBackColor = true;
            this.addNumToArray.Click += new System.EventHandler(this.addNumToArray_Click);
            // 
            // showArrayStatsBtn
            // 
            this.showArrayStatsBtn.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showArrayStatsBtn.Location = new System.Drawing.Point(15, 88);
            this.showArrayStatsBtn.Name = "showArrayStatsBtn";
            this.showArrayStatsBtn.Size = new System.Drawing.Size(169, 23);
            this.showArrayStatsBtn.TabIndex = 0;
            this.showArrayStatsBtn.Text = "Show Array Statistics";
            this.showArrayStatsBtn.UseVisualStyleBackColor = true;
            this.showArrayStatsBtn.Click += new System.EventHandler(this.showArrayStatsBtn_Click);
            // 
            // arrayContentsLbl
            // 
            this.arrayContentsLbl.BackColor = System.Drawing.Color.LightBlue;
            this.arrayContentsLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrayContentsLbl.Location = new System.Drawing.Point(15, 120);
            this.arrayContentsLbl.Name = "arrayContentsLbl";
            this.arrayContentsLbl.Size = new System.Drawing.Size(169, 391);
            this.arrayContentsLbl.TabIndex = 3;
            this.arrayContentsLbl.Text = "Array Contents";
            // 
            // arrayStatsLbl
            // 
            this.arrayStatsLbl.BackColor = System.Drawing.Color.Thistle;
            this.arrayStatsLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrayStatsLbl.Location = new System.Drawing.Point(190, 120);
            this.arrayStatsLbl.Name = "arrayStatsLbl";
            this.arrayStatsLbl.Size = new System.Drawing.Size(219, 391);
            this.arrayStatsLbl.TabIndex = 3;
            this.arrayStatsLbl.Text = "Array Statistics";
            // 
            // frmSunArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.CancelButton = this.extBtn;
            this.ClientSize = new System.Drawing.Size(421, 523);
            this.Controls.Add(this.arrayStatsLbl);
            this.Controls.Add(this.arrayContentsLbl);
            this.Controls.Add(this.numTxtBox);
            this.Controls.Add(this.numTxtBoxLbl);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.showArrayStatsBtn);
            this.Controls.Add(this.addNumToArray);
            this.Controls.Add(this.extBtn);
            this.Name = "frmSunArray";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2021 Lab Week 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button extBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label numTxtBoxLbl;
        private System.Windows.Forms.TextBox numTxtBox;
        private System.Windows.Forms.Button addNumToArray;
        private System.Windows.Forms.Button showArrayStatsBtn;
        private System.Windows.Forms.Label arrayContentsLbl;
        private System.Windows.Forms.Label arrayStatsLbl;
    }
}

