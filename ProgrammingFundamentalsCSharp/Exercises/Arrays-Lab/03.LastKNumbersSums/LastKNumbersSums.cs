using System;

namespace _03.LastKNumbersSums
{
    class LastKNumbersSums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] array = new long[n];
            array[0] = 1;
            for (int i = 1; i < array.Length; i++)
            {
                long nextElement = 0;
                for (int j = i - 1; j >= Math.Max(0, i - k); j--)
                {
                    nextElement += array[j];
                }
                array[i] = nextElement;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
