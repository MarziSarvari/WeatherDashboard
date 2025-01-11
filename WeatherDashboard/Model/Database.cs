using System.ComponentModel;
using WeatherDashboard.Model;
using WeatherDashboard.Tool;

namespace WeatherDashboard.Model
{
    public static class Database
    {
        public static List<City> Cities { get; private set; }

        public static UserSetting UserSetting { get; set; }


        static Database()
        {
            // Load data from XML using DataAccess
            Cities = DataSerializer.Deserialize<List<City>>("Data/cities.xml");
            foreach (City city in Cities)
            {
                  city.Forcastfor6Hours = WeatherService.Generate6HourForecast(city.CurrentWeather);
            }

            UserSetting = DataSerializer.Deserialize<UserSetting>("Data/userSetting.xml");
        }

        public static void SaveSetting()
        {
            DataSerializer.Serialize(UserSetting, "Data/userSetting.xml");
        }
    }
}
