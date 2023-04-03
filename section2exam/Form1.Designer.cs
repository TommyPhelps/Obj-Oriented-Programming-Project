
namespace Section2Exam_Project
{
    partial class Form1
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
            this.showModBtn = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.showFacBtn = new System.Windows.Forms.Button();
            this.showFibBtn = new System.Windows.Forms.Button();
            this.doFibBtn = new System.Windows.Forms.Button();
            this.doFacBtn = new System.Windows.Forms.Button();
            this.doModBtn = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.extBtn = new System.Windows.Forms.Button();
            this.msgLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showModBtn
            // 
            this.showModBtn.BackColor = System.Drawing.Color.Cornsilk;
            this.showModBtn.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showModBtn.Location = new System.Drawing.Point(16, 89);
            this.showModBtn.Name = "showModBtn";
            this.showModBtn.Size = new System.Drawing.Size(117, 28);
            this.showModBtn.TabIndex = 1;
            this.showModBtn.Text = "Modulus";
            this.showModBtn.UseVisualStyleBackColor = false;
            this.showModBtn.Click += new System.EventHandler(this.showModBtn_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox1.Location = new System.Drawing.Point(16, 19);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(363, 29);
            this.txtBox1.TabIndex = 0;
            this.txtBox1.TabStop = false;
            this.txtBox1.Text = "Text box 1";
            // 
            // txtBox2
            // 
            this.txtBox2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox2.Location = new System.Drawing.Point(16, 54);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(363, 29);
            this.txtBox2.TabIndex = 0;
            this.txtBox2.TabStop = false;
            this.txtBox2.Text = "Text box 2";
            // 
            // showFacBtn
            // 
            this.showFacBtn.BackColor = System.Drawing.Color.Cornsilk;
            this.showFacBtn.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFacBtn.Location = new System.Drawing.Point(139, 89);
            this.showFacBtn.Name = "showFacBtn";
            this.showFacBtn.Size = new System.Drawing.Size(117, 28);
            this.showFacBtn.TabIndex = 3;
            this.showFacBtn.Text = "Factorial";
            this.showFacBtn.UseVisualStyleBackColor = false;
            this.showFacBtn.Click += new System.EventHandler(this.showFacBtn_Click);
            // 
            // showFibBtn
            // 
            this.showFibBtn.BackColor = System.Drawing.Color.Cornsilk;
            this.showFibBtn.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFibBtn.Location = new System.Drawing.Point(262, 89);
            this.showFibBtn.Name = "showFibBtn";
            this.showFibBtn.Size = new System.Drawing.Size(117, 28);
            this.showFibBtn.TabIndex = 5;
            this.showFibBtn.Text = "Fibonacci";
            this.showFibBtn.UseVisualStyleBackColor = false;
            this.showFibBtn.Click += new System.EventHandler(this.showFibBtn_Click);
            // 
            // doFibBtn
            // 
            this.doFibBtn.BackColor = System.Drawing.Color.Cornsilk;
            this.doFibBtn.Enabled = false;
            this.doFibBtn.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doFibBtn.Location = new System.Drawing.Point(262, 123);
            this.doFibBtn.Name = "doFibBtn";
            this.doFibBtn.Size = new System.Drawing.Size(117, 28);
            this.doFibBtn.TabIndex = 6;
            this.doFibBtn.Text = "Calculate";
            this.doFibBtn.UseVisualStyleBackColor = false;
            this.doFibBtn.Click += new System.EventHandler(this.doFibBtn_Click);
            // 
            // doFacBtn
            // 
            this.doFacBtn.BackColor = System.Drawing.Color.Cornsilk;
            this.doFacBtn.Enabled = false;
            this.doFacBtn.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doFacBtn.Location = new System.Drawing.Point(139, 123);
            this.doFacBtn.Name = "doFacBtn";
            this.doFacBtn.Size = new System.Drawing.Size(117, 28);
            this.doFacBtn.TabIndex = 4;
            this.doFacBtn.Text = "Calculate";
            this.doFacBtn.UseVisualStyleBackColor = false;
            this.doFacBtn.Click += new System.EventHandler(this.doFacBtn_Click);
            // 
            // doModBtn
            // 
            this.doModBtn.BackColor = System.Drawing.Color.Cornsilk;
            this.doModBtn.Enabled = false;
            this.doModBtn.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doModBtn.Location = new System.Drawing.Point(16, 123);
            this.doModBtn.Name = "doModBtn";
            this.doModBtn.Size = new System.Drawing.Size(117, 28);
            this.doModBtn.TabIndex = 2;
            this.doModBtn.Text = "Calculate";
            this.doModBtn.UseVisualStyleBackColor = false;
            this.doModBtn.Click += new System.EventHandler(this.doModBtn_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.BackColor = System.Drawing.Color.Pink;
            this.clrBtn.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrBtn.Location = new System.Drawing.Point(16, 157);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(363, 28);
            this.clrBtn.TabIndex = 7;
            this.clrBtn.Text = "&Clear";
            this.clrBtn.UseVisualStyleBackColor = false;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // extBtn
            // 
            this.extBtn.BackColor = System.Drawing.Color.Pink;
            this.extBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.extBtn.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extBtn.Location = new System.Drawing.Point(16, 191);
            this.extBtn.Name = "extBtn";
            this.extBtn.Size = new System.Drawing.Size(363, 28);
            this.extBtn.TabIndex = 8;
            this.extBtn.Text = "E&xit";
            this.extBtn.UseVisualStyleBackColor = false;
            this.extBtn.Click += new System.EventHandler(this.extBtn_Click);
            // 
            // msgLbl
            // 
            this.msgLbl.BackColor = System.Drawing.Color.LightBlue;
            this.msgLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLbl.Location = new System.Drawing.Point(12, 222);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(367, 179);
            this.msgLbl.TabIndex = 0;
            this.msgLbl.Text = "Message displayed to user";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.extBtn;
            this.ClientSize = new System.Drawing.Size(393, 414);
            this.Controls.Add(this.msgLbl);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.doModBtn);
            this.Controls.Add(this.extBtn);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.doFacBtn);
            this.Controls.Add(this.doFibBtn);
            this.Controls.Add(this.showFibBtn);
            this.Controls.Add(this.showFacBtn);
            this.Controls.Add(this.showModBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operations Shyan Phelps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showModBtn;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Button showFacBtn;
        private System.Windows.Forms.Button showFibBtn;
        private System.Windows.Forms.Button doFibBtn;
        private System.Windows.Forms.Button doFacBtn;
        private System.Windows.Forms.Button doModBtn;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Button extBtn;
        private System.Windows.Forms.Label msgLbl;
    }
}

