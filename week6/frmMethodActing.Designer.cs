namespace Module6MethodsProjectDL
{
    partial class frmMethodActing
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
        /// 

        /*
         * Name: Shyan Phelps
         * Class Info: Obj-Orient Prg Using C# ITD-2343
         * Due Date: 2/19/2023
         */
        private void InitializeComponent()
        {
            this.RightOperandTxtBox = new System.Windows.Forms.TextBox();
            this.LeftOperandTxtBox = new System.Windows.Forms.TextBox();
            this.LeftOperandLbl = new System.Windows.Forms.Label();
            this.RightOperandLbl = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SubtractBtn = new System.Windows.Forms.Button();
            this.MultiplyBtn = new System.Windows.Forms.Button();
            this.DivideBtn = new System.Windows.Forms.Button();
            this.ModuloBtn = new System.Windows.Forms.Button();
            this.AnswerLbl = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RightOperandTxtBox
            // 
            this.RightOperandTxtBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightOperandTxtBox.Location = new System.Drawing.Point(157, 42);
            this.RightOperandTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.RightOperandTxtBox.Name = "RightOperandTxtBox";
            this.RightOperandTxtBox.Size = new System.Drawing.Size(122, 32);
            this.RightOperandTxtBox.TabIndex = 1;
            // 
            // LeftOperandTxtBox
            // 
            this.LeftOperandTxtBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftOperandTxtBox.Location = new System.Drawing.Point(157, 3);
            this.LeftOperandTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.LeftOperandTxtBox.Name = "LeftOperandTxtBox";
            this.LeftOperandTxtBox.Size = new System.Drawing.Size(122, 32);
            this.LeftOperandTxtBox.TabIndex = 0;
            // 
            // LeftOperandLbl
            // 
            this.LeftOperandLbl.AutoSize = true;
            this.LeftOperandLbl.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftOperandLbl.Location = new System.Drawing.Point(31, 5);
            this.LeftOperandLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LeftOperandLbl.Name = "LeftOperandLbl";
            this.LeftOperandLbl.Size = new System.Drawing.Size(128, 25);
            this.LeftOperandLbl.TabIndex = 2;
            this.LeftOperandLbl.Text = "Left Operand";
            // 
            // RightOperandLbl
            // 
            this.RightOperandLbl.AutoSize = true;
            this.RightOperandLbl.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightOperandLbl.Location = new System.Drawing.Point(25, 44);
            this.RightOperandLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RightOperandLbl.Name = "RightOperandLbl";
            this.RightOperandLbl.Size = new System.Drawing.Size(133, 25);
            this.RightOperandLbl.TabIndex = 3;
            this.RightOperandLbl.Text = "RightOperand";
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(8, 86);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(32, 37);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "+";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SubtractBtn
            // 
            this.SubtractBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractBtn.Location = new System.Drawing.Point(67, 86);
            this.SubtractBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SubtractBtn.Name = "SubtractBtn";
            this.SubtractBtn.Size = new System.Drawing.Size(32, 37);
            this.SubtractBtn.TabIndex = 3;
            this.SubtractBtn.Text = "-";
            this.SubtractBtn.UseVisualStyleBackColor = true;
            this.SubtractBtn.Click += new System.EventHandler(this.SubtractBtn_Click);
            // 
            // MultiplyBtn
            // 
            this.MultiplyBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyBtn.Location = new System.Drawing.Point(127, 86);
            this.MultiplyBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MultiplyBtn.Name = "MultiplyBtn";
            this.MultiplyBtn.Size = new System.Drawing.Size(32, 37);
            this.MultiplyBtn.TabIndex = 4;
            this.MultiplyBtn.Text = "*";
            this.MultiplyBtn.UseVisualStyleBackColor = true;
            this.MultiplyBtn.Click += new System.EventHandler(this.MultiplyBtn_Click);
            // 
            // DivideBtn
            // 
            this.DivideBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideBtn.Location = new System.Drawing.Point(186, 86);
            this.DivideBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DivideBtn.Name = "DivideBtn";
            this.DivideBtn.Size = new System.Drawing.Size(32, 37);
            this.DivideBtn.TabIndex = 5;
            this.DivideBtn.Text = "/";
            this.DivideBtn.UseVisualStyleBackColor = true;
            this.DivideBtn.Click += new System.EventHandler(this.DivideBtn_Click);
            // 
            // ModuloBtn
            // 
            this.ModuloBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModuloBtn.Location = new System.Drawing.Point(245, 86);
            this.ModuloBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ModuloBtn.Name = "ModuloBtn";
            this.ModuloBtn.Size = new System.Drawing.Size(32, 37);
            this.ModuloBtn.TabIndex = 6;
            this.ModuloBtn.Text = "%";
            this.ModuloBtn.UseVisualStyleBackColor = true;
            this.ModuloBtn.Click += new System.EventHandler(this.ModuloBtn_Click);
            // 
            // AnswerLbl
            // 
            this.AnswerLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AnswerLbl.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerLbl.Location = new System.Drawing.Point(8, 134);
            this.AnswerLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AnswerLbl.Name = "AnswerLbl";
            this.AnswerLbl.Size = new System.Drawing.Size(269, 84);
            this.AnswerLbl.TabIndex = 9;
            this.AnswerLbl.Text = "Answer Shows Here";
            this.AnswerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitBtn
            // 
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(8, 229);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(269, 37);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // frmMethodActing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(286, 272);
            this.Controls.Add(this.AnswerLbl);
            this.Controls.Add(this.ModuloBtn);
            this.Controls.Add(this.DivideBtn);
            this.Controls.Add(this.MultiplyBtn);
            this.Controls.Add(this.SubtractBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.RightOperandLbl);
            this.Controls.Add(this.LeftOperandLbl);
            this.Controls.Add(this.LeftOperandTxtBox);
            this.Controls.Add(this.RightOperandTxtBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMethodActing";
            this.Text = "A Methods to my Madness";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RightOperandTxtBox;
        private System.Windows.Forms.TextBox LeftOperandTxtBox;
        private System.Windows.Forms.Label LeftOperandLbl;
        private System.Windows.Forms.Label RightOperandLbl;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SubtractBtn;
        private System.Windows.Forms.Button MultiplyBtn;
        private System.Windows.Forms.Button DivideBtn;
        private System.Windows.Forms.Button ModuloBtn;
        private System.Windows.Forms.Label AnswerLbl;
        private System.Windows.Forms.Button ExitBtn;
    }
}

