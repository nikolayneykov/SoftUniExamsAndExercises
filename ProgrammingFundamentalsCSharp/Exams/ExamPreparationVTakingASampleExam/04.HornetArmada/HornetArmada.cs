using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HornetArmada
{
    class HornetArmada
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> lastActivityData =
                new Dictionary<string, long>();
            Dictionary<string, Dictionary<string, long>> soldierData =
                new Dictionary<string, Dictionary<string, long>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputTokens = Console.ReadLine()
                    .Split(new[] { '=', '-', '>', ':', ' ' },
                    StringSplitOptions.RemoveEmptyEntries);
                int lastActivity = int.Parse(inputTokens[0]);
                string legionName = inputTokens[1];
                string soldierType = inputTokens[2];
                int soldierCount = int.Parse(inputTokens[3]);
                if (!lastActivityData.ContainsKey(legionName))
                {
                    lastActivityData.Add(legionName, lastActivity);
                }
                if (lastActivityData[legionName] < lastActivity)
                {
                    lastActivityData[legionName] = lastActivity;
                }
                if (!soldierData.ContainsKey(legionName))
                {
                    soldierData.Add(legionName, new Dictionary<string, long>());
                }
                if (!soldierData[legionName].ContainsKey(soldierType))
                {
                    soldierData[legionName].Add(soldierType, 0);
                }
                soldierData[legionName][soldierType] += soldierCount;
            }
            string[] outputTokens = Console.ReadLine().Split('\\');
            if (outputTokens.Length == 1)
            {
                string soldierType = outputTokens[0];
                lastActivityData = lastActivityData
                    .OrderByDescending(x => x.Value)
                    .ToDictionary(x => x.Key, x => x.Value);
                foreach (KeyValuePair<string, long> legion in lastActivityData)
                {
                    string legionName = legion.Key;
                    long lastActivity = legion.Value;
                    if (soldierData[legionName].Any(x => x.Key == soldierType))
                    {
                        Console.WriteLine($"{lastActivity} : {legionName}");
                    }
                }
            }
            else
            {
                int lastActivity = int.Parse(outputTokens[0]);
                string soldierType = outputTokens[1];

                foreach (KeyValuePair<string, Dictionary<string, long>> legion in soldierData
                    .Where(x => x.Value.ContainsKey(soldierType))
                    .OrderByDescending(x => x.Value[soldierType]))
                {
                    string legionName = legion.Key;
                    if (lastActivityData[legionName] < lastActivity)
                    {
                        long soldierCount = soldierData[legionName][soldierType];
                        Console.WriteLine($"{legionName} -> {soldierCount}");
                    }
                }
            }
        }
    }

}
