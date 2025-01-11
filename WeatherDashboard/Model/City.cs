using System;

namespace WeatherDashboard.Model
{
    [Serializable]
    public class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public WeatherData CurrentWeather { get; set; }
        public List<WeatherData> Forcastfor6Hours { get; set; }
    }
}
