using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumOfOddNumbers
{
    class CalculateSumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0, oddNum = 1; i < n; i++, oddNum += 2)
            {
                Console.WriteLine(oddNum);
                sum += oddNum;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
