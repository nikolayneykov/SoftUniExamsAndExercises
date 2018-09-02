using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_Styrofoam
{
    class Styrofoam
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double houseArea = double.Parse(Console.ReadLine());
            int windows = int.Parse(Console.ReadLine());
            double styrofoamInPackage = double.Parse(Console.ReadLine());
            double styrofoamPricePerPackage = double.Parse(Console.ReadLine());

            double windowsArea = windows * 2.4;
            houseArea -= windowsArea;
            houseArea += houseArea * 0.1;
            double packageNeed = Math.Ceiling(houseArea / styrofoamInPackage);
            double price = packageNeed * styrofoamPricePerPackage;

            if (price>budget)
            {
                Console.WriteLine("Need more: {0:F2}",price-budget);
            }
            else
            {
                Console.WriteLine("Spent: {0:F2}",price);
                Console.WriteLine("Left: {0:F2}",budget-price);
            }
        }
    }
}
