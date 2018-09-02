using System;
using System.Linq;

namespace _04.DistancebetweenPoints
{
    class DistancebetweenPoints
    {
        static void Main(string[] args)
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();
            double distance = CalculateDistance(p1, p2);
            Console.WriteLine($"{distance:F3}");
        }
        static double CalculateDistance(Point p1, Point p2)
        {
            double deltaX = Math.Abs(p1.X - p2.X);
            double deltaY = Math.Abs(p1.Y - p2.Y);
            return Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
        }
        static Point ReadPoint()
        {
            double[] coordinates = Console.ReadLine().Split().Select(double.Parse).ToArray();
            return new Point(coordinates[0], coordinates[1]);
        }
    }
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
