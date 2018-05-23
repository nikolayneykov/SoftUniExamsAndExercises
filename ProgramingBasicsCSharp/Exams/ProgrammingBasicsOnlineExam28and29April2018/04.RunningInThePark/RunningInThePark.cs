using System;

namespace _04.RunningInThePark
{
    class RunningInThePark
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalDistance = 0;
            int totalMinutes = 0;
            for (int i = 0; i < n; i++)
            {
                int currentMinutes = int.Parse(Console.ReadLine());
                totalMinutes += currentMinutes;
                double currentDistance = double.Parse(Console.ReadLine());
                string unit = Console.ReadLine();
                totalDistance += unit == "km" ? currentDistance : currentDistance / 1000.0;
            }
            double caloriesBurned = (totalMinutes / 20.0) * 400.0;
            Console.WriteLine($"He ran {totalDistance:F2}km for {totalMinutes} minutes and burned {caloriesBurned} calories.");
        }
    }
}
