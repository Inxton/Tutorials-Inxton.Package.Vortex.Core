using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using RoomController;

namespace RoomDataView
{
    class Program
    {        
        private static void OutputDataToConsole(object o)
        {
            var RoomData = RoomController.Entry.RoomControllerPlc.MAIN.RoomData;

            Console.WriteLine("Time: " + DateTime.Now.ToString() + " | " +
                RoomData.Temperature.AttributeName + ": " + RoomData.Temperature.Cyclic.ToString() + " | " +
                RoomData.Humidity.AttributeName + ": " + RoomData.Humidity.Cyclic.ToString() + " | " +
                RoomData.VOC.AttributeName + ": " + RoomData.VOC.Cyclic.ToString() + " | " +
                RoomData.CO2.AttributeName + ": " + RoomData.CO2.Cyclic.ToString() + " | ");
        }

        static void Main(string[] args)
        {            
            Entry.RoomControllerPlc.Connector.ReadWriteCycleDelay = 100;
            Entry.RoomControllerPlc.Connector.BuildAndStart();
            Timer t = new Timer(OutputDataToConsole, null, 0, 1000);

            Console.ReadLine();            
        }
    }
}
