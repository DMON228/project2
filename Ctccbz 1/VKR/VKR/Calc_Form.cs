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
    public partial class Calc_Form : Form
    {
       
        public Calc_Form()
        {  
            InitializeComponent();
        }

        string SqlStr;
        MySqlCommand Cmd;
        MySqlDataAdapter Adapter;
        DataTable DF;



        private void CountryFromComBox_TextUpdate(object sender, EventArgs e)
        {



            Sql.Connection.Open();

            if (this.CountryFromComBox.Text != "")
            {
                string st = this.CountryFromComBox.Text;
                this.CountryFromComBox.Items.Clear();

                //Запрос к базе данных
                SqlStr = $"SELECT DISTINCT CountryNameRu from country WHERE CountryNameRu LIKE '{CountryFromComBox.Text}%';";
                Cmd = new MySqlCommand(SqlStr, Sql.Connection);
                Adapter = new MySqlDataAdapter(Cmd);
                DF = new DataTable();
                Adapter.Fill(DF);

                if (DF.Rows.Count > 0)
                {
                    for (int i = 0; i < DF.Rows.Count; i++)
                    {
                        CountryFromComBox.Items.Add(DF.Rows[i].ItemArray[0].ToString());

                        CountryFromComBox.SelectionStart = CountryFromComBox.Text.Length;
                    }
                    CountryFromComBox.SelectionStart = CountryFromComBox.Text.Length;
                    CountryFromComBox.DroppedDown = true;
                    CountryFromComBox.Text = st;

                }
                else
                {
                    this.CountryFromComBox.Text = st;
                    CountryFromComBox.SelectionStart = CountryFromComBox.Text.Length;
                    this.CountryFromComBox.Items.Clear();
                }
            }
            CountryFromComBox.SelectionStart = CountryFromComBox.Text.Length;
            Sql.Connection.Close();
        }

        private void CountryGoingComBox_TextUpdate(object sender, EventArgs e)
        {
            if (Program.Delivery == 1)
            {
                Sql.Connection.Open();

                if (this.CountryGoingComBox.Text != "")
                {
                    string st = this.CountryGoingComBox.Text;
                    this.CountryGoingComBox.Items.Clear();

                    //Запрос к базе данных
                    SqlStr = $"SELECT DISTINCT CountryNameRu from country WHERE CountryNameRu LIKE '{CountryGoingComBox.Text}%';";
                    Cmd = new MySqlCommand(SqlStr, Sql.Connection);
                    Adapter = new MySqlDataAdapter(Cmd);
                    DF = new DataTable();
                    Adapter.Fill(DF);

                    if (DF.Rows.Count > 0)
                    {
                        for (int i = 0; i < DF.Rows.Count; i++)
                        {
                            CountryGoingComBox.Items.Add(DF.Rows[i].ItemArray[0].ToString());

                            CountryGoingComBox.SelectionStart = CountryGoingComBox.Text.Length;
                        }
                        CountryGoingComBox.SelectionStart = CountryGoingComBox.Text.Length;
                        CountryGoingComBox.DroppedDown = true;
                        CountryGoingComBox.Text = st;

                    }
                    else
                    {
                        this.CountryGoingComBox.Text = st;
                        CountryGoingComBox.SelectionStart = CountryGoingComBox.Text.Length;
                        this.CountryGoingComBox.Items.Clear();
                    }
                }
                CountryGoingComBox.SelectionStart = CountryGoingComBox.Text.Length;
                Sql.Connection.Close();
            }
        }

        private void Calc_Form_Load(object sender, EventArgs e)
        {
            CargoPanel.Hide();
            button1.Hide();
            if (Program.CCon == 1)
            {
                CargoPanel.Show();
                button1.Show();
            }          
            panel1.Location = new Point(0, 0);
            CargoPanel.Location = new Point(29,287);          
            Program.CargoControlHide = "0";
            Program.CCon = 0;
            MaximumSize = MinimumSize = Size;
            if (Program.Delivery == 0)
            {
                CountryFromComBox.Text = "Россия";
                CountryGoingComBox.Text = "Россия";
                CountryFromComBox.Enabled = false;
                CountryGoingComBox.Enabled = false;
            }

            
        }
        


        private void CargoAddBtn_Click(object sender, EventArgs e)
        {
            Program.HeightCargo = 0;
            Program.WidthCargo = 0;
            Program.LenghtCargo = 0;
            Program.WeightCargo = 0;
            Program.CargoControlHide = "1";
            Program.ShowSpisok = 0;
            CargoSetting cargosetting = new CargoSetting();
            cargosetting.Show();
            CargoPanel.Hide();
            this.Hide();

        }

        private void Calc_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }


        


        public void CargoPanel_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sql.Connection.Open();
            string AdressFrom = CountryFromComBox.Text.ToString() + ", " + textBox1.Text.ToString() + ", " +
                maskedTextBox1.Text.ToString();
            string AdressGoing = CountryGoingComBox.Text.ToString() + ", " + textBox8.Text.ToString() + ", " +
                maskedTextBox2.Text.ToString();

            double cost = Program.WeightCargo * 75;
            MessageBox.Show("Доставка будет стоить: " + cost);
            //SqlAdd = $"insert into vkr.cargo (Width, Height, Length, Weight, AdressFrom, AdressGoing," +
            //    $" DateToSend, Recipient_ID, Sender_ID, Cost) values ({Convert.ToDouble(Program.WidthCargo)}," +
            //    $"{Convert.ToDouble(Program.HeightCargo)}, {Convert.ToDouble(Program.LenghtCargo)}," +
            //    $" {Convert.ToDouble(Program.WeightCargo)}," +
            //    $"{AdressFrom.ToString()}, {AdressGoing.ToString()}, {DateTime.Now.ToString("yyyy-MM-dd")}," +
            //    $"{Convert.ToInt32(g)},{Convert.ToInt32(g)},{Convert.ToDouble(cost)})";
            //Cmd = new MySqlCommand(SqlAdd, Sql.Connection);
            //Cmd.ExecuteNonQuery();
            //Sql.Connection.Close();
            this.Hide();
            if(CountryFromComBox.Text == "")
            {
                MessageBox.Show("Убедитесь, что вы заполнили все поля!");
                this.Show();
            }
         
        }
    }
}
