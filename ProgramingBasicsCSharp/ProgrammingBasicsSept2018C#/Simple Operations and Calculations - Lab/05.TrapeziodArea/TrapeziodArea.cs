using System;

namespace _05.TrapeziodArea
{
    class TrapeziodArea
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine((b1 + b2) * h / 2);
        }
    }
}
