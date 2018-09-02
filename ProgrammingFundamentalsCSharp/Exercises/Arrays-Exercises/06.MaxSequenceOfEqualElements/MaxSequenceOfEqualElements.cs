using System;
using System.Linq;

namespace _06.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startIndex = 0;
            int sequenceLength = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int tempStartIndex = i;
                int tempLength = 0;
                while (i < array.Length - 1 && array[i] == array[i + 1])
                {
                    tempLength++;
                    i++;
                }
                if (tempLength > sequenceLength)
                {
                    startIndex = tempStartIndex;
                    sequenceLength = tempLength;
                }
            }
            for (int i = startIndex; i <= startIndex + sequenceLength; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
