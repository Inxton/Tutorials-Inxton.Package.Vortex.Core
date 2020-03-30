using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Weather
{
    public class ForecastData
    {
        [XmlRoot(ElementName = "location")]
        public class Location
        {
            [XmlAttribute(AttributeName = "altitude")]
            public string Altitude { get; set; }
            [XmlAttribute(AttributeName = "latitude")]
            public string Latitude { get; set; }
            [XmlAttribute(AttributeName = "longitude")]
            public string Longitude { get; set; }
            [XmlAttribute(AttributeName = "geobase")]
            public string Geobase { get; set; }
            [XmlAttribute(AttributeName = "geobaseid")]
            public string Geobaseid { get; set; }
        }

        [XmlRoot(ElementName = "meta")]
        public class Meta
        {
            [XmlElement(ElementName = "lastupdate")]
            public string Lastupdate { get; set; }
            [XmlElement(ElementName = "calctime")]
            public string Calctime { get; set; }
            [XmlElement(ElementName = "nextupdate")]
            public string Nextupdate { get; set; }
        }

        [XmlRoot(ElementName = "sun")]
        public class Sun
        {
            [XmlAttribute(AttributeName = "rise")]
            public string Rise { get; set; }
            [XmlAttribute(AttributeName = "set")]
            public string Set { get; set; }
        }

        [XmlRoot(ElementName = "symbol")]
        public class Symbol
        {
            [XmlAttribute(AttributeName = "number")]
            public string Number { get; set; }
            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }
            [XmlAttribute(AttributeName = "var")]
            public string Var { get; set; }
        }

        [XmlRoot(ElementName = "precipitation")]
        public class Precipitation
        {
            [XmlAttribute(AttributeName = "unit")]
            public string Unit { get; set; }
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
        }

        [XmlRoot(ElementName = "windDirection")]
        public class WindDirection
        {
            [XmlAttribute(AttributeName = "deg")]
            public string Deg { get; set; }
            [XmlAttribute(AttributeName = "code")]
            public string Code { get; set; }
            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }
        }

        [XmlRoot(ElementName = "windSpeed")]
        public class WindSpeed
        {
            [XmlAttribute(AttributeName = "mps")]
            public string Mps { get; set; }
            [XmlAttribute(AttributeName = "unit")]
            public string Unit { get; set; }
            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }
        }

        [XmlRoot(ElementName = "temperature")]
        public class Temperature
        {
            [XmlAttribute(AttributeName = "unit")]
            public string Unit { get; set; }
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
            [XmlAttribute(AttributeName = "min")]
            public string Min { get; set; }
            [XmlAttribute(AttributeName = "max")]
            public string Max { get; set; }
        }

        [XmlRoot(ElementName = "feels_like")]
        public class Feels_like
        {
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
            [XmlAttribute(AttributeName = "unit")]
            public string Unit { get; set; }
        }

        [XmlRoot(ElementName = "pressure")]
        public class Pressure
        {
            [XmlAttribute(AttributeName = "unit")]
            public string Unit { get; set; }
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
        }

        [XmlRoot(ElementName = "humidity")]
        public class Humidity
        {
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
            [XmlAttribute(AttributeName = "unit")]
            public string Unit { get; set; }
        }

        [XmlRoot(ElementName = "clouds")]
        public class Clouds
        {
            [XmlAttribute(AttributeName = "value")]
            public string Value { get; set; }
            [XmlAttribute(AttributeName = "all")]
            public string All { get; set; }
            [XmlAttribute(AttributeName = "unit")]
            public string Unit { get; set; }
        }

        [XmlRoot(ElementName = "time")]
        public class Time
        {
            [XmlElement(ElementName = "symbol")]
            public Symbol Symbol { get; set; }
            [XmlElement(ElementName = "precipitation")]
            public Precipitation Precipitation { get; set; }
            [XmlElement(ElementName = "windDirection")]
            public WindDirection WindDirection { get; set; }
            [XmlElement(ElementName = "windSpeed")]
            public WindSpeed WindSpeed { get; set; }
            [XmlElement(ElementName = "temperature")]
            public Temperature Temperature { get; set; }
            [XmlElement(ElementName = "feels_like")]
            public Feels_like Feels_like { get; set; }
            [XmlElement(ElementName = "pressure")]
            public Pressure Pressure { get; set; }
            [XmlElement(ElementName = "humidity")]
            public Humidity Humidity { get; set; }
            [XmlElement(ElementName = "clouds")]
            public Clouds Clouds { get; set; }
            [XmlAttribute(AttributeName = "from")]
            public string From { get; set; }
            [XmlAttribute(AttributeName = "to")]
            public string To { get; set; }
        }

        [XmlRoot(ElementName = "forecast")]
        public class Forecast
        {
            [XmlElement(ElementName = "time")]
            public List<Time> Time { get; set; }
        }

        [XmlRoot(ElementName = "weatherdata")]
        public class Weatherdata
        {
            [XmlElement(ElementName = "location")]
            public Location Location { get; set; }
            [XmlElement(ElementName = "credit")]
            public string Credit { get; set; }
            [XmlElement(ElementName = "meta")]
            public Meta Meta { get; set; }
            [XmlElement(ElementName = "sun")]
            public Sun Sun { get; set; }
            [XmlElement(ElementName = "forecast")]
            public Forecast Forecast { get; set; }
        }

    }

}
