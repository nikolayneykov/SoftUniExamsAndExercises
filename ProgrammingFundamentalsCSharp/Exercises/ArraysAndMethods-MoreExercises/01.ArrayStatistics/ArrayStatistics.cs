using System;
using System.Linq;

namespace _01.ArrayStatistics
{
    class ArrayStatistics
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int min = numbers.Min();
            int max = numbers.Max();
            int sum = numbers.Sum();
            double average = numbers.Average();
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
