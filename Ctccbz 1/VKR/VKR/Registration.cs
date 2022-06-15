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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        MySqlCommand cmd;
        Authotization authotization = new Authotization();

        string SqlStr;


        private void RegBtn_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text != "" && PasswordBox.Text != "")
            {
                if (PasswordBox.Text == PasswordChange.Text)
                {
                    Sql.Connection.Open();
                    SqlStr = $"insert into users( Login, Password, Role) values" +
                        $"('{LoginBox.Text}','{PasswordBox.Text}', 'User')";
                    cmd = new MySqlCommand(SqlStr, Sql.Connection);
                    cmd.ExecuteNonQuery();
                    authotization.Show();
                    this.Hide();
                    Sql.Connection.Close();
                }
                else
                {
                    MessageBox.Show("Пароль неверный!");
                }
            }
            else
            {
                MessageBox.Show("Заполните поля!");
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            authotization.Show();
            this.Hide();

        }
    }
}
