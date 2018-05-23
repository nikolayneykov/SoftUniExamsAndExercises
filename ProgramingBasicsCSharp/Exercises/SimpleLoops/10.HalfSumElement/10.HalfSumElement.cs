using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int biggestElement = int.MinValue;
            int totalSum = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                biggestElement = number > biggestElement ? number : biggestElement;
                totalSum += number;
            }
            totalSum -= biggestElement;
            Console.WriteLine(totalSum==biggestElement?
                $"Yes\nSum = {totalSum}":
                $"No\nDiff = {Math.Abs(totalSum-biggestElement)}");
        }
    }
}
