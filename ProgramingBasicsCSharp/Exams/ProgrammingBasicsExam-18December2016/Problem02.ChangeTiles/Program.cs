using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02.ChangeTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorLength = double.Parse(Console.ReadLine());
            double tileSide = double.Parse(Console.ReadLine());
            double tileHeight = double.Parse(Console.ReadLine());
            double pricePerTile = double.Parse(Console.ReadLine());
            double priceForWork = double.Parse(Console.ReadLine());

            double floorArea = floorWidth * floorLength;
            double tileArea = (tileSide * tileHeight)/2;
            double tileNeed = Math.Ceiling(floorArea / tileArea) + 5;

            double totalSum = (tileNeed * pricePerTile) + priceForWork;
            if (totalSum>savings)
            {
                Console.WriteLine("You'll need {0:F2} lv more.",totalSum-savings);
            }
            else
            {
                Console.WriteLine("{0:F2} lv left. ", savings-totalSum);
            }
        }
    }
}
