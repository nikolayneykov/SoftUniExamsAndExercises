using System;
using System.Linq;

namespace _02.RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotationCount = int.Parse(Console.ReadLine());
            int[] sumArrays = new int[array.Length];
            for (int i = 0; i < rotationCount; i++)
            {
                int lastElement = array[array.Length - 1];
                for (int j = array.Length - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = lastElement;
                for (int j = 0; j < sumArrays.Length; j++)
                {
                    sumArrays[j] += array[j];
                }
            }
            Console.WriteLine(string.Join(" ", sumArrays));
        }
    }
}
