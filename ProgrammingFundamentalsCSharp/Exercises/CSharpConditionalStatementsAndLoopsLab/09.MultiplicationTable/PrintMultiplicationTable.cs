using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MultiplicationTable
{
    class PrintMultiplicationTable
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int multiplier = 1; multiplier <= 10; multiplier++)
            {
                int product = number * multiplier;
                Console.WriteLine($"{number} X {multiplier} = {product}");
            }
        }
    }
}
