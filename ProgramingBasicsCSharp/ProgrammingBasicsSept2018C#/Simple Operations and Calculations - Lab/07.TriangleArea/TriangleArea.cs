using System;

namespace _07.TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            double triangleSide = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double triangleArea = (triangleSide * triangleHeight) / 2;
            triangleArea = Math.Round(triangleArea, 2);
            Console.WriteLine(triangleArea);
        }
    }
}
