using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherDashboard.Model;

namespace WeatherDashboard
{

    public static class WeatherService
    {
        private static readonly Random Random = new Random();

        public static List<WeatherData> Generate6HourForecast(WeatherData currentWeather)
        {
            List<WeatherData> forecast = new List<WeatherData>();
            WeatherData previousHour = currentWeather;

            for (int i = 1; i <= 6; i++)
            {
                // Generate the next hour's weather based on the previous hour
                WeatherData nextHour = GenerateNextHourForecast(previousHour);
                forecast.Add(nextHour);
                previousHour = nextHour;
            }

            return forecast;
        }

        public static double ConvertToFahrenheit(double celsius) =>
           (celsius * 9 / 5) + 32;

        private static WeatherData GenerateNextHourForecast(WeatherData previousHour)
        {
            // Randomly adjust temperature within a range of -2 to +2 degrees
            int newTemperature = Clamp(previousHour.Temperature + Random.Next(-2, 3), -10, 40);

            // Adjust humidity slightly within a range of -5% to +5%
            //int newHumidity = Clamp(previousHour.Humidity + Random.Next(-5, 6), 10, 100);

            // Adjust wind speed slightly within a range of -3 to +3 km/h
            //int newWindSpeed = Clamp(previousHour.WindSpeed + Random.Next(-3, 4), 0, 50);

            // Determine if the weather condition changes
            WeatherCondition newCondition = GetUpdatedCondition(previousHour.Condition);

            // Adjust real feel based on temperature and wind speed
            //int newRealFeel = CalculateRealFeel(newTemperature, newWindSpeed);

            // Randomize chance of rain if the condition is rainy or cloudy
            //int newChanceOfRain = newCondition == "Rainy" || newCondition == "Cloudy"
            //    ? Clamp(previousHour.ChanceOfRain + Random.Next(-10, 11), 0, 100)
            //    : 0;

            // Adjust UV Index based on the condition
            //int newUVIndex = GetUVIndex(newCondition, newTemperature);

            return new WeatherData
            {
                Temperature = newTemperature,
                //Humidity = newHumidity,
                //WindSpeed = newWindSpeed,
                Condition = newCondition,
                //RealFeel = newRealFeel,
                //ChanceOfRain = newChanceOfRain,
                //UVIndex = newUVIndex
            };
        }

        private static WeatherCondition GetUpdatedCondition(WeatherCondition currentCondition)
        {
            WeatherCondition[] conditions =
    {
        WeatherCondition.Sunny,
        WeatherCondition.Rainy,
        WeatherCondition.Cloudy,
        WeatherCondition.Partly,
        WeatherCondition.Windy,
        WeatherCondition.Snowy
    };

            // Give a small chance of condition changing
            if (Random.Next(100) < 20)
            {
                var newCondition = conditions[Random.Next(conditions.Length)];
                return newCondition;
            }

            return currentCondition;
        }

        private static int CalculateRealFeel(int temperature, int windSpeed)
        {
            // Example real feel calculation
            return temperature - (int)(0.1 * windSpeed);
        }

        private static int GetUVIndex(string condition, int temperature)
        {
            // Sunny or hot conditions increase UV Index
            if (condition == "Sunny" || temperature > 30)
                return Random.Next(6, 11);

            // Cloudy or rainy conditions lower UV Index
            if (condition == "Cloudy" || condition == "Rainy")
                return Random.Next(1, 5);

            // Default UV Index
            return Random.Next(3, 8);
        }

        private static int Clamp(int value, int min, int max)
        {
            return Math.Max(min, Math.Min(max, value));
        }
    }
}
