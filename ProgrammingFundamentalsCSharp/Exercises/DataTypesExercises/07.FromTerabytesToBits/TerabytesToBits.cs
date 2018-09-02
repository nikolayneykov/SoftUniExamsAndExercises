using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _07.FromTerabytesToBits
{
    class TerabytesToBits
    {
        static void Main(string[] args)
        {
            decimal terabit = decimal.Parse(Console.ReadLine());
            decimal bits = terabit * 8*1024*1024*1024*1024;
            Console.WriteLine($"{bits:F0}");
        }
    }
}
