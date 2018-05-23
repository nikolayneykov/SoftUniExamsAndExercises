using System;

namespace _05.RectangleArea
{
    class CalculateRectangleArea
    {
        static void Main(string[] args)
        {
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            double rectangleArea = side1 * side2;
            Console.WriteLine(rectangleArea);
        }
    }
}
