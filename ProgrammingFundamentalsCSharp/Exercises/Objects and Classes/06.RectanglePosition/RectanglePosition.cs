using System;
using System.Linq;

namespace _06.RectanglePosition
{
    class RectanglePosition
    {
        static void Main(string[] args)
        {
            Rectangle r1 = ReadRectangle();
            Rectangle r2 = ReadRectangle();
            IsInside(r1, r2);
        }
        static void IsInside(Rectangle r1, Rectangle r2)
        {
            bool inside =
                    r1.Left >= r2.Left &&
                    r1.Right <= r2.Right &&
                    r1.Top <= r2.Top &&
                    r1.Bottom <= r2.Bottom;
            Console.WriteLine(inside ? "Inside" : "Not inside");
        }
        static Rectangle ReadRectangle()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            return new Rectangle()
            {
                Left = input[0],
                Top = input[1],
                Width = input[2],
                Height = input[3]
            };
        }
    }
    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Bottom { get { return Top + Height; } }
        public int Right { get{ return Left + Width; } }
    }
}
