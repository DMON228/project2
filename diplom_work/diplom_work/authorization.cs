using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace diplom_work
{
    public partial class authorization : Form
    {
        public authorization()
        {
            InitializeComponent();
        }

        static string conn = "server = localhost; user = root; password = root; database = sports_equipment";
        //static string conn = "server = localhost; user = root; password = root; database = sports_equipment";
        static string requst = "";
        static MySqlConnection Connection = new MySqlConnection(conn);
        static MySqlCommand Command = new MySqlCommand(requst, Connection);

        private void enter_btn_Click(object sender, EventArgs e)
        {
            if (login_txt.Text != "" & password_txt.Text != "")
            {
                Connection.Open();
                requst = $"SELECT * FROM users WHERE user_login = '{login_txt.Text}' and user_password = '{password_txt.Text}' ";
                Command = new MySqlCommand(requst, Connection);
                int find = (int)Command.ExecuteScalar();
                Connection.Close();

                if (find > 0)
                {
                    MessageBox.Show("Вы успешно вошли!");
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Не получилось!");

            }            
        }

        private void registration_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            registration registration = new registration();
            registration.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
