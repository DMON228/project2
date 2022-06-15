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
    public partial class EmployerForm : Form
    {
        public EmployerForm()
        {
            InitializeComponent();
        }
        MySqlCommand Cmd;
        string SqlStr;


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 ) //цифры, клавиша BackSpace в ASCII
            {
                e.Handled = true;
            }
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            Sql.Connection.Open();
            SqlStr = $"insert into vkr.cargo_tracking( location, Cargo_ID, Arrival_Date) values" +
                $"('{LoginBox.Text.ToString()}','{Convert.ToInt32(textBox1.Text)}', '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}')";
            Cmd = new MySqlCommand(SqlStr, Sql.Connection);
            Cmd.ExecuteNonQuery();
            Sql.Connection.Close();
            MessageBox.Show("Добавлено!");
        }
    }
}
