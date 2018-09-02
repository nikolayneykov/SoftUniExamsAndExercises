using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            int sum = Console.ReadLine()
                .Split()
                .Select(x => string.Join("", x.Reverse()))
                .Select(int.Parse)
                .Sum();
            Console.WriteLine(sum);
        }
    }
}
