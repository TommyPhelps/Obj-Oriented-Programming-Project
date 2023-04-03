
namespace Sec2ProgramLab_Project
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
            this.conTxtBox = new System.Windows.Forms.TextBox();
            this.baseTxtBox = new System.Windows.Forms.TextBox();
            this.conTxtBoxLbl = new System.Windows.Forms.Label();
            this.baseTxtBoxLbl = new System.Windows.Forms.Label();
            this.binaryBtn = new System.Windows.Forms.Button();
            this.hexBtn = new System.Windows.Forms.Button();
            this.octalBtn = new System.Windows.Forms.Button();
            this.base6Btn = new System.Windows.Forms.Button();
            this.base9Btn = new System.Windows.Forms.Button();
            this.processBtn = new System.Windows.Forms.Button();
            this.extBtn = new System.Windows.Forms.Button();
            this.ClrBtn = new System.Windows.Forms.Button();
            this.msgLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // conTxtBox
            // 
            this.conTxtBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conTxtBox.Location = new System.Drawing.Point(191, 11);
            this.conTxtBox.Name = "conTxtBox";
            this.conTxtBox.Size = new System.Drawing.Size(100, 26);
            this.conTxtBox.TabIndex = 0;
            this.conTxtBox.TextChanged += new System.EventHandler(this.conTxtBox_TextChanged);
            // 
            // baseTxtBox
            // 
            this.baseTxtBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseTxtBox.Location = new System.Drawing.Point(191, 41);
            this.baseTxtBox.Name = "baseTxtBox";
            this.baseTxtBox.Size = new System.Drawing.Size(100, 26);
            this.baseTxtBox.TabIndex = 1;
            this.baseTxtBox.TextChanged += new System.EventHandler(this.baseTxtBox_TextChanged);
            // 
            // conTxtBoxLbl
            // 
            this.conTxtBoxLbl.AutoSize = true;
            this.conTxtBoxLbl.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conTxtBoxLbl.Location = new System.Drawing.Point(13, 14);
            this.conTxtBoxLbl.Name = "conTxtBoxLbl";
            this.conTxtBoxLbl.Size = new System.Drawing.Size(178, 18);
            this.conTxtBoxLbl.TabIndex = 3;
            this.conTxtBoxLbl.Text = "Number to convert";
            // 
            // baseTxtBoxLbl
            // 
            this.baseTxtBoxLbl.AutoSize = true;
            this.baseTxtBoxLbl.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseTxtBoxLbl.Location = new System.Drawing.Point(13, 44);
            this.baseTxtBoxLbl.Name = "baseTxtBoxLbl";
            this.baseTxtBoxLbl.Size = new System.Drawing.Size(118, 18);
            this.baseTxtBoxLbl.TabIndex = 3;
            this.baseTxtBoxLbl.Text = "Base Number";
            // 
            // binaryBtn
            // 
            this.binaryBtn.Enabled = false;
            this.binaryBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryBtn.Location = new System.Drawing.Point(16, 78);
            this.binaryBtn.Name = "binaryBtn";
            this.binaryBtn.Size = new System.Drawing.Size(169, 29);
            this.binaryBtn.TabIndex = 5;
            this.binaryBtn.Text = "Binary";
            this.binaryBtn.UseVisualStyleBackColor = true;
            this.binaryBtn.Click += new System.EventHandler(this.binaryBtn_Click);
            // 
            // hexBtn
            // 
            this.hexBtn.Enabled = false;
            this.hexBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexBtn.Location = new System.Drawing.Point(16, 113);
            this.hexBtn.Name = "hexBtn";
            this.hexBtn.Size = new System.Drawing.Size(169, 29);
            this.hexBtn.TabIndex = 6;
            this.hexBtn.Text = "Hex";
            this.hexBtn.UseVisualStyleBackColor = true;
            this.hexBtn.Click += new System.EventHandler(this.hexBtn_Click);
            // 
            // octalBtn
            // 
            this.octalBtn.Enabled = false;
            this.octalBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.octalBtn.Location = new System.Drawing.Point(16, 148);
            this.octalBtn.Name = "octalBtn";
            this.octalBtn.Size = new System.Drawing.Size(169, 29);
            this.octalBtn.TabIndex = 7;
            this.octalBtn.Text = "Octal";
            this.octalBtn.UseVisualStyleBackColor = true;
            this.octalBtn.Click += new System.EventHandler(this.octalBtn_Click);
            // 
            // base6Btn
            // 
            this.base6Btn.Enabled = false;
            this.base6Btn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.base6Btn.Location = new System.Drawing.Point(16, 183);
            this.base6Btn.Name = "base6Btn";
            this.base6Btn.Size = new System.Drawing.Size(169, 29);
            this.base6Btn.TabIndex = 8;
            this.base6Btn.Text = "Base6";
            this.base6Btn.UseVisualStyleBackColor = true;
            this.base6Btn.Click += new System.EventHandler(this.base6Btn_Click);
            // 
            // base9Btn
            // 
            this.base9Btn.Enabled = false;
            this.base9Btn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.base9Btn.Location = new System.Drawing.Point(16, 218);
            this.base9Btn.Name = "base9Btn";
            this.base9Btn.Size = new System.Drawing.Size(169, 29);
            this.base9Btn.TabIndex = 9;
            this.base9Btn.Text = "Base 9";
            this.base9Btn.UseVisualStyleBackColor = true;
            this.base9Btn.Click += new System.EventHandler(this.base9Btn_Click);
            // 
            // processBtn
            // 
            this.processBtn.Enabled = false;
            this.processBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processBtn.Location = new System.Drawing.Point(191, 78);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(100, 64);
            this.processBtn.TabIndex = 4;
            this.processBtn.Text = "Process";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // extBtn
            // 
            this.extBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.extBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extBtn.Location = new System.Drawing.Point(191, 148);
            this.extBtn.Name = "extBtn";
            this.extBtn.Size = new System.Drawing.Size(100, 29);
            this.extBtn.TabIndex = 7;
            this.extBtn.Text = "Exit";
            this.extBtn.UseVisualStyleBackColor = true;
            this.extBtn.Click += new System.EventHandler(this.extBtn_Click);
            // 
            // ClrBtn
            // 
            this.ClrBtn.Enabled = false;
            this.ClrBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClrBtn.Location = new System.Drawing.Point(191, 183);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(100, 64);
            this.ClrBtn.TabIndex = 4;
            this.ClrBtn.Text = "Clear";
            this.ClrBtn.UseVisualStyleBackColor = true;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // msgLbl
            // 
            this.msgLbl.BackColor = System.Drawing.Color.LightBlue;
            this.msgLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLbl.Location = new System.Drawing.Point(12, 250);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(279, 191);
            this.msgLbl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.extBtn;
            this.ClientSize = new System.Drawing.Size(303, 450);
            this.Controls.Add(this.base9Btn);
            this.Controls.Add(this.base6Btn);
            this.Controls.Add(this.extBtn);
            this.Controls.Add(this.octalBtn);
            this.Controls.Add(this.hexBtn);
            this.Controls.Add(this.binaryBtn);
            this.Controls.Add(this.ClrBtn);
            this.Controls.Add(this.processBtn);
            this.Controls.Add(this.baseTxtBoxLbl);
            this.Controls.Add(this.conTxtBoxLbl);
            this.Controls.Add(this.msgLbl);
            this.Controls.Add(this.baseTxtBox);
            this.Controls.Add(this.conTxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox conTxtBox;
        private System.Windows.Forms.TextBox baseTxtBox;
        private System.Windows.Forms.Label conTxtBoxLbl;
        private System.Windows.Forms.Label baseTxtBoxLbl;
        private System.Windows.Forms.Button binaryBtn;
        private System.Windows.Forms.Button hexBtn;
        private System.Windows.Forms.Button octalBtn;
        private System.Windows.Forms.Button base6Btn;
        private System.Windows.Forms.Button base9Btn;
        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.Button extBtn;
        private System.Windows.Forms.Button ClrBtn;
        private System.Windows.Forms.Label msgLbl;
    }
}

