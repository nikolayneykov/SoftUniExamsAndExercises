using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
{
    class CombinationOfNumbersAndTheirSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int totalSum = 0;
            bool passed = false;
            int combinationsCount = 0;

            for (int i = n; i >= 1 && !passed; i--)
            {
                for (int j = 1; j <= m && !passed; j++)
                {
                    combinationsCount++;
                    int product = i * j * 3;
                    totalSum += product;
                    passed = totalSum >= maxSum ? true : false;
                }
            }
            Console.WriteLine($"{combinationsCount} combinations");
            Console.WriteLine(passed? $"Sum: {totalSum} >= {maxSum}":$"Sum: {totalSum}");
        }
    }
}
