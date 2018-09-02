using System;

namespace _02.CircleAreaPrecision12
{
    class CircleAreaPrecision12
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double circleArea = radius * radius * Math.PI;
            Console.WriteLine($"{circleArea:f12}");
        }
    }
}
