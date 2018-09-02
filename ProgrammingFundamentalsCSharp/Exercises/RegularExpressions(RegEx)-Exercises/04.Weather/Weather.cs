using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    class Weather
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex(@"([A-Z]{2})(\d+.\d+)([a-zA-Z]+)\|");
            Dictionary<string, KeyValuePair<double, string>> weatherData =
                new Dictionary<string, KeyValuePair<double, string>>();
            string input = string.Empty;
            while ((input=Console.ReadLine())!="end")
            {
                if (reg.IsMatch(input))
                {
                    string city = reg.Match(input).Groups[1].Value;
                    double temperature =double.Parse( reg.Match(input).Groups[2].Value);
                    string weatherType = reg.Match(input).Groups[3].Value;
                    if (!weatherData.ContainsKey(city))
                    {
                        weatherData.Add(city, 
                            new KeyValuePair<double, string>(temperature, weatherType));
                    }
                    else
                    {
                        weatherData[city] = 
                            new KeyValuePair<double, string>(temperature, weatherType);
                    }
                }
            }
            foreach (KeyValuePair<string,KeyValuePair<double,string>> city in weatherData
                .OrderBy(x=>x.Value.Key))
            {
                Console.WriteLine($"{city.Key} => {city.Value.Key:F2} => {city.Value.Value}");
            }
        }
    }
}
