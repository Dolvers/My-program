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
        MySqlConnection connection = new MySqlConnection("server=db4free.net;port=3306;username=dolvers;password=A1234554321s.;database=dolvers");

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
                return connection.State == ConnectionState.Open;
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
