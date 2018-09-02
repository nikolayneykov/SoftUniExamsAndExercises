using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CODEPhoenixOscarRomeoNovember
{
    class CODEPhoenixOscarRomeoNovember
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> data =
                new Dictionary<string, List<string>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Blaze it!")
            {
                string[] inputTokens = input
                    .Split(new string[] { " -> " },
                    StringSplitOptions.RemoveEmptyEntries);
                string creature = inputTokens[0];
                string squadMate = inputTokens[1];
                if (!data.ContainsKey(creature))
                {
                    data.Add(creature, new List<string>());
                }
                if (!data[creature].Contains(squadMate))
                {
                    data[creature].Add(squadMate);
                }
            }
            Dictionary<string, int> result =
                new Dictionary<string, int>();
            foreach (KeyValuePair<string, List<string>> creatures in data)
            {
                string currentCreature = creatures.Key;
                List<string> currentSquadMates = creatures.Value;
                int squadMatesCount = creatures.Value.Count;
                foreach (KeyValuePair<string, List<string>> otherCreatures in data)
                {
                    string otherCreature = otherCreatures.Key;
                    List<string> otherSquadMates = otherCreatures.Value;
                    if (currentSquadMates.Contains(otherCreature) &&
                        otherSquadMates.Contains(currentCreature))
                    {
                        squadMatesCount--;
                    }
                }
                result.Add(currentCreature, squadMatesCount);
            }
            foreach (KeyValuePair<string, int> creature in result.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{creature.Key} : {creature.Value}");
            }
        }
    }
}
