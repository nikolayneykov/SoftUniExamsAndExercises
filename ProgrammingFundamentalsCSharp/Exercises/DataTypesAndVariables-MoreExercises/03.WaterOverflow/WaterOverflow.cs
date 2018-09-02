using System;

namespace _03.WaterOverflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            int litersInTank = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int waterToPour = int.Parse(Console.ReadLine());
                if (waterToPour+litersInTank>255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    litersInTank += waterToPour;
                }
            }
            Console.WriteLine(litersInTank);
        }
    }
}
