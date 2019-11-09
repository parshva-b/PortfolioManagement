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
                    var connection = new DataClasses1DataContext();
                    var results = connection.Users.Where(u => u.email == mail).Select(u => u.password).ToList();
                    bool loginState = false;
                    try
                    {
                        loginState = password.Equals(results.ElementAt<string>(0));
                    }
                    catch (Exception exp)
                    {
                        //MessageBox.Show("Error: User Does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        setMsg("Error: User does not exist", Color.Red);
                    }
                    if (loginState)
                    {
                        //MessageBox.Show("Info: Login Successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setMsg("Info: Login Successful", Color.Green);
                        var list = connection.Users.Where(u => u.email == mail).Select(u => u.id).ToList();
                        // access list.ElementAt<int>(0) and pass to stocks
                        //Show next window
                    }
                    else
                    {
                        //MessageBox.Show("Error: User Credentials do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        setMsg("Error: User Credentials do not match", Color.Red);
                    }
                    connection.Dispose();
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

        private void setMsg(string msg, Color color)
        {
            alertMsg.Text = msg;
            alertMsg.ForeColor = color;
            alertMsg.BorderStyle = BorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = api.getValue(textBox1.Text);
        }
    }
}
