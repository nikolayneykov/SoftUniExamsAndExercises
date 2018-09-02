using System;
using System.Linq;

namespace _05.RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            foreach (double number in array)
            {
                double rounded = Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{number} => {rounded}");
            }
        }
    }
}
