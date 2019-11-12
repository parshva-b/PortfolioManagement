using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfolioManagement
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            pwd.UseSystemPasswordChar = true;
            cPwd.UseSystemPasswordChar = true;
            pwd.MaxLength = 14;
            cPwd.MaxLength = 14;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string mail = email.Text, password = pwd.Text, conPassword = cPwd.Text;
            if (!password.Equals(conPassword)) setMsg("Error: Passwords do no match", Color.Red);
            else
            {
                if ((mail.Length == 0 || password.Length == 0) && password.Length < 6) setMsg("Error: All fields are required", Color.Red);
                else
                {
                    if (!isValidEmail(mail)) setMsg("Email not in proper format", Color.Red);
                    else
                    {
                        bool checkForMail = database.checkEmailExists(mail);
                        if (!checkForMail)
                        {
                            int change = database.addUser(mail, password);
                            if (change == 0) setMsg("Server internal Error: Try again", Color.Red);
                            else
                            {
                                setMsg("Info: New User Entered", Color.Green);
                                this.Hide();
                                (new LandingPage()).Show();
                            }
                        }
                        else setMsg("Error: User already exists", Color.Red);
                        //MessageBox.Show(checkForMail.ToString());
                    }
                }
            }
        }

        private void setMsg(string msg, Color color)
        {
            alertMsg.Text = msg;
            alertMsg.ForeColor = color;
            alertMsg.BorderStyle = BorderStyle.FixedSingle;
        }

        private void cPwd_TextChanged(object sender, EventArgs e)
        {
            string password = pwd.Text, conPassword = cPwd.Text;
            if( password.Equals(conPassword) )
            {
                pwdStatus.Text = "Passwords match";
                pwdStatus.ForeColor = Color.Green;
            }
            else
            {
                pwdStatus.Text = "Passwords do not match";
                pwdStatus.ForeColor = Color.Red;
            }
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

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new LandingPage()).Show();
        }
    }
}
