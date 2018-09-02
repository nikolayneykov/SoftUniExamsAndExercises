using System;
using System.Linq;

namespace _09.JumpAround
{
    class JumpAround
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int collectedSum = 0;
            int index = 0;
            while (true)
            {
                collectedSum += array[index];
                if (array[index]+index<=array.Length-1)
                {
                    index += array[index];
                }
                else if (index-array[index]>=0)
                {
                    index -= array[index];
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(collectedSum);
        }
    }
}
