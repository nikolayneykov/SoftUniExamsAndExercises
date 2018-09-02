using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.DragonArmy
{
    class DragonArmy
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int[]>> dragonData =
                new Dictionary<string, Dictionary<string, int[]>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string type = tokens[0];
                string name = tokens[1];

                if (!dragonData.ContainsKey(type))
                {
                    dragonData.Add(type, new Dictionary<string, int[]>());
                }
                if (!dragonData[type].ContainsKey(name))
                {
                    dragonData[type].Add(name, new int[] { 45, 250, 10 });
                }
                else
                {
                    dragonData[type][name] = new int[] { 45, 250, 10 };
                }
                if (tokens[2] != "null")
                {
                    dragonData[type][name][0] = int.Parse(tokens[2]);
                }
                if (tokens[3] != "null")
                {
                    dragonData[type][name][1] = int.Parse(tokens[3]);
                }
                if (tokens[4] != "null")
                {
                    dragonData[type][name][2] = int.Parse(tokens[4]);
                }
            }

            foreach (var type in dragonData)
            {
                double averageDamage = type.Value.Values.Sum(x => x[0]) / (double)type.Value.Count();
                double averageHealth = type.Value.Values.Sum(x => x[1]) / (double)type.Value.Count();
                double averageArmor = type.Value.Values.Sum(x => x[2]) / (double)type.Value.Count();
                Console.WriteLine($"{type.Key}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2})");
                foreach (var dragon in type.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}
