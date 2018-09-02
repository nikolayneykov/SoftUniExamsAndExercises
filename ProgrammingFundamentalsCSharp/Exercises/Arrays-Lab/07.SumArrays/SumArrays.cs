using System;
using System.Linq;

namespace _07.SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] result = new int[Math.Max(arr1.Length, arr2.Length)];

            for (int i = 0, j = 0, k = 0; i < result.Length; i++, j++, k++)
            {
                if (j == arr1.Length)
                {
                    j = 0;
                }
                if (k == arr2.Length)
                {
                    k = 0;
                }
                result[i] = arr1[j] + arr2[k];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
