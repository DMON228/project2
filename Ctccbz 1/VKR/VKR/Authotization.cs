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

namespace VKR
{
    public partial class Authotization : Form
    {
        public Authotization()
        {
            InitializeComponent();
        }
        string SqlStr;
        string role;

        private void EnterBtn_Click(object sender, EventArgs e)
        {

            Sql.Connection.Open();
            SqlStr = $"select * from vkr.users where Login='{LoginBox.Text}' and Password='{PasswordBox.Text}'";
            MySqlCommand cmd = new MySqlCommand(SqlStr, Sql.Connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                role = reader[3].ToString();
                Program.CargoID = Convert.ToInt32(reader[0]);
            }

            reader.Close();
            Sql.Connection.Close();
            if (role == "Admin")
            {
                MessageBox.Show($"Вход выполнен успешно", "Success");
                Admin admin = new Admin();
                admin.Show();

            }
            if (role == "User")
            {
                MessageBox.Show($"Вход выполнен успешно", "Success");
                Main newForm = new Main();
                newForm.Show();
            }
            if (role == "Courier")
            {
                MessageBox.Show($"Вход выполнен успешно", "Success");
                EmployerForm newForm = new EmployerForm();
                newForm.Show();
            }
            this.Hide();

            if (role == null)
            {
                MessageBox.Show("Пользователь не найден!");
                this.Show();
            }



            Sql.Connection.Close();
        }


        private void Registration_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }
    }
}
