using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine());
            double profit = 0;

            if (kilometers <= 5000)
            {
                switch (season)
                {
                    case "Spring": profit = 4 * kilometers * 0.75; break;
                    case "Autumn": profit = 4 * kilometers * 0.75; break;
                    case "Summer": profit = 4 * kilometers * 0.9; break;
                    case "Winter": profit = 4 * kilometers * 1.05; break;
                }
            }
            else if (kilometers > 5000 && kilometers <= 10000)
            {
                switch (season)
                {
                    case "Spring": profit = 4 * kilometers * 0.95; break;
                    case "Autumn": profit = 4 * kilometers * 0.95; break;
                    case "Summer": profit = 4 * kilometers * 1.1; break;
                    case "Winter": profit = 4 * kilometers * 1.25; break;
                }
            }
            else
            {
                profit = 4 * kilometers * 1.45;
            }
            profit -= profit * 0.1;
            Console.WriteLine("{0:F2}",profit);
        }
    }
}
