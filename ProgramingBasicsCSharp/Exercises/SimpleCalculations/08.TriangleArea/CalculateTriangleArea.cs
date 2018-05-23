using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TriangleArea
{
    class CalculateTriangleArea
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
