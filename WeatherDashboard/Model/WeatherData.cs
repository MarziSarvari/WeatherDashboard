using System;

namespace WeatherDashboard.Model
{
    [Serializable]
    public class WeatherData
    {
        public int Temperature { get; set; } // Temperature in Celsius
        public int Humidity { get; set; }    // Percentage
        public int WindSpeed { get; set; }  // Speed in km/h
        public WeatherCondition Condition { get; set; } = WeatherCondition.Sunny; 
        public int RealFeel { get; set; }
        public int ChanceOfRain { get; set; }
        public int UVIndex { get; set; }
    }

    public enum WeatherCondition
    {
        Cloudy,
        Partly, 
        Rainy,
        Snowy,
        Sunny,
        Windy,
        Hot,
        Humid,
        Clear 
    }
}
