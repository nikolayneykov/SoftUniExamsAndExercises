using System;

namespace _05.WeatherForecast
{
    class WeatherForecast
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string weather = string.Empty;
            if (input.Contains("."))
            {
                weather = "Rainy";
            }
            else
            {
                long number = long.Parse(input);
                if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
                {
                    weather = "Sunny";
                }
                else if (number >= int.MinValue && number <= int.MaxValue)
                {
                    weather = "Cloudy";
                }
                else if (number >= long.MinValue && number <= long.MaxValue)
                {
                    weather = "Windy";
                }
            }
            Console.WriteLine(weather);
        }
    }
}
