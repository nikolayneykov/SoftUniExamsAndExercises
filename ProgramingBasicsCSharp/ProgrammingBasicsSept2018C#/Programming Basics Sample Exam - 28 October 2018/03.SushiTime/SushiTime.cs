using System;

class SushiTime
{
    static void Main(string[] args)
    {
        string sushiType = Console.ReadLine();
        string restourantName = Console.ReadLine();
        double portions = double.Parse(Console.ReadLine());
        char order = char.Parse(Console.ReadLine());

        double sushiPrice = 0;
        switch (restourantName)
        {
            case "Sushi Zone":
                switch (sushiType)
                {
                    case "sashimi": sushiPrice = 4.99; break;
                    case "maki": sushiPrice = 5.29; break;
                    case "uramaki": sushiPrice = 5.99; break;
                    case "temaki": sushiPrice = 4.29; break;
                }
                break;
            case "Sushi Time":
                switch (sushiType)
                {
                    case "sashimi": sushiPrice = 5.49; break;
                    case "maki": sushiPrice = 4.69; break;
                    case "uramaki": sushiPrice = 4.49; break;
                    case "temaki": sushiPrice = 5.19; break;
                }
                break;
            case "Sushi Bar":
                switch (sushiType)
                {
                    case "sashimi": sushiPrice = 5.25; break;
                    case "maki": sushiPrice = 5.55; break;
                    case "uramaki": sushiPrice = 6.25; break;
                    case "temaki": sushiPrice = 4.75; break;
                }
                break;
            case "Asian Pub":
                switch (sushiType)
                {
                    case "sashimi": sushiPrice = 4.50; break;
                    case "maki": sushiPrice = 4.80; break;
                    case "uramaki": sushiPrice = 5.50; break;
                    case "temaki": sushiPrice = 5.50; break;
                }
                break;
        }
        double totalPrice = sushiPrice * portions;
        totalPrice *= order == 'Y' ? 1.2 : 1;
        Console.WriteLine(totalPrice > 0 ?
            $"Total price: {Math.Ceiling(totalPrice)} lv." :
            $"{restourantName} is invalid restaurant!");
    }
}

