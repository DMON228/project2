using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKR
{
    static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authotization());
        }
        public static int Delivery = 1;
        public static string CargoControlHide = "0";//0 - CargoControl1.Hide(), 1-CargoControl1.Show()

        //груз
        public static double WidthCargo = 0;
        public static double HeightCargo = 0;
        public static double LenghtCargo = 0;
        public static double WeightCargo = 0;
        public static int Done = 0;


        public static int SettingsClick = 0;

        public static int ShowSpisok = 0;

        public static int CCon = 0;

        public static int CargoID = 0; 


    }
    
}
