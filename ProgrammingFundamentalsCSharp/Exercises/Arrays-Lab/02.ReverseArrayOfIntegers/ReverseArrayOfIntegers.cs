using System;

namespace _02.ReverseArrayOfIntegers
{
    class ReverseArrayOfIntegers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = array.Length-1; i >=0 ; i--)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",array));
        }
    }
}
