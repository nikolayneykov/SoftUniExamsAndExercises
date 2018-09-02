using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Resurrection
{
    class Resurrection
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                decimal bodyLength = decimal.Parse(Console.ReadLine());
                decimal bodyWidth = decimal.Parse(Console.ReadLine());
                decimal wingLength = decimal.Parse(Console.ReadLine());
                decimal totalYears = (bodyLength * bodyLength) * (bodyWidth + 2 * wingLength);
                Console.WriteLine(totalYears);
            }
        }
    }
}
