using System.ComponentModel;
using WeatherDashboard.Model;

namespace WeatherDashboard.Model
{
    public static class Database
    {
        public static List<City> Cities { get; private set; }

        public static UserSetting UserSetting { get; set; }


        static Database()
        {
            // Load data from XML using DataAccess
            Cities = DataSerializer.Deserialize<List<City>>("cities.xml");
            foreach (City city in Cities)
            {
                  city.Forcastfor6Hours = WeatherService.Generate6HourForecast(city.CurrentWeather);
            }

            UserSetting = DataSerializer.Deserialize<UserSetting>("userSetting.xml");



        }

        public static void SaveSetting()
        {
            DataSerializer.Serialize(UserSetting, "userSetting.xml");
        }
    }
}
