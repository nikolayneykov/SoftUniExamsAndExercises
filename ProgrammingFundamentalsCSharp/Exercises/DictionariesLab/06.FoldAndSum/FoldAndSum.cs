using System;
using System.Linq;
namespace _06.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arr.Length / 4;
            int[] left = arr.Take(k).Reverse().ToArray();
            int[] right = arr.Skip(3 * k).Take(k).Reverse().ToArray();
            int[] row1 = left.Concat(right).ToArray();
            int[] row2 = arr.Skip(k).Take(2 * k).ToArray();
            int[] result = row1.Select((x, index) => x + row2[index]).ToArray();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
