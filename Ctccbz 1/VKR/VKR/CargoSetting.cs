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
    public partial class CargoSetting : Form
    {
        public CargoSetting()
        {
            InitializeComponent();
        }

        private void CargoSetting_Load(object sender, EventArgs e)
        {
            HeightBox.Text = Program.HeightCargo.ToString();
            WidthBox.Text = Program.WidthCargo.ToString();
            LengthBox.Text = Program.LenghtCargo.ToString();
            Weight_Txt.Text = Program.WeightCargo.ToString();

        }

        private void HeightBox_Click(object sender, EventArgs e)
        {
            HeightBox.Text = "Высота";
            HeightBox.ForeColor = Color.Gray;
            HeightBox.SelectAll();
        }


        private void HeightBox_Leave(object sender, EventArgs e)
        {
            if (HeightBox.Text == "Высота")
            {
                HeightBox.Text = "0";
                HeightBox.ForeColor = Color.Black;
            }
        }

        private void WidthBox_Click(object sender, EventArgs e)
        {
            WidthBox.Text = "Ширина";
            WidthBox.ForeColor = Color.Gray;
            WidthBox.SelectAll();
        }

        private void WidthBox_Leave(object sender, EventArgs e)
        {

        }

        private void LengthBox_Click(object sender, EventArgs e)
        {
            LengthBox.Text = "Длина";
            LengthBox.ForeColor = Color.Gray;
            LengthBox.SelectAll();
        }

        private void LengthBox_Leave(object sender, EventArgs e)
        {
            if (LengthBox.Text == "Длина")
            {
                LengthBox.Text = "0";
                LengthBox.ForeColor = Color.Black;
            }
        }

        public void Done_Btn_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(HeightBox.Text) > 120 || Convert.ToDouble(HeightBox.Text) < 0.1
                || Convert.ToDouble(WidthBox.Text) > 80 || Convert.ToDouble(WidthBox.Text) < 0.1
                || Convert.ToDouble(LengthBox.Text) > 80 || Convert.ToDouble(LengthBox.Text) < 0.1
                || Convert.ToDouble(Weight_Txt.Text) > 50
                || Convert.ToDouble(Weight_Txt.Text) < 0.5)
            {
                MessageBox.Show("Недопустимые значения размера или веса груза!");
            }
            else
            {
                Program.HeightCargo = Convert.ToDouble(HeightBox.Text);
                Program.WidthCargo = Convert.ToDouble(WidthBox.Text);
                Program.LenghtCargo = Convert.ToDouble(LengthBox.Text);
                Program.WeightCargo = Convert.ToDouble(Weight_Txt.Text);
                Program.CargoControlHide = "0";
                Program.Done = 1;
                HeightBox.Text = "0";
                WidthBox.Text = "0";
                LengthBox.Text = "0";
                Weight_Txt.Text = "";
                Program.ShowSpisok = 1;
                Program.CCon = 1;

                Cargo cargo = new Cargo();
                cargo.Cargo_Load(Program.HeightCargo.ToString(), Program.WidthCargo.ToString(), Program.LenghtCargo.ToString(),
                Program.WeightCargo.ToString());
                Calc_Form calc_Form = new Calc_Form();
                calc_Form.CargoPanel.Show();
                calc_Form.CargoPanel.Controls.Add(cargo);
                calc_Form.button1.Show();
                calc_Form.Show(); 
                this.Hide();
            }
        }

        private void HeightBox_TextChanged(object sender, EventArgs e)
        {
            if (HeightBox.Text != "Высота")
            {
                HeightBox.ForeColor = Color.Black;
            }
        }

        private void WidthBox_TextChanged(object sender, EventArgs e)
        {
            if (WidthBox.Text != "Ширина")
            {
                WidthBox.ForeColor = Color.Black;
            }
        }

        private void LengthBox_TextChanged(object sender, EventArgs e)
        {
            if (LengthBox.Text != "Длина")
            {
                LengthBox.ForeColor = Color.Black;
            }
        }

        public void HeightBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void WidthBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void LengthBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void Weight_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void Weight_Txt_TextChanged(object sender, EventArgs e)
        {
            if (Weight_Txt.Text == "")
            {
                Weight_Txt.Text = "0";
            }
            if (Convert.ToDouble(Weight_Txt.Text) > 50 || Convert.ToDouble(Weight_Txt.Text) < 0.5)
            {
                MaksWeight_lbl.Show();
            }
            else
            {
                MaksWeight_lbl.Hide();
            }
            if (Convert.ToDouble(Weight_Txt.Text) > 50)
            {
                MaksWeight_lbl.Text = "Максимальный вес одного места 50";
            }
            if (Convert.ToDouble(Weight_Txt.Text) < 0.5)
            {
                MaksWeight_lbl.Text = "Минимальный оплачиваемый вес одного места 0.5";
            }
        }

        private void Weight_Txt_Click(object sender, EventArgs e)
        {
            Weight_Txt.SelectAll(); 
        }
    }
}
