using System;

namespace _02.NumberChecker
{
    class NumberChecker
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.Contains("."))
            {
                Console.WriteLine("floating-point");
            }
            else
            {
                Console.WriteLine("integer");
            }
        }
    }
}
