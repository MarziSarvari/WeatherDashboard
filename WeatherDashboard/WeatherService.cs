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

            // Determine if the weather condition changes
            WeatherCondition newCondition = GetUpdatedCondition(previousHour.Condition);

            return new WeatherData
            {
                Temperature = newTemperature,                
                Condition = newCondition,                
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

        private static int Clamp(int value, int min, int max)
        {
            return Math.Max(min, Math.Min(max, value));
        }
    }
}
