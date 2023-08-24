using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JIRAMA
{
    internal class DataBase
    {
        MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database:jirama; password=");
            

        // Function to open connection

        public void openConnection()
        {
            if (mySqlConnection.State == System.Data.ConnectionState.Closed)
            {
                mySqlConnection.Open();
                MessageBox.Show("Connection success");
            }
        }

        // Function to close connection
        public void closeConnection()
        {
            if (mySqlConnection.State == System.Data.ConnectionState.Open)
            {
                mySqlConnection.Close();
                MessageBox.Show("Connection closed");
            }
        }

        //Function returning the connection
        public MySqlConnection GetConnection()
        {
            return mySqlConnection;
        }
    }
}
