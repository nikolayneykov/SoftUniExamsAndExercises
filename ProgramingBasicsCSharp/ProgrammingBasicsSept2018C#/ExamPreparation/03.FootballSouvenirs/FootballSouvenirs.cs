using System;

class FootballSouvenirs
{
    static void Main(string[] args)
    {
        string country = Console.ReadLine();
        string souvenir = Console.ReadLine();
        int souvenirCount = int.Parse(Console.ReadLine());
        double souvenirPrice = 0;
        bool validCountry = true;
        bool validStock = true;
        switch (country)
        {
            case "Argentina":
                switch (souvenir)
                {
                    case "flags": souvenirPrice = 3.25; break;
                    case "caps": souvenirPrice = 7.20; break;
                    case "posters": souvenirPrice = 5.10; break;
                    case "stickers": souvenirPrice = 1.25; break;
                    default: validStock = false; break;
                }
                break;
            case "Brazil":
                switch (souvenir)
                {
                    case "flags": souvenirPrice = 4.20; break;
                    case "caps": souvenirPrice = 8.50; break;
                    case "posters": souvenirPrice = 5.35; break;
                    case "stickers": souvenirPrice = 1.20; break;
                    default: validStock = false; break;
                }
                break;
            case "Croatia":
                switch (souvenir)
                {
                    case "flags": souvenirPrice = 2.75; break;
                    case "caps": souvenirPrice = 6.90; break;
                    case "posters": souvenirPrice = 4.95; break;
                    case "stickers": souvenirPrice = 1.10; break;
                    default: validStock = false; break;
                }
                break;
            case "Denmark":
                switch (souvenir)
                {
                    case "flags": souvenirPrice = 3.10; break;
                    case "caps": souvenirPrice = 6.50; break;
                    case "posters": souvenirPrice = 4.80; break;
                    case "stickers": souvenirPrice = 0.90; break;
                    default: validStock = false; break;
                }
                break;
            default: validCountry = false; break;
        }
        string result = string.Empty;
        if (!validCountry)
        {
            result = "Invalid country!";
        }
        else if (!validStock)
        {
            result = "Invalid stock!";
        }
        else
        {
            result = $"Pepi bought {souvenirCount} {souvenir} of {country} for {souvenirCount * souvenirPrice:F2} lv.";
        }
        Console.WriteLine(result);
    }
}

