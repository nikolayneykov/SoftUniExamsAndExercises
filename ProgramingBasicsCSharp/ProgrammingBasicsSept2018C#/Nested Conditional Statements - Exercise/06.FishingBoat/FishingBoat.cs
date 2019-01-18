using System;

class FishingBoat
{
    static void Main(string[] args)
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        int fishermanCount = int.Parse(Console.ReadLine());
        decimal price = 0;
        switch (season)
        {
            case "Spring": price = 3000.00m; break;
            case "Summer": price = 4200.00m; break;
            case "Autumn": price = 4200.00m; break;
            case "Winter": price = 2600.00m; break;
        }

        price *= fishermanCount <= 6 ? 0.9m : fishermanCount <= 11 ? 0.85m : 0.75m;
        price *= (fishermanCount % 2 == 0 && season != "Autumn") ? 0.95m : 1;

        Console.WriteLine(budget >= price ?
            $"Yes! You have {budget - price:F2} leva left." :
            $"Not enough money! You need {price - budget:F2} leva.");
    }
}