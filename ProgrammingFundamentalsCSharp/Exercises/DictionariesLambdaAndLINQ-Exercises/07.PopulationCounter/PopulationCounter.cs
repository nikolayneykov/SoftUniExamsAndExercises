using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PopulationCounter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> populationData =
                new Dictionary<string, Dictionary<string, long>>();
            string input = string.Empty;
            while ((input=Console.ReadLine())!="report")
            {
                string[] tokens = input.Split(new[] { '|'},StringSplitOptions.RemoveEmptyEntries);
                string city = tokens[0];
                string country = tokens[1];
                long population = long.Parse(tokens[2]);
                if (!populationData.ContainsKey(country))
                {
                    populationData.Add(country, new Dictionary<string, long>());
                }
                if (!populationData[country].ContainsKey(city))
                {
                    populationData[country].Add(city, 0);
                }
                populationData[country][city] += population;
            }
            foreach (var country in populationData.OrderByDescending(x=>x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in country.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
