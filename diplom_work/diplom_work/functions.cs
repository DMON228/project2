using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace diplom_work
{
    

    class functions
    {
        static string conn = "server = localhost; user = admin; password = 123456; database = sports_equipment";
        public static string requst = "";
        static MySqlConnection Connection = new MySqlConnection(conn);
        static MySqlCommand Command = new MySqlCommand();

        public static string select_with_conditions_functions(string columns, string tabel, string condition)
        {
            Connection.Open();
            string request = $"SELECT {columns} FROM {tabel} WHERE {condition}";
            Command = new MySqlCommand(request, Connection);
            string answer = Command.ExecuteScalar().ToString();
            Connection.Close();
            return answer;
        }

        public static void update_function(string tabel, string column, string change, string condition)
        {
            Connection.Open();
            string request = $"UPDATE {tabel} SET {column} = {change} WHERE {condition}";
            Command = new MySqlCommand(request, Connection);
            Command.ExecuteNonQuery();
            Connection.Close();
        }

    }
}
