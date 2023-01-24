using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CoffeShop
{
    public class Mydb : DbContext 
    {
        public Mydb()
            : base("name=Mydb1")
        {
        }

        private MySqlConnection connection = new MySqlConnection(
               "server=localhost;port=3306;username=root;password=;database=coffee_shop");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public DataTable getData(string query, MySqlParameter[] parameters)
        {

            MySqlCommand command = new MySqlCommand(query, getConnection());

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public int setData(string query, MySqlParameter[] parameters)
        {

            MySqlCommand command = new MySqlCommand(query, getConnection());

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            openConnection();

            int commandState = command.ExecuteNonQuery();

            closeConnection();

            return commandState;
        }

        public string AmbilData(string query, string colom, MySqlParameter[] parameters)
        {
            MySqlCommand command = new MySqlCommand(query, getConnection());

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            openConnection();

            string dataTemp = "No Data";
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                dataTemp = reader[colom].ToString();
            }
            closeConnection();

            return dataTemp;
        }
    }
}
