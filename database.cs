using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioManagement
{
    class database
    {
        public static MySqlConnection Connection()
        {
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=portfolio;sslmode=none";
            return (new MySqlConnection(connection));
        }

        public static string getPwd(string email)
        {
            MySqlConnection connection = Connection();
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "SELECT `password` from `user` where email = @mail";
            query.Parameters.AddWithValue("@mail", email);
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
            if (dataReader.Read()) return dataReader.GetString(0);
            return null;
        }

        public static string getBalance(int user_id)
        {
            MySqlConnection connection = Connection();
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "SELECT `money` from `user` where id = @id";
            query.Parameters.AddWithValue("@id", user_id);
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
            if (dataReader.Read()) return dataReader.GetString(0);
            return null;
        }

        public static int getUid(string email)
        {
            MySqlConnection connection = Connection();
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "SELECT `id` from `user` where email = @mail";
            query.Parameters.AddWithValue("@mail", email);
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
            if (dataReader.Read()) return int.Parse(dataReader.GetString(0));
            return -1;
        }

        public static bool checkEmailExists(string email)
        {
            MySqlConnection connection = Connection();
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "SELECT * from `user` where email = @mail";
            query.Parameters.AddWithValue("@mail", email);
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
            if (dataReader.Read()) return true;
            return false;
        }

        public static int addUser(string email, string password)
        {
            MySqlConnection connection = Connection();
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "INSERT INTO `user` (`email`, `password`) VALUES (@mail, @password)";
            query.Parameters.AddWithValue("@mail", email);
            query.Parameters.AddWithValue("@password", password);
            int rowsAffected = 0;
            try
            {
                connection.Open();
                rowsAffected = query.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: " + e.Message);
            }
            return rowsAffected;
        }

        public static int addTransaction(int id, string symbol, int count, double purchasePrice)
        {
            MySqlConnection connection = Connection();
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "INSERT INTO `stocks`(`user_id`, `stock_symbol`, `count`, `purchasePrice`) VALUES (@id,@symbol,@count,@purchasePrice)";
            query.Parameters.AddWithValue("@id", id);
            query.Parameters.AddWithValue("@symbol", symbol);
            query.Parameters.AddWithValue("@count", count);
            query.Parameters.AddWithValue("@purchasePrice", purchasePrice);
            int rowsAffected = 0;
            try
            {
                connection.Open();
                rowsAffected = query.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: " + e.Message);
            }
            return rowsAffected;
        }
        public static int updateUser(int id, double money)
        {
            MySqlConnection connection = Connection();
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "UPDATE `user` SET `money`= @money WHERE `id`=@id";
            query.Parameters.AddWithValue("@id", id);
            query.Parameters.AddWithValue("@money", money);
            int rowsAffected = 0;
            try
            {
                connection.Open();
                rowsAffected = query.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: " + e.Message);
            }
            return rowsAffected;
        }
    }
}
