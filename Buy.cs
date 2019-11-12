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
    public partial class Buy : Form
    {
        static int user_id;
        double balance;
        public Buy(int id)
        {
            InitializeComponent();
            user_id = id;
            getBalance();
        }

        public void getBalance()
        {
            balance = Convert.ToDouble(database.getBalance(user_id));
            currentBalance.Text = balance.ToString();
        }

        private void BuySell_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string response = api.getValue(textBox1.Text);
            if(response == "Not Found")
            {
                MessageBox.Show("Sorry, Such symbol doesn't exist!");
            }
            else
            {
                groupBox1.Show();
                currentPrice.Text = response;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            total.Text = Convert.ToString((Convert.ToDouble(currentPrice.Text)*(double)numericUpDown1.Value));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(total.Text) > Convert.ToDouble(currentBalance.Text))
            {
                MessageBox.Show("You don't have sufficient balance to buy these stocks!!!");
            }
            else
            {
                int rowsAffected = database.addTransaction(user_id,textBox1.Text,(int)numericUpDown1.Value,Convert.ToDouble(currentPrice.Text));
                int x = database.updateUser(user_id, balance - Convert.ToDouble(total.Text));
                getBalance();
                if (rowsAffected != 0 && x!=0)
                {
                    MessageBox.Show("Congratulations, the transaction was successful!!!");
                    this.Hide();
                    (new Stockwindow(user_id)).Show();
                }
            }
        }

        private void currentBalance_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Stockwindow(user_id)).Show();
        }
    }
}
