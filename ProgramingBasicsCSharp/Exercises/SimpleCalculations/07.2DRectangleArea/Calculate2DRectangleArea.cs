using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._2DRectangleArea
{
    class Calculate2DRectangleArea
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double length = Math.Abs(x1 - x2);
            double width = Math.Abs(y1 - y2);

            double area = length * width;
            Console.WriteLine(area);
            double perimeter = length * 2 + width * 2;
            Console.WriteLine(perimeter);
        }
    }
}
