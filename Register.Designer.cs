namespace PortfolioManagement
{
    partial class Register
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.cPwd = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.alertMsg = new System.Windows.Forms.Label();
            this.pwdStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(213, 50);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(172, 20);
            this.email.TabIndex = 3;
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(213, 87);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(172, 20);
            this.pwd.TabIndex = 4;
            // 
            // cPwd
            // 
            this.cPwd.Location = new System.Drawing.Point(213, 124);
            this.cPwd.Name = "cPwd";
            this.cPwd.Size = new System.Drawing.Size(172, 20);
            this.cPwd.TabIndex = 5;
            this.cPwd.TextChanged += new System.EventHandler(this.cPwd_TextChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(171, 210);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(98, 35);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Register";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // alertMsg
            // 
            this.alertMsg.AutoSize = true;
            this.alertMsg.Location = new System.Drawing.Point(201, 166);
            this.alertMsg.Name = "alertMsg";
            this.alertMsg.Size = new System.Drawing.Size(0, 13);
            this.alertMsg.TabIndex = 7;
            this.alertMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pwdStatus
            // 
            this.pwdStatus.AutoSize = true;
            this.pwdStatus.Location = new System.Drawing.Point(428, 130);
            this.pwdStatus.Name = "pwdStatus";
            this.pwdStatus.Size = new System.Drawing.Size(0, 13);
            this.pwdStatus.TabIndex = 8;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 297);
            this.Controls.Add(this.pwdStatus);
            this.Controls.Add(this.alertMsg);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.cPwd);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.TextBox cPwd;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label alertMsg;
        private System.Windows.Forms.Label pwdStatus;
    }
}