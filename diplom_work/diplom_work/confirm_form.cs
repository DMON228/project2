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
    public partial class confirm_form : Form
    {
        static string conn = "server = localhost; user = admin; password = 123456; database = sports_equipment";
        static MySqlConnection Connection = new MySqlConnection(conn);
        static MySqlCommand Command = new MySqlCommand();
        MySqlDataAdapter Adapter = new MySqlDataAdapter(Command);

        string request;
        int id_rental_global;

        public confirm_form(string fio, string product_name, int renta_id)
        {
            InitializeComponent();

            fio_lbl.Text = fio;
            product_lbl.Text = product_name;
            id_rental_global = renta_id;
        }

        private void no_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yes_btn_Click(object sender, EventArgs e)
        {
            functions.update_function("rental", "rt_active", "0", $"rt_id = {id_rental_global}");
         
            string pr_id = functions.select_with_conditions_functions("pr_id", "product", $"pr_name = {product_lbl.Text}").ToString();

            functions.update_function("product", "pr_quantity_current", "pr_quantity_current + 1", $"pr_id = {pr_id}");
        }
    }
}
