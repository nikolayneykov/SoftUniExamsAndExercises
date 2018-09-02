using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .OrderBy(x => x)
                .ToList();
            Console.WriteLine(string.Join(" <= ",numbers));
        }
    }
}
