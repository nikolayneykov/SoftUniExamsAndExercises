using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine()
                 .Split(new[] { ' '},
                 StringSplitOptions.RemoveEmptyEntries)
                 .Select(decimal.Parse)
                 .ToList();
            bool hasEqualNeighbours = true;
            while (hasEqualNeighbours)
            {
                hasEqualNeighbours = false;
                
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        numbers[i] += numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                        hasEqualNeighbours = true;
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
