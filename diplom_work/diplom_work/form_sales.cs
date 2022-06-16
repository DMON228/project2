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
    public partial class form_sales : Form
    {

        static string conn = "server = localhost; user = admin; password = 123456; database = sports_equipment";
        string request;
        static MySqlConnection Connection = new MySqlConnection(conn);
        static MySqlCommand Command = new MySqlCommand();
        static MySqlDataAdapter Adapter = new MySqlDataAdapter(Command);

        static int id_client_global;
        static int id_product_global;

        public form_sales(int client_id, string fio)
        {
            InitializeComponent();
            fio_lbl.Text = fio;
            id_client_global = client_id;


            Connection.Open();
            request = "SELECT pr_id, pr_name FROM sports_equipment.product;";
            Command = new MySqlCommand(request, Connection);
            DataTable dataTable = new DataTable();
            Adapter = new MySqlDataAdapter(Command);
            Adapter.Fill(dataTable);
            Connection.Close();

            product_name_CB.DataSource = dataTable;

            product_name_CB.DisplayMember = "pr_name";
            product_name_CB.ValueMember = "pr_id";
        }

        void forming_cost()
        {
            id_product_global = Convert.ToInt32(product_name_CB.SelectedValue);
            Connection.Open();
            request = $"SELECT pr_cost FROM product WHERE pr_id = {id_product_global}";
            Command = new MySqlCommand(request, Connection);
            int cost = Convert.ToInt32(Command.ExecuteScalar());
            Connection.Close();
            cost_lbl.Text = $"{cost * hour_nud.Value}.00 р";
        }

        private void exit_lbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void product_name_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(product_name_CB.SelectedIndex == 0)
            {
                product_name_CB.SelectedIndex = 0;
            }
            forming_cost();
        }

        private void hour_nud_ValueChanged(object sender, EventArgs e)
        {
            forming_cost();
        }

        private void buy_btn_Click(object sender, EventArgs e)
        {
            if(hour_nud.Value > 0)
            {
                Connection.Open();
                request = $"SELECT pr_quantity_current FROM product WHERE pr_id = {id_product_global}";
                Command = new MySqlCommand(request, Connection);
                int quantity = (int)Command.ExecuteScalar();
                Connection.Close();

                if (quantity > 0)
                {
                    Connection.Open();
                    request = $"INSERT INTO rental(rt_client, rt_product, rt_date_start, rt_date_end, rt_active) " +
                        $"VALUES ({id_client_global}, {id_product_global}, '{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss").Replace('.', '-')}', " +
                        $"'{DateTime.Now.AddHours((double)hour_nud.Value).ToString("yyyy/MM/dd HH:mm:ss").Replace('.','-')}', '1')";
                    Command = new MySqlCommand(request, Connection);
                    Command.ExecuteNonQuery();
                    Connection.Close();

                    Connection.Open();
                    request = $"UPDATE product SET pr_quantity_current = pr_quantity_current - 1 WHERE pr_id = {id_product_global}";
                    Command = new MySqlCommand(request, Connection);
                    Command.ExecuteNonQuery();
                    Connection.Close();

                    MessageBox.Show("Усешно!");
                    this.Close();


                }
                else
                    MessageBox.Show("В наличии нет выбранного инвентаря!");

            }
            else
                MessageBox.Show("Укажите время проката!");



        }
    }
}
