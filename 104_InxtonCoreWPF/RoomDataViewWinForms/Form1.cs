using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoomController;


namespace RoomDataViewWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Timer t = new Timer() { Interval = 250 };
            t.Tick += T_Tick;
            t.Start();

        }

        private void T_Tick(object sender, EventArgs e)
        {
            var RoomData = Entry.RoomControllerPlc.MAIN.RoomData;

            this.lbTemperature.Text = RoomData.Temperature.AttributeName;
            this.tbTemperature.Text = RoomData.Temperature.Cyclic.ToString();
            this.lbHumidity.Text = RoomData.Humidity.AttributeName;
            this.tbHumidity.Text = RoomData.Humidity.Cyclic.ToString();
            this.lbVOC.Text = RoomData.VOC.AttributeName;
            this.tbVOC.Text = RoomData.VOC.Cyclic.ToString();
            this.lbCO2.Text = RoomData.CO2.AttributeName;
            this.tbCO2.Text = RoomData.CO2.Cyclic.ToString();

        }
    }
}
