using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x >= 0)
                .Reverse()
                .ToList();
            Console.WriteLine(numbers.Count > 0 ? string.Join(" ", numbers) : "empty");
        }
    }
}
