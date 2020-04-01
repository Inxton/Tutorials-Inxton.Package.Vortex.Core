using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RoomController;


namespace RoomDataViewWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var RoomData = Entry.RoomControllerPlc.MAIN.RoomData;
            this.itemsList.ItemsSource = RoomData.GetValueTags();

            System.Windows.Threading.DispatcherTimer t = new System.Windows.Threading.DispatcherTimer();
            t.Tick += new EventHandler(LogDataAsXml);
            t.Interval = new TimeSpan(0, 0, 5);
            t.Start();

        }
        private void LogDataAsXml(object sender, EventArgs e)
        {
            using (var ws = new System.IO.StreamWriter(System.IO.Path.Combine(Environment.CurrentDirectory, "log2xml.txt"), true))
            {
                var plain = Entry.RoomControllerPlc.MAIN.RoomData.CreatePlainerType();
                Entry.RoomControllerPlc.MAIN.RoomData.FlushOnlineToPlain(plain);

                var serializer = new System.Xml.Serialization.XmlSerializer(plain.GetType());
                serializer.Serialize(ws, plain);
            }
        }
    }
}
