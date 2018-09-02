using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _10.СръбскоUnleashed
{
    class СръбскоUnleashed
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> data =
                new Dictionary<string, Dictionary<string, int>>();
            Regex reg = new Regex(@"^(.+)\s@(.+)\s(\d+)\s(\d+)$");
            string input = string.Empty;
            while ((input=Console.ReadLine())!="End")
            {
                if (reg.IsMatch(input))
                {
                    string singer = reg.Match(input).Groups[1].Value;
                    string venue = reg.Match(input).Groups[2].Value;
                    int ticketPrice = int.Parse(reg.Match(input).Groups[3].Value);
                    int ticketCount = int.Parse(reg.Match(input).Groups[4].Value);
                    int totalMoney = ticketPrice * ticketCount;
                    if (!data.ContainsKey(venue))
                    {
                        data.Add(venue, new Dictionary<string, int>());
                    }
                    if (!data[venue].ContainsKey(singer))
                    {
                        data[venue].Add(singer, 0);
                    }
                    data[venue][singer] += totalMoney;
                }
            }
            foreach (var venue in data)
            {
                Console.WriteLine(venue.Key);
                foreach (var singer in venue.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
