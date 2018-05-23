using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < n*2; i++)
            {
                int number = int.Parse(Console.ReadLine());
                leftSum += i < n ? number : 0;
                rightSum += i >= n ? number : 0;
            }
            Console.WriteLine(leftSum==rightSum?
                $"Yes, sum = {leftSum}":$"No, diff = {Math.Abs(leftSum-rightSum)}");
        }
    }
}
