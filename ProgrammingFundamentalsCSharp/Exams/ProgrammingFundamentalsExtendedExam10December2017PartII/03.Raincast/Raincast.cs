using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Raincast
{
    class Raincast
    {
        static void Main(string[] args)
        {
            bool searchType = true;
            bool searchSource = false;
            bool searchForecast = false;
            string currentType = string.Empty;
            string currentSource = string.Empty;
            string currentForecast = string.Empty;
            string input = string.Empty;

            List<string> result = new List<string>();
            while ((input = Console.ReadLine()) != "Davai Emo")
            {
                if (searchType)
                {
                    Regex typePattern = new Regex("^Type: (?<type>Normal|Warning|Danger)$");
                    if (typePattern.IsMatch(input))
                    {
                        currentType = typePattern
                            .Match(input)
                            .Groups["type"]
                            .Value;
                        searchType = false;
                        searchSource = true;
                    }
                }
                if (searchSource)
                {
                    Regex sourcePattern = new Regex(@"^Source: (?<source>\w+)$");
                    if (sourcePattern.IsMatch(input))
                    {
                        currentSource = sourcePattern
                            .Match(input)
                            .Groups["source"]
                            .Value;
                        searchSource = false;
                        searchForecast = true;
                    }
                }
                else if (searchForecast)
                {
                    Regex forecastPattern = new Regex("^Forecast: (?<forecast>[^!.,?]+)$");
                    if (forecastPattern.IsMatch(input))
                    {
                        currentForecast = forecastPattern
                            .Match(input)
                            .Groups["forecast"]
                            .Value;
                        result.Add($"({currentType}) {currentForecast} ~ {currentSource}");
                        searchType = true;
                        searchForecast = false;
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
