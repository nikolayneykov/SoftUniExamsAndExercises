using System;
using System.Linq;

namespace _03.CirclesIntersection
{
    class CirclesIntersection
    {
        static void Main(string[] args)
        {
            Circle firstCircle = ReadCircle();
            Circle secondCircle = ReadCircle();
            double distance = CalculateDistance(firstCircle, secondCircle);
            bool hasIntersection = distance <= firstCircle.Radius + secondCircle.Radius;
            Console.WriteLine(hasIntersection ? "Yes" : "No");
        }
        static double CalculateDistance(Circle c1, Circle c2)
        {
            double deltaX = c1.Center.X - c2.Center.X;
            double deltaY = c1.Center.Y - c2.Center.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
        static Circle ReadCircle()
        {
            double[] coordinates = Console.ReadLine().Split().Select(double.Parse).ToArray();
            return new Circle()
            {
                Center = new Point()
                {
                    X = coordinates[0],
                    Y = coordinates[1]
                },
                Radius = coordinates[2]
            };
        }
    }
    class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }
    }
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
