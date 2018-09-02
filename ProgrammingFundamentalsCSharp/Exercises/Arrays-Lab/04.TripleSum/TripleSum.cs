using System;
using System.Linq;

namespace _04.TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();
            bool hasTripleElements = false;

            for (int i = 0; i < array.Length-1; i++)
            {
                long a = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    long b = array[j];
                    if (array.Contains(a+b))
                    {
                        Console.WriteLine($"{a} + {b} == {a+b}");
                        hasTripleElements = true;
                    }
                }
            }
            if (!hasTripleElements)
            {
                Console.WriteLine("No");
            }
        }
    }
}
