using System;
using System.Linq;

namespace _10.PairsByDifference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int pairsCount = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i+1; j <numbers.Length ; j++)
                {
                    if (Math.Abs(numbers[i]-numbers[j])==difference)
                    {
                        pairsCount++;
                    }
                }
            }
            Console.WriteLine(pairsCount);
        }
    }
}
