using System;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        int[] rectangleCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Point topLeft = new Point(rectangleCoordinates[0], rectangleCoordinates[1]);
        Point bottomRight = new Point(rectangleCoordinates[2], rectangleCoordinates[3]);
        Rectangle rect = new Rectangle(topLeft, bottomRight);

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int[] pointCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point p = new Point(pointCoordinates[0], pointCoordinates[1]);

            Console.WriteLine(rect.Contains(p) ? "True" : "False");
        }
    }
}