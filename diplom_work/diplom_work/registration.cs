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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        static string conn = "server = localhost; user = root; password = root; database = sports_equipment";
        static string requst = "";
        static MySqlConnection Connection = new MySqlConnection(conn);
        static MySqlCommand Command = new MySqlCommand(requst, Connection);

        private void enter_btn_Click(object sender, EventArgs e)
        {
            if (login_reg_txt.Text != "" && first_name_txt.Text != "" & second_name_txt.Text != "" & password_reg_check_txt.Text != "")
            {
                if (password_reg_txt.Text == password_reg_check_txt.Text)
                {
                    try
                    {
                        Connection.Open();
                        requst = $"INSERT INTO users(user_login, user_password, user_role, user_first_name, user_second_name) " +
                            $"VALUES('{login_reg_txt.Text}','{second_name_txt.Text}','1','{first_name_txt.Text}','{second_name_txt.Text}')";
                        Command = new MySqlCommand(requst, Connection);
                        Command.ExecuteNonQuery();
                        Connection.Close();

                        MessageBox.Show("Вы успешно зарегистрировались!");

                        this.Close();
                        authorization authorization = new authorization();
                        authorization.Show();
                    }
                    catch
                    {
                        MessageBox.Show("Непредвиденная ошибка!");
                    }

                }
                else
                {
                    MessageBox.Show("Введённые пароли не совпадают!");
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
            
        }

        private void registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            authorization authorization = new authorization();
            authorization.Show();
        }
    }
}
