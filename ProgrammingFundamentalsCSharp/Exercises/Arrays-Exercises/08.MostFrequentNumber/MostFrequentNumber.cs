using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int mostFrequentNum = -1;
            int mostFrequentCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int tempCount = 0;
                int currentNum = numbers[i];
                if (currentNum != -1)
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (numbers[j] == currentNum)
                        {
                            tempCount++;
                        }
                    }
                }
                if (tempCount > mostFrequentCount)
                {
                    mostFrequentCount = tempCount;
                    mostFrequentNum = currentNum;
                }
            }
            Console.WriteLine(mostFrequentNum);
        }
    }
}
