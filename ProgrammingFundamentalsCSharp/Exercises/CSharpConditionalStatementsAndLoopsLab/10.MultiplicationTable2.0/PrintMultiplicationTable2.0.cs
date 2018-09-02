using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.MultiplicationTable2._0
{
    class PrintMultiplicationTable
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            do
            {
                int product = number * multiplier;
                Console.WriteLine($"{number} X {multiplier} = {product}");
                multiplier++;
            } while (multiplier <= 10);
        }
    }
}
