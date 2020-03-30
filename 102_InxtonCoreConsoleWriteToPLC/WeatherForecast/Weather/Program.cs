using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using PLC;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            Entry.Plc.Connector.ReadWriteCycleDelay = 100;
            Entry.Plc.Connector.BuildAndStart();

            Entry.Plc.MAIN.bGetWeatherData.Subscribe((sender, arg) =>
            {
                if (Entry.Plc.MAIN.bGetWeatherData.LastValue == true)
                {
                    GetForecastData();
                    Entry.Plc.MAIN.bGetWeatherData.Cyclic = false;
                }
            });

            Console.ReadLine();

        }

        static void GetForecastData()
        {
            ForecastDataReader forecastDataReader = new ForecastDataReader();
            var data = forecastDataReader.getForecastData();

            Entry.Plc.MAIN.WeatherData.sunrise.Cyclic = Convert.ToDateTime(data.Sun.Rise);
            Entry.Plc.MAIN.WeatherData.sunset.Cyclic = Convert.ToDateTime(data.Sun.Set);
            for (int i = 0; i < 40; i++)
            {
                Entry.Plc.MAIN.WeatherData.Forecast[i].timeFrom.Cyclic = Convert.ToDateTime(data.Forecast.Time[i].From);
                Entry.Plc.MAIN.WeatherData.Forecast[i].timeTo.Cyclic = Convert.ToDateTime(data.Forecast.Time[i].To);
                Entry.Plc.MAIN.WeatherData.Forecast[i].precipitation_unit.Cyclic = Convert.ToString(data.Forecast.Time[i].Precipitation.Unit);
                Entry.Plc.MAIN.WeatherData.Forecast[i].precipitation_value.Cyclic = Convert.ToSingle(data.Forecast.Time[i].Precipitation.Value);
                Entry.Plc.MAIN.WeatherData.Forecast[i].precipitation_type.Cyclic = Convert.ToString(data.Forecast.Time[i].Precipitation.Type);
                Entry.Plc.MAIN.WeatherData.Forecast[i].windDirection_value.Cyclic = Convert.ToSingle(data.Forecast.Time[i].WindDirection.Deg);
                Entry.Plc.MAIN.WeatherData.Forecast[i].windDirection_name.Cyclic = Convert.ToString(data.Forecast.Time[i].WindDirection.Name);
                Entry.Plc.MAIN.WeatherData.Forecast[i].windSpeed_value.Cyclic = Convert.ToSingle(data.Forecast.Time[i].WindSpeed.Mps);
                Entry.Plc.MAIN.WeatherData.Forecast[i].windSpeed_unit.Cyclic = Convert.ToString(data.Forecast.Time[i].WindSpeed.Unit);
                Entry.Plc.MAIN.WeatherData.Forecast[i].windSpeed_name.Cyclic = Convert.ToString(data.Forecast.Time[i].WindSpeed.Name);
                Entry.Plc.MAIN.WeatherData.Forecast[i].temperature_value.Cyclic = Convert.ToSingle(data.Forecast.Time[i].Temperature.Value);
                Entry.Plc.MAIN.WeatherData.Forecast[i].temperature_unit.Cyclic = Convert.ToString(data.Forecast.Time[i].Temperature.Unit);
                Entry.Plc.MAIN.WeatherData.Forecast[i].temperature_min.Cyclic = Convert.ToSingle(data.Forecast.Time[i].Temperature.Min);
                Entry.Plc.MAIN.WeatherData.Forecast[i].temperature_max.Cyclic = Convert.ToSingle(data.Forecast.Time[i].Temperature.Max);
                Entry.Plc.MAIN.WeatherData.Forecast[i].temperature_feel_like.Cyclic = Convert.ToSingle(data.Forecast.Time[i].Feels_like.Value);
                Entry.Plc.MAIN.WeatherData.Forecast[i].pressure_value.Cyclic = Convert.ToSingle(data.Forecast.Time[i].Pressure.Value);
                Entry.Plc.MAIN.WeatherData.Forecast[i].pressure_unit.Cyclic = Convert.ToString(data.Forecast.Time[i].Pressure.Unit);
                Entry.Plc.MAIN.WeatherData.Forecast[i].humidity_value.Cyclic = Convert.ToSingle(data.Forecast.Time[i].Humidity.Value);
                Entry.Plc.MAIN.WeatherData.Forecast[i].humidity_UNIT.Cyclic = Convert.ToString(data.Forecast.Time[i].Humidity.Unit); 
            }
        }
    }
}
