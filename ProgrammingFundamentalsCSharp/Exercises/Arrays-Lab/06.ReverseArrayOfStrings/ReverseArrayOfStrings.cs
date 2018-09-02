using System;

namespace _06.ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            int leftIndex = 0;
            int rightIndex = array.Length - 1;
            while (leftIndex<rightIndex)
            {
                string temp = array[leftIndex];
                array[leftIndex] = array[rightIndex];
                array[rightIndex] = temp;
                leftIndex++;
                rightIndex--;
            }
            Console.WriteLine(string.Join(" ",array));
        }
    }
}
