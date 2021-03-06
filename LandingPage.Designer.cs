﻿namespace PortfolioManagement
{
    partial class LandingPage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showHide = new System.Windows.Forms.CheckBox();
            this.login = new System.Windows.Forms.Button();
            this.pwd = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.alertMsg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showHide);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.pwd);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(217, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Credentials:";
            // 
            // showHide
            // 
            this.showHide.AutoSize = true;
            this.showHide.Location = new System.Drawing.Point(304, 95);
            this.showHide.Name = "showHide";
            this.showHide.Size = new System.Drawing.Size(45, 17);
            this.showHide.TabIndex = 5;
            this.showHide.Text = "See";
            this.showHide.UseVisualStyleBackColor = true;
            this.showHide.CheckedChanged += new System.EventHandler(this.showHide_CheckedChanged);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.LightSeaGreen;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Location = new System.Drawing.Point(151, 139);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(141, 92);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(157, 20);
            this.pwd.TabIndex = 3;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(141, 51);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(157, 20);
            this.email.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.LightSeaGreen;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Location = new System.Drawing.Point(238, 362);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 23);
            this.register.TabIndex = 1;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Click here to register as new user";
            // 
            // alertMsg
            // 
            this.alertMsg.AutoSize = true;
            this.alertMsg.Location = new System.Drawing.Point(401, 305);
            this.alertMsg.Name = "alertMsg";
            this.alertMsg.Size = new System.Drawing.Size(0, 13);
            this.alertMsg.TabIndex = 3;
            this.alertMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Ivory;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(321, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Login Here";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(492, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Forgot Password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.alertMsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.register);
            this.Controls.Add(this.groupBox1);
            this.Name = "LandingPage";
            this.Text = "Landing Page";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox showHide;
        private System.Windows.Forms.Label alertMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

