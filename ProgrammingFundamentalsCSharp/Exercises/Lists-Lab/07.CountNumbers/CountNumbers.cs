using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Dictionary<int, int> countNumbers =
                new Dictionary<int, int>();
            foreach (int number in inputNumbers)
            {
                if (!countNumbers.ContainsKey(number))
                {
                    countNumbers.Add(number, 0);
                }
                countNumbers[number]++;
            }
            foreach (KeyValuePair<int, int> number in countNumbers.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
