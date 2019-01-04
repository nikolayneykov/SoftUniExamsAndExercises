using System;

class Journey
{
    static void Main(string[] args)
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        string destination = "";
        string vacationType = "";
        decimal price = 0m;

        if (budget <= 100)
        {
            destination = "Bulgaria";
            if (season == "summer")
            {
                vacationType = "Camp";
                price = budget * 0.3m;
            }
            else if (season == "winter")
            {
                vacationType = "Hotel";
                price = budget * 0.7m;
            }
        }
        else if (budget <= 1000)
        {
            destination = "Balkans";
            if (season == "summer")
            {
                vacationType = "Camp";
                price = budget * 0.4m;
            }
            else if (season == "winter")
            {
                vacationType = "Hotel";
                price = budget * 0.8m;
            }
        }
        else if (budget > 1000)
        {
            destination = "Europe";
            vacationType = "Hotel";
            price = budget * 0.9m;
        }

        Console.WriteLine($"Somewhere in {destination}\n{vacationType} - {price:F2}");
    }
}

