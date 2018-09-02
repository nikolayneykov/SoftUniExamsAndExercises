using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WormsWorldParty
{
    class WormsWorldParty
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> data =
                new Dictionary<string, Dictionary<string, long>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "quit")
            {
                string[] tokens = input.Split(new string[] { " -> " },
                    StringSplitOptions.RemoveEmptyEntries);
                string wormName = tokens[0];
                string teamName = tokens[1];
                long wormScore = long.Parse(tokens[2]);

                if (!data.Values.Any(x => x.ContainsKey(wormName)))
                {
                    if (!data.ContainsKey(teamName))
                    {
                        data.Add(teamName, new Dictionary<string, long>());
                    }
                    data[teamName].Add(wormName, wormScore);
                }
            }
            data = data
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenByDescending(x => x.Value.Values.Average())
                .ToDictionary(x => x.Key, x => x.Value
                   .OrderByDescending(w => w.Value)
                   .ToDictionary(w => w.Key, w => w.Value));
            int cnt = 1;
            foreach (KeyValuePair<string, Dictionary<string, long>> team in data)
            {
                string teamName = team.Key;
                long teamScore = team.Value.Values.Sum();
                Console.WriteLine($"{cnt}. Team: {teamName} - {teamScore}");
                Dictionary<string, long> worms = team.Value;
                foreach (KeyValuePair<string, long> worm in worms)
                {
                    string wormName = worm.Key;
                    long wormScore = worm.Value;
                    Console.WriteLine($"###{wormName} : {wormScore}");
                }
                cnt++;
            }
        }
    }
}
