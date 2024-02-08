using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace GestSchool
{
    class DatabaseUtility
    {
        private static string server = "localhost";
        private static string db = "project_c#";
        private static string user = "habitudeX";
        private static string pwd = "qwerty12345";
        private static string port = "3306";
        private static MySqlConnection connection;
        private static string connectionString = $"SERVER={server};DATABASE={db};UID={user};PASSWORD={pwd};PORT={port}";


        public static MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            else if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            return connection;
        }

        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public static void ExecuterRequete(string query)
        {
            using (MySqlCommand command = new MySqlCommand(query, GetConnection()))
            {
                command.ExecuteNonQuery();
            }
        }

        public static MySqlDataReader ExecuterRequeteAvecLecteur(string query)
        {
            MySqlCommand command = new MySqlCommand(query, GetConnection());
            return command.ExecuteReader();
        }

        public static DataTable RemplirDataGridView(string query)
        {
            DataTable dt = new DataTable();

            using (MySqlDataAdapter mdt = new MySqlDataAdapter(query, GetConnection()))
            {
                mdt.Fill(dt);
            }

            return dt;
        }
        public static void CloseConnection(MySqlConnection mconnect)
        {
            if (mconnect.State == System.Data.ConnectionState.Open)
                mconnect.Close();
        }

    }
}
