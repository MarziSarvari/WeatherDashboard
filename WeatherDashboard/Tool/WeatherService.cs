using WeatherDashboard.Model;

namespace WeatherDashboard.Tool
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
           celsius * 9 / 5 + 32;

        private static WeatherData GenerateNextHourForecast(WeatherData previousHour)
        {
            // Randomly adjust temperature within a range of -2 to +2 degrees
            int newTemperature = Clamp(previousHour.Temperature + Random.Next(-2, 3), -10, 40);

            // Determine if the weather condition changes
            WeatherCondition newCondition = GetUpdatedCondition(newTemperature);

            return new WeatherData
            {
                Temperature = newTemperature,
                Condition = newCondition,
            };
        }

        private static WeatherCondition GetUpdatedCondition(int newTemperature)
        {
            // Determine the base weather condition based on temperature
            WeatherCondition newCondition = newTemperature switch
            {
                < 0 => WeatherCondition.Snowy,
                < 10 => Random.Next(100) < 20 ? WeatherCondition.Rainy : WeatherCondition.Cloudy, // 20% chance of Rainy
                < 20 => Random.Next(100) < 20 ? WeatherCondition.Rainy : WeatherCondition.Partly, // 20% chance of Rainy
                < 30 => WeatherCondition.Sunny,
                _ => WeatherCondition.Windy,
            };

            return newCondition;
        }

        private static int Clamp(int value, int min, int max)
        {
            return Math.Max(min, Math.Min(max, value));
        }
    }
}
