using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Raindrops
{
    class Raindrops
    {
        static void Main(string[] args)
        {
            int amountOfRegions = int.Parse(Console.ReadLine());
            decimal density = decimal.Parse(Console.ReadLine());
            decimal regionalCoefficients = 0M;
            for (int i = 0; i < amountOfRegions; i++)
            {
                string[] inputTokens = Console.ReadLine().Split();
                long raindropsCount = long.Parse(inputTokens[0]);
                int squareMeters = int.Parse(inputTokens[1]);
                regionalCoefficients += raindropsCount / (decimal)squareMeters;
            }
            if (density!=0)
            {
                regionalCoefficients /= density;
            }
            Console.WriteLine($"{regionalCoefficients:F3}");
        }
    }
}
