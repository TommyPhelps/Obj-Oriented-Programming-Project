namespace Module6MethodsProjectDL
{
    partial class frmRealID
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
            this.rightOperandTxt = new System.Windows.Forms.TextBox();
            this.leftOperandTxt = new System.Windows.Forms.TextBox();
            this.leftOperandLbl = new System.Windows.Forms.Label();
            this.rightOperandLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.mulBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.modBtn = new System.Windows.Forms.Button();
            this.ansLbl = new System.Windows.Forms.Label();
            this.extBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rightOperandTxt
            // 
            this.rightOperandTxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightOperandTxt.Location = new System.Drawing.Point(157, 42);
            this.rightOperandTxt.Margin = new System.Windows.Forms.Padding(2);
            this.rightOperandTxt.Name = "rightOperandTxt";
            this.rightOperandTxt.Size = new System.Drawing.Size(122, 32);
            this.rightOperandTxt.TabIndex = 1;
            // 
            // leftOperandTxt
            // 
            this.leftOperandTxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftOperandTxt.Location = new System.Drawing.Point(157, 3);
            this.leftOperandTxt.Margin = new System.Windows.Forms.Padding(2);
            this.leftOperandTxt.Name = "leftOperandTxt";
            this.leftOperandTxt.Size = new System.Drawing.Size(122, 32);
            this.leftOperandTxt.TabIndex = 0;
            // 
            // leftOperandLbl
            // 
            this.leftOperandLbl.AutoSize = true;
            this.leftOperandLbl.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftOperandLbl.Location = new System.Drawing.Point(31, 5);
            this.leftOperandLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.leftOperandLbl.Name = "leftOperandLbl";
            this.leftOperandLbl.Size = new System.Drawing.Size(128, 25);
            this.leftOperandLbl.TabIndex = 0;
            this.leftOperandLbl.Text = "Left Operand";
            // 
            // rightOperandLbl
            // 
            this.rightOperandLbl.AutoSize = true;
            this.rightOperandLbl.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightOperandLbl.Location = new System.Drawing.Point(25, 44);
            this.rightOperandLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rightOperandLbl.Name = "rightOperandLbl";
            this.rightOperandLbl.Size = new System.Drawing.Size(133, 25);
            this.rightOperandLbl.TabIndex = 0;
            this.rightOperandLbl.Text = "RightOperand";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(8, 86);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(32, 37);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // subBtn
            // 
            this.subBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBtn.Location = new System.Drawing.Point(67, 86);
            this.subBtn.Margin = new System.Windows.Forms.Padding(2);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(32, 37);
            this.subBtn.TabIndex = 3;
            this.subBtn.Text = "-";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // mulBtn
            // 
            this.mulBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulBtn.Location = new System.Drawing.Point(127, 86);
            this.mulBtn.Margin = new System.Windows.Forms.Padding(2);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(32, 37);
            this.mulBtn.TabIndex = 4;
            this.mulBtn.Text = "*";
            this.mulBtn.UseVisualStyleBackColor = true;
            this.mulBtn.Click += new System.EventHandler(this.mulBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divBtn.Location = new System.Drawing.Point(186, 86);
            this.divBtn.Margin = new System.Windows.Forms.Padding(2);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(32, 37);
            this.divBtn.TabIndex = 5;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // modBtn
            // 
            this.modBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modBtn.Location = new System.Drawing.Point(245, 86);
            this.modBtn.Margin = new System.Windows.Forms.Padding(2);
            this.modBtn.Name = "modBtn";
            this.modBtn.Size = new System.Drawing.Size(32, 37);
            this.modBtn.TabIndex = 6;
            this.modBtn.Text = "%";
            this.modBtn.UseVisualStyleBackColor = true;
            this.modBtn.Click += new System.EventHandler(this.modBtn_Click);
            // 
            // ansLbl
            // 
            this.ansLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ansLbl.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansLbl.Location = new System.Drawing.Point(8, 134);
            this.ansLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ansLbl.Name = "ansLbl";
            this.ansLbl.Size = new System.Drawing.Size(269, 84);
            this.ansLbl.TabIndex = 0;
            this.ansLbl.Text = "Answer Shows Here";
            this.ansLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // extBtn
            // 
            this.extBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.extBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extBtn.Location = new System.Drawing.Point(8, 229);
            this.extBtn.Margin = new System.Windows.Forms.Padding(2);
            this.extBtn.Name = "extBtn";
            this.extBtn.Size = new System.Drawing.Size(269, 37);
            this.extBtn.TabIndex = 2;
            this.extBtn.Text = "Exit";
            this.extBtn.UseVisualStyleBackColor = true;
            this.extBtn.Click += new System.EventHandler(this.extBtn_Click);
            // 
            // frmRealID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.CancelButton = this.extBtn;
            this.ClientSize = new System.Drawing.Size(286, 270);
            this.Controls.Add(this.ansLbl);
            this.Controls.Add(this.modBtn);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.mulBtn);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.extBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.rightOperandLbl);
            this.Controls.Add(this.leftOperandLbl);
            this.Controls.Add(this.leftOperandTxt);
            this.Controls.Add(this.rightOperandTxt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRealID";
            this.Text = "Valid ID Required";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rightOperandTxt;
        private System.Windows.Forms.TextBox leftOperandTxt;
        private System.Windows.Forms.Label leftOperandLbl;
        private System.Windows.Forms.Label rightOperandLbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button mulBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button modBtn;
        private System.Windows.Forms.Label ansLbl;
        private System.Windows.Forms.Button extBtn;
    }
}

