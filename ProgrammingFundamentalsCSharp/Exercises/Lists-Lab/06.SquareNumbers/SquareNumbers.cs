using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> squareNubmers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .Where(x => Math.Sqrt(x) == (int)Math.Sqrt(x))
                 .OrderByDescending(x=>x)
                 .ToList();
            Console.WriteLine(string.Join(" ",squareNubmers));
        }
    }
}
