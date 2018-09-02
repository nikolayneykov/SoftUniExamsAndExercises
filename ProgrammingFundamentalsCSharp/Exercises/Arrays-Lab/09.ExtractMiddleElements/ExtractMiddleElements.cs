using System;
using System.Linq;

namespace _09.ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int midIndex = array.Length / 2 - 1;

            if (array.Length == 1)
            {
                Console.WriteLine($"{{ {array[0]} }}");
            }
            else if (array.Length % 2 == 0)
            {
                Console.WriteLine($"{{ {array[midIndex]},{array[midIndex + 1]} }}");
            }
            else
            {
                Console.WriteLine($"{{ {array[midIndex]},{array[midIndex + 1]},{array[midIndex + 2]} }}");
            }
        }
    }
}
