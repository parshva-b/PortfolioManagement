using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfolioManagement
{
    public partial class Stockwindow : Form
    {
        public int userId;
        public Stockwindow(int uid)
        {
            InitializeComponent();
            // label1.Text = "UserId: " + uid.ToString();
            userId = uid;
            MySqlDataReader dataReader = GetUserInfo(uid.ToString());
            //MessageBox.Show(x.ToString());
            l_email.Text = dataReader.GetString(1).ToString();
            l_uid.Text = dataReader.GetString(0).ToString();
            l_money.Text = dataReader.GetString(3).ToString();

            GetStockInfo(uid.ToString());
            //SELECT * FROM `stocks` WHERE user_id=6;
        }
        public void GetStockInfo(string id)
        {
            MySqlConnection connection = database.Connection();
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "SELECT * from `stocks` where user_id = @uid";
            query.Parameters.AddWithValue("@uid", id);
            MySqlDataReader dataReader = null;
            DataTable dtemp = new DataTable();
            try
            {
                connection.Open();
                dataReader = query.ExecuteReader(); //for the select query

                if (dataReader.HasRows)
                {
                    dtemp.Load(dataReader);				//load the data from query
                }
            }
            catch (Exception ee) { MessageBox.Show("error in show" + ee.Message); }

            dataGridView1.DataSource = dtemp;
        }

        private void Stockwindow_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public MySqlDataReader GetUserInfo(string id)
        {
            MySqlConnection connection = database.Connection();
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "SELECT * from `user` where id = @uid";
            query.Parameters.AddWithValue("@uid", id);
            MySqlDataReader dataReader = null;
            try
            {
                connection.Open();
                dataReader = query.ExecuteReader();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: " + e.Message);
            }
            if (dataReader.Read()) return dataReader;
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form buy = new Buy(userId);
            this.Close();
            buy.Show();
        }
    }
}
