using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PortfolioManagement
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
            pwd.UseSystemPasswordChar = true;
            pwd.MaxLength = 14;
            
        }

        private void login_Click(object sender, EventArgs e)
        {
            string mail = email.Text, password = pwd.Text;
            if (mail.Length == 0 || password.Length == 0)
            {
                //MessageBox.Show("Error while filling values", "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                setMsg("Error: All values are required", Color.Red);
            }
            else
            {
                if(password.Length < 6)
                {
                    //MessageBox.Show("Error: Minimum Password length is 6 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    setMsg("Error: Minimum Password Length is 6 characters", Color.Red);
                }
                else
                {
                    string pwd = database.getPwd(mail);
                    if( string.IsNullOrEmpty(pwd) ) setMsg("Error: User does not exist", Color.Red);
                    else
                    {
                        if (pwd.Length > 0 && pwd.Equals(password))
                        {
                            setMsg("Info: Login Successful", Color.Green);
                            // get userId
                            int uid = database.getUid(mail);
                            
                            this.Hide();
                            (new Stockwindow(uid)).Show();
                        }
                        else setMsg("Error: User Credentials do not match", Color.Red);
                    }
                }
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            Form form = new Register();
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }

        private void showHide_CheckedChanged(object sender, EventArgs e)
        {
            if( showHide.Checked)
            {
                pwd.UseSystemPasswordChar = false;
                showHide.Text = "Hide";
            }
            else
            {
                pwd.UseSystemPasswordChar = true;
                showHide.Text = "See";
            }
        }

        public static string getRandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void setMsg(string msg, Color color)
        {
            alertMsg.Text = msg;
            alertMsg.ForeColor = color;
            alertMsg.BorderStyle = BorderStyle.FixedSingle;
        }

        private bool isValidEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException) { return false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mail = email.Text;

            if (mail.Length == 0) setMsg("Please fill mail field", Color.Red);
            else
            {
                if (!isValidEmail(mail)) setMsg("Mail should be in proper format", Color.Red);
                else
                {
                    string tempCode = getRandomString(8);
                    Email.sendmail(mail, tempCode);
                    object window = Interaction.InputBox("Enter value of received text on mail", "Verify User");
                    if ((string)window == "") {}
                    else
                    {
                        if (tempCode.Equals(window.ToString()))
                        {
                            pwd.Text = database.getPwd(mail);
                        }
                        else setMsg("Authentication Fail", Color.Red);
                    }
                }
            }
        }
    }
}
