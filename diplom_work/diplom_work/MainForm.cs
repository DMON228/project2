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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        static string conn = "server = localhost; user = admin; password = 123456; database = sports_equipment";
        static MySqlConnection Connection = new MySqlConnection(conn);
        static MySqlCommand Command = new MySqlCommand();
        MySqlDataAdapter Adapter = new MySqlDataAdapter(Command);



        void output_data(string req)
        {
            DataTable DT = new DataTable();
            DT.Clear();
            Connection.Open();
            string reqest = req;
            Command = new MySqlCommand(reqest, Connection);
            Adapter = new MySqlDataAdapter(Command);
            Adapter.Fill(DT);
            dataGridView1.DataSource = DT;
            Connection.Close();

        }

        void color_defolt()
        {
            rental_lbl.ForeColor = Color.Black;
            client_lbl.ForeColor = Color.Black;
            history_lbl.ForeColor = Color.Black;
            product_lbl.ForeColor = Color.Black;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void rental_lbl_Click(object sender, EventArgs e)
        {
            color_defolt();
            rental_lbl.ForeColor = Color.White;
            output_data("SELECT rt_id as '№', cl_first_name as 'Имя', cl_second_name as 'Фамилия', cl_otchestvo as 'Отчество', " +
                "pr_name as 'Товар', rt_date_start as 'Начало', rt_date_end as 'Конец' FROM rental " +
                "INNER JOIN client ON rt_client = cl_id " +
                "INNER JOIN product ON rt_product = pr_id " +
                "WHERE rt_active = 1 ");
        }

        private void product_lbl_Click(object sender, EventArgs e)
        {
            color_defolt();
            product_lbl.ForeColor = Color.White;
            output_data("SELECT pr_id as '№', pr_name as 'Название', pr_cost as 'Стоимость(час)', " +

               "pr_quantity_all as 'Общее количество', pr_quantity_current as 'Количество на складе', pr_model as 'Модель' FROM sports_equipment.product");
            
        }

        private void client_lbl_Click(object sender, EventArgs e)
        {
            color_defolt();
            client_lbl.ForeColor = Color.White;
            output_data("SELECT cl_id as '№', cl_first_name as 'Имя', cl_second_name as 'Фамилия', " +
               "cl_otchestvo as 'Отчество', cl_gender as 'Пол' FROM sports_equipment.client");
        }

        private void history_lbl_Click(object sender, EventArgs e)
        {
            color_defolt();
            history_lbl.ForeColor = Color.White;
            output_data("SELECT rt_id as '№', cl_first_name as 'Имя', cl_second_name as 'Фамилия', cl_otchestvo as 'Отчество', " +
                "pr_name as 'Товар', rt_date_start as 'Начало', rt_date_end as 'Конец' FROM rental " +
                "INNER JOIN client ON rt_client = cl_id " +
                "INNER JOIN product ON rt_product = pr_id " +
                "WHERE rt_active = 0 ");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (client_lbl.ForeColor == Color.White)
            {
                int index = (int)dataGridView1.CurrentRow.Cells[0].Value;
                int client_id = (int)dataGridView1.Rows[index-1].Cells[0].Value;
                string name = dataGridView1.Rows[index - 1].Cells[1].Value.ToString();
                string familiy = dataGridView1.Rows[index - 1].Cells[2].Value.ToString();
                string otchestvo = dataGridView1.Rows[index - 1].Cells[3].Value.ToString();
                string fio = $"{name} {familiy} {otchestvo}";

                form_sales form_Sales = new form_sales(client_id, fio);
                form_Sales.ShowDialog();
            }
            if(rental_lbl.ForeColor == Color.White)
            {
                int index = (int)dataGridView1.CurrentRow.Cells[0].Value;
                int rental_id = (int)dataGridView1.Rows[index - 1].Cells[1].Value;
                string name = dataGridView1.Rows[index - 1].Cells[1].Value.ToString();
                string familiy = dataGridView1.Rows[index - 1].Cells[2].Value.ToString();
                string otchestvo = dataGridView1.Rows[index - 1].Cells[3].Value.ToString();
                string product_name = dataGridView1.Rows[index - 1].Cells[4].Value.ToString();
                string fio = $"{name} {familiy} {otchestvo}";

                confirm_form confirm_Form = new confirm_form(fio, product_name, rental_id);
                confirm_Form.ShowDialog();
            }
        }
    }
}
