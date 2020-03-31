using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using RoomController;


namespace RoomDataViewWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static RoomController.RoomControllerTwinController Connector;

        public App()
        {
            Connector = Entry.RoomControllerPlc;
            Connector.Connector.BuildAndStart();
            Connector.Connector.ReadWriteCycleDelay = 100;


        }
    }
}
