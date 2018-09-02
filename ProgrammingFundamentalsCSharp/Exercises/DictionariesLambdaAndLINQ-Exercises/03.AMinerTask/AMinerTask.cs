using System;
using System.Collections.Generic;

namespace _03.AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources =
                new Dictionary<string, int>();
            string resource = string.Empty;
            string quantity = string.Empty;
            while ((resource = Console.ReadLine()) != "stop" &&
                   (quantity = Console.ReadLine()) != "stop")
            {
                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, 0);
                }
                resources[resource] += int.Parse(quantity);
            }
            foreach (KeyValuePair<string,int> item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
