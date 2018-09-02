using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double wallsHeight = double.Parse(Console.ReadLine());
            double sideWallLength = double.Parse(Console.ReadLine());
            double roofHeight = double.Parse(Console.ReadLine());

            double backWallArea = wallsHeight * wallsHeight;
            double frontWallArea = backWallArea - 1.2 * 2;
            double sideWallsArea = 2 * (wallsHeight * sideWallLength - 1.5 * 1.5);
            double totalWallsArea = backWallArea + frontWallArea + sideWallsArea;

            double roofSideArea = 2*wallsHeight * sideWallLength;
            double roofFrontAndBackArea = roofHeight * wallsHeight;
            double totalRoofArea = roofSideArea + roofFrontAndBackArea;

            Console.WriteLine("{0:F2}",totalWallsArea/3.4);
            Console.WriteLine("{0:F2}",totalRoofArea/4.3);

        }
    }
}
