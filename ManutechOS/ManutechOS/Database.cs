using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ManutechOS
{
    class Database
    {
        private static MySqlConnection connection;
        private static Database instance;
        private const string URL = "Server=127.0.0.1;Database=manutechDB;Uid=root;Pwd=tmc5hihk;";

        private Database()
        {
            connection = new MySqlConnection(URL);
        }

        public static Database GetInstance()
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void ExecuteNonSQL(string qry)
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            MySqlCommand comn = new MySqlCommand(qry, connection);
            comn.ExecuteNonQuery();

            connection.Close();
        }
    }
}
