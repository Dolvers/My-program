using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_program
{
    internal class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=itproger");

        public void openConnection()
        {
            if(connection.State != System.Data.ConnectionState.Open)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
        public Boolean CheckConnection()
        {
            try
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

    }
}
