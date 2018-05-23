using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CircleAreaAndPerimeter
{
    class CalculateCircleAreaAndPerimeter
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Area = {area}");
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine($"Perimeter {perimeter}");
        }
    }
}
