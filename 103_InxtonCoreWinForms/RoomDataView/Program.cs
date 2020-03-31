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
        static void Main(string[] args)
        {
            Entry.RoomControllerPlc.Connector.ReadWriteCycleDelay = 100;
            Entry.RoomControllerPlc.Connector.BuildAndStart();

            for(int i = 0; i < 10; i++)
            {
                ViewDataCyclic();
                ViewDataSynchron();
                ViewDataBulkRead();
                Console.ReadLine();
            }
        }

        private static System.Diagnostics.Stopwatch _sw = new System.Diagnostics.Stopwatch();

        private static void ViewDataCyclic()
        {
            _sw.Restart();
            Console.WriteLine($"Executing : {nameof(ViewDataCyclic)}");

            var RoomData = RoomController.Entry.RoomControllerPlc.MAIN.RoomData;

            Console.WriteLine("Time: " + DateTime.Now.ToString() + " | " +
                RoomData.Temperature.AttributeName + ": " + RoomData.Temperature.Cyclic.ToString() + " | " +
                RoomData.Humidity.AttributeName + ": " + RoomData.Humidity.Cyclic.ToString() + " | " +
                RoomData.VOC.AttributeName + ": " + RoomData.VOC.Cyclic.ToString() + " | " +
                RoomData.CO2.AttributeName + ": " + RoomData.CO2.Cyclic.ToString() + " | ");

            Console.WriteLine($"Executed: {nameof(ViewDataCyclic)} in {_sw.ElapsedTicks}");
        }

        private static void ViewDataSynchron()
        {
            _sw.Restart();
            Console.WriteLine($"Executing : {nameof(ViewDataSynchron)}");

            var RoomData = RoomController.Entry.RoomControllerPlc.MAIN.RoomData;

            Console.WriteLine("Time: " + DateTime.Now.ToString() + " | " +
                RoomData.Temperature.AttributeName + ": " + RoomData.Temperature.Synchron.ToString() + " | " +
                RoomData.Humidity.AttributeName + ": " + RoomData.Humidity.Synchron.ToString() + " | " +
                RoomData.VOC.AttributeName + ": " + RoomData.VOC.Synchron.ToString() + " | " +
                RoomData.CO2.AttributeName + ": " + RoomData.CO2.Synchron.ToString() + " | ");

            Console.WriteLine($"Executed: {nameof(ViewDataSynchron)} in {_sw.ElapsedTicks}");
        }

        private static void ViewDataBulkRead()
        {
            _sw.Restart();
            Console.WriteLine($"Executing : {nameof(ViewDataBulkRead)}");

            var RoomData = RoomController.Entry.RoomControllerPlc.MAIN.RoomData;

            Console.WriteLine("Time: " + DateTime.Now.ToString() + " | " +
                RoomData.Temperature.AttributeName + ": " + RoomData.Temperature.LastValue.ToString() + " | " +
                RoomData.Humidity.AttributeName + ": " + RoomData.Humidity.LastValue.ToString() + " | " +
                RoomData.VOC.AttributeName + ": " + RoomData.VOC.LastValue.ToString() + " | " +
                RoomData.CO2.AttributeName + ": " + RoomData.CO2.LastValue.ToString() + " | ");

            Console.WriteLine($"Executed: {nameof(ViewDataBulkRead)} in {_sw.ElapsedTicks}");
        }
    }
}
