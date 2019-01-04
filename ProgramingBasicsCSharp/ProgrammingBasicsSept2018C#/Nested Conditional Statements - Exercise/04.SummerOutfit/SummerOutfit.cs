using System;

class SummerOutfit
{
    static void Main(string[] args)
    {
        int temperature = int.Parse(Console.ReadLine());
        string partOfTheDay = Console.ReadLine();
        string outfit = string.Empty;
        string shoes = string.Empty;

        switch (partOfTheDay)
        {
            case "Morning":
                if (temperature >= 10 && temperature <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (temperature > 18 && temperature <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temperature > 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                break;
            case "Afternoon":
                if (temperature >= 10 && temperature <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temperature > 18 && temperature <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (temperature > 24)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                break;
            case "Evening":
                outfit = "Shirt";
                shoes = "Moccasins";
                break;
        }
        Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
    }
}

