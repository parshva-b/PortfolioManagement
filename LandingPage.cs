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
        }

        private void login_Click(object sender, EventArgs e)
        {
            string mail = email.Text, password = pwd.Text;
            if (mail.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Error while filling values", "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Login Kara
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            Form form = new Register();
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }
    }
}
