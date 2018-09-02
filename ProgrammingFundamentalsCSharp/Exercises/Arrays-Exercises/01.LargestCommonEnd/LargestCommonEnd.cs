using System;

namespace _01.LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();
            int leftCommonEndCount = 0;
            int rightCommonEndCount = 0;
            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if (arr1[i] != arr2[i])
                {
                    break;
                }
                leftCommonEndCount++;
            }
            for (int i = arr1.Length - 1, j = arr2.Length - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (arr1[i] != arr2[j])
                {
                    break;
                }
                rightCommonEndCount++;
            }
            Console.WriteLine(Math.Max(leftCommonEndCount, rightCommonEndCount));
        }
    }
}
