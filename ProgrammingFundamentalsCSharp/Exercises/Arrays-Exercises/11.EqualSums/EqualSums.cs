using System;
using System.Linq;

namespace _11.EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = i; j >= 0; j--)
                {
                    leftSum += numbers[j];
                }
                for (int j = i; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }
                if (leftSum == rightSum)
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine(index == -1 ? "no" : index.ToString());
        }
    }
}
