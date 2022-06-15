using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace VKR
{
    public partial class Cargo : UserControl
    {
        Calc_Form calc;
        public Cargo()
        {
            InitializeComponent();
            
        }

        


        public void SettingsCargo_Click(object sender, EventArgs e)
        {
            Program.CargoControlHide = "1";
            Program.CCon = 1;
            Program.WeightCargo = Convert.ToDouble(Weight_cargo.Text);
            Program.ShowSpisok = 0;
            string temp = Dimensions_cargo.Text.TrimEnd('с', 'м');
            string[] Dimension = temp.Split('x');
            Program.HeightCargo = Convert.ToDouble(Dimension[0]);
            Program.WidthCargo = Convert.ToDouble(Dimension[1]);
            Program.LenghtCargo = Convert.ToDouble(Dimension[2]);
            calc = new Calc_Form();

            
        }

        public void Cargo_Load(string height, string width, string length, string weight)
        {
            Weight_cargo.Text = Program.WeightCargo.ToString();
            Dimensions_cargo.Text = Program.HeightCargo.ToString() + "x" + Program.WidthCargo.ToString()
                + "x" + Program.LenghtCargo.ToString() + "см";

        }
    }
}
