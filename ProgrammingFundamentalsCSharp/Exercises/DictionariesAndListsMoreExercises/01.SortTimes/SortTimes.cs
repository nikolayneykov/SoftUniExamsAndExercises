using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _01.SortTimes
{
    class SortTimes
    {
        static void Main(string[] args)
        {
            List<string> times = Console.ReadLine()
                .Split()
                .Select(TimeSpan.Parse)
                .OrderBy(x=>x)
                .Select(x=>x.ToString("hh\\:mm"))
                .ToList();
            Console.WriteLine(string.Join(", ",times));
        } 
    }
}
