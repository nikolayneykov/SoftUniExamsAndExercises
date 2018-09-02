using System;
using System.Linq;

namespace _03.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = array.Length / 4;
            int[] lowerRow = new int[2 * k];
            int[] upperRow = new int[2 * k];
            for (int i = k, j = 0; j < upperRow.Length; i++, j++)
            {
                upperRow[j] = array[i];
            }
            for (int i = k - 1, j = 0; j < k; i--, j++)
            {
                lowerRow[j] = array[i];
            }
            for (int i = array.Length - 1, j = k; j < lowerRow.Length; i--, j++)
            {
                lowerRow[j] = array[i];
            }
            int[] sum = new int[2 * k];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = upperRow[i] + lowerRow[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
