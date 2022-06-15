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

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
        }


        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void ExpressDeliveryRus_Click(object sender, EventArgs e)
        {

        }

        private void Calc_Btn_Click(object sender, EventArgs e)
        {
            Program.Delivery = 1;
            Calc_Form calc_Form = new Calc_Form();
            calc_Form.Show();
            this.Hide();
        }

        private void RegularDeliveryRus_Click(object sender, EventArgs e)
        {
            Program.Delivery = 0;
            Calc_Form calc_Form = new Calc_Form();
            calc_Form.Show();
            this.Hide();
        }

        private void RegularDeliveryInter_Click(object sender, EventArgs e)
        {
            Program.Delivery = 1;
            Calc_Form calc_Form = new Calc_Form();
            calc_Form.Show();
            this.Hide();

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Authotization authotization = new Authotization();
            authotization.Show();
        }

        private void TrackingBtn_Click(object sender, EventArgs e)
        {
            TrackingForm trackingForm = new TrackingForm();
            trackingForm.Show();
            this.Hide();
        }


    }
}
