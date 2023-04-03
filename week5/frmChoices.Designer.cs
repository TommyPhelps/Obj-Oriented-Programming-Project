
namespace Module5ProjectIFS
{
    partial class frmChoices
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
            this.InstructionsLbl = new System.Windows.Forms.Label();
            this.LeftNumRangeLbl = new System.Windows.Forms.Label();
            this.RightNumRangeLbl = new System.Windows.Forms.Label();
            this.RightNumRangeTxt = new System.Windows.Forms.TextBox();
            this.LeftNumRangeTxt = new System.Windows.Forms.TextBox();
            this.NumCheckLbl = new System.Windows.Forms.Label();
            this.NumCheckTxt = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MessageLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InstructionsLbl
            // 
            this.InstructionsLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLbl.Location = new System.Drawing.Point(30, 35);
            this.InstructionsLbl.Name = "InstructionsLbl";
            this.InstructionsLbl.Size = new System.Drawing.Size(740, 44);
            this.InstructionsLbl.TabIndex = 0;
            this.InstructionsLbl.Text = "Enter a number in each text box, click the button to show if the Is Between numbe" +
    "r is between the other two numbers";
            this.InstructionsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LeftNumRangeLbl
            // 
            this.LeftNumRangeLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftNumRangeLbl.Location = new System.Drawing.Point(30, 95);
            this.LeftNumRangeLbl.Name = "LeftNumRangeLbl";
            this.LeftNumRangeLbl.Size = new System.Drawing.Size(264, 28);
            this.LeftNumRangeLbl.TabIndex = 0;
            this.LeftNumRangeLbl.Text = "Left Number";
            this.LeftNumRangeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RightNumRangeLbl
            // 
            this.RightNumRangeLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightNumRangeLbl.Location = new System.Drawing.Point(506, 95);
            this.RightNumRangeLbl.Name = "RightNumRangeLbl";
            this.RightNumRangeLbl.Size = new System.Drawing.Size(264, 28);
            this.RightNumRangeLbl.TabIndex = 0;
            this.RightNumRangeLbl.Text = "Right Number (larger than the left)";
            this.RightNumRangeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RightNumRangeTxt
            // 
            this.RightNumRangeTxt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightNumRangeTxt.Location = new System.Drawing.Point(510, 127);
            this.RightNumRangeTxt.Name = "RightNumRangeTxt";
            this.RightNumRangeTxt.Size = new System.Drawing.Size(260, 29);
            this.RightNumRangeTxt.TabIndex = 1;
            // 
            // LeftNumRangeTxt
            // 
            this.LeftNumRangeTxt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftNumRangeTxt.Location = new System.Drawing.Point(34, 127);
            this.LeftNumRangeTxt.Name = "LeftNumRangeTxt";
            this.LeftNumRangeTxt.Size = new System.Drawing.Size(260, 29);
            this.LeftNumRangeTxt.TabIndex = 1;
            // 
            // NumCheckLbl
            // 
            this.NumCheckLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCheckLbl.Location = new System.Drawing.Point(268, 211);
            this.NumCheckLbl.Name = "NumCheckLbl";
            this.NumCheckLbl.Size = new System.Drawing.Size(264, 28);
            this.NumCheckLbl.TabIndex = 0;
            this.NumCheckLbl.Text = "Number to be Checked";
            this.NumCheckLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumCheckTxt
            // 
            this.NumCheckTxt.BackColor = System.Drawing.Color.LightYellow;
            this.NumCheckTxt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCheckTxt.Location = new System.Drawing.Point(272, 242);
            this.NumCheckTxt.Name = "NumCheckTxt";
            this.NumCheckTxt.Size = new System.Drawing.Size(260, 29);
            this.NumCheckTxt.TabIndex = 1;
            this.NumCheckTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.Red;
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(34, 277);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 2;
            this.ClearBtn.Text = "Clea&r";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CheckBtn
            // 
            this.CheckBtn.BackColor = System.Drawing.Color.Red;
            this.CheckBtn.ForeColor = System.Drawing.Color.White;
            this.CheckBtn.Location = new System.Drawing.Point(363, 277);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(75, 23);
            this.CheckBtn.TabIndex = 2;
            this.CheckBtn.Text = "&Check";
            this.CheckBtn.UseVisualStyleBackColor = false;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(695, 277);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MessageLbl
            // 
            this.MessageLbl.BackColor = System.Drawing.Color.Black;
            this.MessageLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLbl.ForeColor = System.Drawing.Color.Yellow;
            this.MessageLbl.Location = new System.Drawing.Point(30, 303);
            this.MessageLbl.Name = "MessageLbl";
            this.MessageLbl.Size = new System.Drawing.Size(740, 138);
            this.MessageLbl.TabIndex = 0;
            this.MessageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmChoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.NumCheckTxt);
            this.Controls.Add(this.LeftNumRangeTxt);
            this.Controls.Add(this.RightNumRangeTxt);
            this.Controls.Add(this.MessageLbl);
            this.Controls.Add(this.NumCheckLbl);
            this.Controls.Add(this.RightNumRangeLbl);
            this.Controls.Add(this.LeftNumRangeLbl);
            this.Controls.Add(this.InstructionsLbl);
            this.Name = "frmChoices";
            this.Text = "Choice2021";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstructionsLbl;
        private System.Windows.Forms.Label LeftNumRangeLbl;
        private System.Windows.Forms.Label RightNumRangeLbl;
        private System.Windows.Forms.TextBox RightNumRangeTxt;
        private System.Windows.Forms.TextBox LeftNumRangeTxt;
        private System.Windows.Forms.Label NumCheckLbl;
        private System.Windows.Forms.TextBox NumCheckTxt;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label MessageLbl;
    }
}

