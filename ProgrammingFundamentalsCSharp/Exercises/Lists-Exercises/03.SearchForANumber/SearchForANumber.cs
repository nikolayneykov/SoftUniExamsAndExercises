using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SearchForANumber
{
    class SearchForANumber
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int[] manipulationNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool result = numbers
                .Take(manipulationNumbers[0])
                .Skip(manipulationNumbers[1])
                .Contains(manipulationNumbers[2]);
            Console.WriteLine(result?"YES!":"NO!");
        }
    }
}
