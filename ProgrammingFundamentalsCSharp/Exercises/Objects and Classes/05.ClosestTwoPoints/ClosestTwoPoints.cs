using System;
using System.Linq;
namespace _05.ClosestTwoPoints
{
    class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            Point[] points = ReadPoints();
            Point[] closestPoints = FindClosestPoints(points);
            double distance = CalculateDistance(closestPoints[0], closestPoints[1]);
            Console.WriteLine($"{distance:F3}");
            Console.WriteLine($"({closestPoints[0].X}, {closestPoints[0].Y})");
            Console.WriteLine($"({closestPoints[1].X}, {closestPoints[1].Y})");
        }
        static double CalculateDistance(Point p1, Point p2)
        {
            double deltaX = Math.Abs(p1.X - p2.X);
            double deltaY = Math.Abs(p1.Y - p2.Y);
            return Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
        }
        static Point[] FindClosestPoints(Point[] points)
        {
            Point[] closestPoints = new Point[2];
            double shortestDistance = double.MaxValue;
            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double currentDistance = CalculateDistance(points[i], points[j]);
                    if (currentDistance<shortestDistance)
                    {
                        closestPoints[0] = points[i];
                        closestPoints[1] = points[j];
                        shortestDistance = currentDistance;
                    }
                }
            }
            return closestPoints;
        }
        static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            for (int i = 0; i < points.Length; i++)
            {
                double[] coordinates = Console.ReadLine().Split().Select(double.Parse).ToArray();

                points[i] = new Point(coordinates[0], coordinates[1]);
            }
            return points;
        }
    }
    class Point
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
