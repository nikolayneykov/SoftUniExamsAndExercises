using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.EqualPairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxDiff = 0;

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int value = num1 + num2;
            for (int i = 0; i < n - 1; i++)
            {
                value = num1 + num2;
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                if (value != num1 + num2)
                {
                    int tempDiff = Math.Abs(value - (num1 + num2));
                    maxDiff = tempDiff > maxDiff ? tempDiff : maxDiff;
                }
            }
            Console.WriteLine(maxDiff > 0 ? $"No, maxdiff={maxDiff}" : $"Yes, value={value}");
        }
    }
}
