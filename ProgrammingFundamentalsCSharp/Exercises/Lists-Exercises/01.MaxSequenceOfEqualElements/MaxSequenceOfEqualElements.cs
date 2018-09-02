using System;
using System.Linq;

namespace _01.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int number = 0;
            int count = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int tempNumber = numbers[i];
                int tempCount = 1;

                while (i < numbers.Length - 1 && tempNumber == numbers[i + 1])
                {
                    tempCount++;
                    i++;
                }
                if (count < tempCount)
                {
                    number = tempNumber;
                    count = tempCount;
                }
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
