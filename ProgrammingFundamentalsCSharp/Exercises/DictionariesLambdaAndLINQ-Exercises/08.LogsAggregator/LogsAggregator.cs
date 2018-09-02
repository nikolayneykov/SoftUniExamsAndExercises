using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.LogsAggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<KeyValuePair<int, string>>> data =
            new Dictionary<string, List<KeyValuePair<int, string>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string ip = tokens[0];
                string name = tokens[1];
                int duration = int.Parse(tokens[2]);
                if (!data.ContainsKey(name))
                {
                    data.Add(name, new List<KeyValuePair<int, string>>());
                }
                data[name].Add(new KeyValuePair<int, string>(duration, ip));
            }
            foreach (var item in data.OrderBy(x => x.Key))
            {
                string name = item.Key;
                int durationSum = item.Value.Sum(x => x.Key);
                List<string> ipData = item.Value.Select(x => x.Value).Distinct().OrderBy(x => x).ToList();
                Console.WriteLine($"{name}: {durationSum} [{string.Join(", ", ipData)}]");
            }
        }
    }
}
