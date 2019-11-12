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
    public partial class Sell : Form
    {
        static int user_id;
        static int t_id;
        public Sell(int user_id1, int t_id1)
        {
            InitializeComponent();
            user_id = user_id1;
            t_id = t_id1;
        }

        private void Sell_Load(object sender, EventArgs e)
        {
            symbolName.Text = database.getStockSymbol(t_id);
            quantity.Text = database.getpurchaseCount(t_id);
            numericUpDown1.Maximum = Convert.ToInt32(quantity.Text);
            groupBox1.Hide();    
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            quant.Text = numericUpDown1.Value.ToString();
            sp.Text = Convert.ToString(Convert.ToInt32(quant.Text) * Convert.ToDouble(currentPrice.Text));
            cp.Text = Convert.ToString(Convert.ToInt32(quant.Text) * Convert.ToDouble(purchasePrice.Text));
            double profit = Convert.ToDouble(sp.Text) - Convert.ToDouble(cp.Text);
            if (profit > 0)
            {
                benefit.Text = "+" + Convert.ToString(profit);
            }
            else
            {
                benefit.Text = Convert.ToString(profit);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            currentPrice.Text = api.getValue(symbolName.Text);
            purchasePrice.Text = database.getpurchasePrice(t_id);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double balance = Convert.ToDouble(database.getBalance(user_id));
            int rowsaffected = database.updateUser(user_id,balance+Convert.ToDouble(sp.Text));
            int x = database.updateTransaction(t_id, Convert.ToInt32(quantity.Text) - Convert.ToInt32(quant.Text));
            MessageBox.Show("The transaction was successful!!!");
            this.Hide();
            (new Stockwindow(user_id)).Show();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Stockwindow(user_id)).Show();
        }
    }
}
