using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace WeatherDashboard.Model
{
    [Serializable]
    public class UserSetting
    {
        public TemperatureUnit DefaultTemperatureUnit { get; set; } = TemperatureUnit.Celsius;
        public HashSet<string> PreferredCities { get; set; } = [];

    }

    public enum TemperatureUnit
    {
        Celsius,
        Fahrenheit
    }

}
