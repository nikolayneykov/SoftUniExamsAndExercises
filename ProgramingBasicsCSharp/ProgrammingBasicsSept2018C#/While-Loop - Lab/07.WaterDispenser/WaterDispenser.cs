using System;

class WaterDispenser
{
    static void Main(string[] args)
    {
        int cupVolume = int.Parse(Console.ReadLine());
        int filledVolume = 0;
        int tappedCount = 0;
        while (filledVolume < cupVolume)
        {
            string button = Console.ReadLine();
            switch (button)
            {
                case "Easy": filledVolume += 50; break;
                case "Medium": filledVolume += 100; break;
                case "Hard": filledVolume += 200; break;
            }
            tappedCount++;
        }
        Console.WriteLine(filledVolume == cupVolume ?
            $"The dispenser has been tapped {tappedCount} times." :
            $"{filledVolume - cupVolume}ml has been spilled.");
    }
}

