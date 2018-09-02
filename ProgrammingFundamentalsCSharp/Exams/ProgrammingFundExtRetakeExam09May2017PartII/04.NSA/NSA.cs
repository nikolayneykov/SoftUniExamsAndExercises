using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NSA
{
    class NSA
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> spyData =
                new Dictionary<string, Dictionary<string, int>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "quit")
            {
                string[] tokens = input.Split(new string[] { " -> " },
                    StringSplitOptions.RemoveEmptyEntries);
                string country = tokens[0];
                string spyName = tokens[1];
                int daysInService = int.Parse(tokens[2]);
                if (!spyData.ContainsKey(country))
                {
                    spyData.Add(country, new Dictionary<string, int>());
                }
                spyData[country][spyName] = daysInService;
            }
            spyData = spyData
                .OrderByDescending(c => c.Value.Count)
                .ToDictionary(c => c.Key, c => c.Value
                   .OrderByDescending(s => s.Value)
                   .ToDictionary(s=>s.Key,s=>s.Value));
            foreach (KeyValuePair<string,Dictionary<string,int>> country in spyData)
            {
                string countryName = country.Key;
                Console.WriteLine($"Country: {countryName}");
                Dictionary<string, int> spyes = country.Value;
                foreach (KeyValuePair<string,int> spy in spyes)
                {
                    string spyName = spy.Key;
                    int daysInService = spy.Value;
                    Console.WriteLine($"**{spyName} : {daysInService}");
                }
            }
        }
    }
}
