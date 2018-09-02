using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_DogHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double sideWallsArea = 2 * (a * (a / 2));
            double backWallArea = ((a / 2) * (a / 2)) + (((a / 2) * (b-a / 2)) / 2);
            double frontWallArea = backWallArea - ((a / 5) * (a / 5));
            double wallsArea = sideWallsArea + backWallArea + frontWallArea;

            double roofArea = 2 * ((a / 2) * a);

            double greenPaint = wallsArea / 3;
            double redPaint = roofArea / 5;

            Console.WriteLine("{0:F2}",greenPaint);
            Console.WriteLine("{0:F2}", redPaint);
        }
    }
}
