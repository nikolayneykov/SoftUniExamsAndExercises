using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> loot =
                new Dictionary<string, int>()
                {
                    ["shards"] = 0,
                    ["fragments"] = 0,
                    ["motes"] = 0
                };
            bool farming = true;
            while (farming)
            {
                string[] tokens = Console.ReadLine().ToLower().Split();
                for (int i = 0; i < tokens.Length; i += 2)
                {
                    int quantity = int.Parse(tokens[i]);
                    string item = tokens[i+1];
                    if (!loot.ContainsKey(item))
                    {
                        loot.Add(item, 0);
                    }
                    loot[item] += quantity;
                    if ((item == "shards" || item == "fragments" || item == "motes") &&
                        loot[item] >= 250)
                    {
                        switch (item)
                        {
                            case "shards": Console.WriteLine("Shadowmourne obtained!"); break;
                            case "fragments": Console.WriteLine("Valanyr obtained!"); break;
                            case "motes": Console.WriteLine("Dragonwrath obtained!"); break;
                        }
                        loot[item] -= 250;
                        foreach (KeyValuePair<string,int> keyMaterial in loot
                            .Where(x=>x.Key=="shards"||x.Key=="fragments"||x.Key=="motes")
                            .OrderByDescending(x=>x.Value)
                            .ThenBy(x=>x.Key))
                        {
                            Console.WriteLine($"{keyMaterial.Key}: {keyMaterial.Value}");
                        }
                        loot.Remove("shards");
                        loot.Remove("fragments");
                        loot.Remove("motes");
                        farming = false;
                        break;
                    }
                }
            }
            foreach (var item in loot.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
