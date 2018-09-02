using System;
using System.Linq;

namespace _02.EmailMe
{
    class EmailMe
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('@');
            int firstSum = input[0].Sum(x => x);
            int secondSum = input[1].Sum(x => x);
            int result = firstSum - secondSum;
            Console.WriteLine(result >= 0 ? "Call her!" : "She is not the one.");
        }
    }
}
