using System;

class ThreeBrothers
{
    static void Main(string[] args)
    {
        double cleaningTimeA = double.Parse(Console.ReadLine());
        double cleaningTimeB = double.Parse(Console.ReadLine());
        double cleaningTimeC = double.Parse(Console.ReadLine());
        double fishingTime = double.Parse(Console.ReadLine());

        double totalCleaningTime = 1 / (1 / cleaningTimeA + 1 / cleaningTimeB + 1 / cleaningTimeC);
        totalCleaningTime *= 1.15;
        Console.WriteLine($"Cleaning time: {totalCleaningTime:F2}");
        Console.WriteLine(totalCleaningTime <= fishingTime ?
            $"Yes, there is a surprise - time left -> {Math.Floor(fishingTime-totalCleaningTime)} hours." :
            $"No, there isn't a surprise - shortage of time -> {Math.Ceiling(totalCleaningTime-fishingTime)} hours.");
    }
}

