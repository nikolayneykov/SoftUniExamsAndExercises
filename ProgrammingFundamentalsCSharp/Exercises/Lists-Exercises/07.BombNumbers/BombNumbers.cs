using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int[] bombTokens = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int specialNumber = bombTokens[0];
            int power = bombTokens[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specialNumber)
                {
                    int startIndex = Math.Max(0, i - power);
                    int endIndex = Math.Min(numbers.Count-1,i+power);
                    for (int j = startIndex; j <= endIndex; j++)
                    {
                        numbers[j] = 0;
                    }                 
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
