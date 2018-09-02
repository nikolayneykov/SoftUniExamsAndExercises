using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RainAir
{
    class RainAir
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> customerData =
                new Dictionary<string, List<int>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "I believe I can fly!")
            {
                string[] inputTokens = input.Split(new char[] { ' ', '=' },
                    StringSplitOptions.RemoveEmptyEntries);
                string customer = inputTokens[0];
                if (customerData.ContainsKey(inputTokens[1]))
                {
                    string customer2 = inputTokens[1];
                    customerData[customer] = new List<int>(customerData[customer2]);
                }
                else
                {
                    List<int> flights = inputTokens.Skip(1).Select(int.Parse).ToList();
                    if (!customerData.ContainsKey(customer))
                    {
                        customerData.Add(customer, new List<int>());
                    }
                    customerData[customer].AddRange(flights);
                }
            }
            customerData = customerData
                .OrderByDescending(f => f.Value.Count)
                .ThenBy(c => c.Key)
                .ToDictionary(c => c.Key, c => c.Value
                   .OrderBy(f => f).ToList());
            foreach (KeyValuePair<string, List<int>> customer in customerData)
            {
                Console.WriteLine($"#{customer.Key} ::: " + string.Join(", ", customer.Value));
            }
        }
    }
}
