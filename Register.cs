using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                if ( ( mail.Length == 0 || password.Length == 0 ) && password.Length < 6 ) setMsg("Error: All fields are required", Color.Red);
                else
                {
                    var connection = new DataClasses1DataContext();
                    var checkForMail = connection.Users.Where(u => u.email.Equals(mail)).Count();
                    if( checkForMail == 0 )
                    {
                        User newUser = new User()
                        {
                            email = mail,
                            password = password
                        };
                        MessageBox.Show(newUser.ToString());
                        connection.Users.InsertOnSubmit(newUser);
                        try
                        {
                            connection.SubmitChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        connection.Dispose();
                        setMsg("Info: New User Entered", Color.Green);
                        this.Hide();
                        (new LandingPage()).Show();
                    }
                    else
                    {
                        setMsg("Error: User already exists", Color.Red);
                    }
                    //MessageBox.Show(checkForMail.ToString());
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
    }
}
