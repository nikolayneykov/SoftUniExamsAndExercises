using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wormtest
{
    class Wormtest
    {
        static void Main(string[] args)
        {
            int wormLength = int.Parse(Console.ReadLine()) * 100;
            double wormWidth = double.Parse(Console.ReadLine());
            bool canCalculate = wormLength % wormWidth > 0;
            if (canCalculate)
            {
                double percent = (wormLength / wormWidth) * 100;
                Console.WriteLine($"{percent:F2}%");
            }
            else
            {
                double product = wormLength * wormWidth;
                Console.WriteLine($"{product:F2}");
            }
        }
    }
}
