using System;
using System.Globalization;
namespace _10.Birthday
{
    class Birthday
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            percent = percent * 0.01;
            double area = lenght * width * hight;
            double litres = area * 0.001;
            Console.WriteLine($"{(litres * (1 - percent)):F3}");
        }
    }
}
