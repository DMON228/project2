using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKR
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Sql.Connection.Open();

            string SqlStr = "select * from users";
            MySqlCommand command = new MySqlCommand(SqlStr, Sql.Connection);




            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }
            reader.Close();

            dataGridView1.Columns.Add("Column1", "User_ID");
            dataGridView1.Columns.Add("Column2", "Login");
            dataGridView1.Columns.Add("Column3", "Password");
            dataGridView1.Columns.Add("Column4", "Role");
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);


            Sql.Connection.Close();

        }
    }
}
