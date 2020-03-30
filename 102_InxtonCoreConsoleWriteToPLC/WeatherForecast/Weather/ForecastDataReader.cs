using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Configuration;
using System.Xml;
using System.IO;
using static Weather.ForecastData;

namespace Weather
{
    class ForecastDataReader
    {
        public Weatherdata getForecastData()
        {
            using(WebClient web = new WebClient())
            {
                string appID = ConfigurationManager.AppSettings["APPID"];
                Int64 cityID = Convert.ToInt64(ConfigurationManager.AppSettings["cityID_Tvrdosin"]);

                string url = string.Format("https://api.openweathermap.org/data/2.5/forecast?id=" + cityID.ToString() + "&appid=" + appID +"&units=metric&mode=xml");
                var xml = web.DownloadString(url);

                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Weatherdata));
            
                Weatherdata data = new Weatherdata();

                using(TextReader reader = new StringReader(xml))
                {
                    data = serializer.Deserialize(reader) as Weatherdata;
                }
                return data;
            }
        }
    }
}
