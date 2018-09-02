using System;

namespace _12.BeerKegs
{
    class BeerKegs
    {
        static void Main(string[] args)
        {
            string biggestKeg = string.Empty;
            double biggestVolume = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * 2 * height;
                if (volume>biggestVolume)
                {
                    biggestKeg = model;
                    biggestVolume = volume;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
