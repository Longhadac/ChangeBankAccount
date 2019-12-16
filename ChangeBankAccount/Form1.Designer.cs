namespace ChangeBankAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbInstitutionNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTransitNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCurrentNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(130, 35);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(246, 22);
            this.tbUserName.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(130, 80);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(246, 22);
            this.tbPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // tbAccountName
            // 
            this.tbAccountName.Location = new System.Drawing.Point(611, 35);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Size = new System.Drawing.Size(246, 22);
            this.tbAccountName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Account Name";
            // 
            // tbInstitutionNumber
            // 
            this.tbInstitutionNumber.Location = new System.Drawing.Point(611, 80);
            this.tbInstitutionNumber.Name = "tbInstitutionNumber";
            this.tbInstitutionNumber.Size = new System.Drawing.Size(246, 22);
            this.tbInstitutionNumber.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Institution Number";
            // 
            // tbTransitNumber
            // 
            this.tbTransitNumber.Location = new System.Drawing.Point(611, 126);
            this.tbTransitNumber.Name = "tbTransitNumber";
            this.tbTransitNumber.Size = new System.Drawing.Size(246, 22);
            this.tbTransitNumber.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Transit Number";
            // 
            // tbCurrentNumber
            // 
            this.tbCurrentNumber.Enabled = false;
            this.tbCurrentNumber.Location = new System.Drawing.Point(130, 126);
            this.tbCurrentNumber.Name = "tbCurrentNumber";
            this.tbCurrentNumber.Size = new System.Drawing.Size(246, 22);
            this.tbCurrentNumber.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Current";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(910, 38);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(146, 108);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 690);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbCurrentNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTransitNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbInstitutionNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAccountName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAccountName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbInstitutionNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTransitNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCurrentNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStart;
    }
}

