using System;
using System.Linq;

namespace _04.GrabAndGo
{
    class GrabAndGo
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long number = long.Parse(Console.ReadLine());
            bool hasOccurrence = false;
            long sum = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (hasOccurrence)
                {
                    sum += numbers[i];
                }
                else if (!hasOccurrence && numbers[i] == number)
                {
                    hasOccurrence = true;
                }
            }
            Console.WriteLine(hasOccurrence ? sum.ToString() : "No occurrences were found!");
        }
    }
}
