using System;

class WeddingInvestment
{
    static void Main(string[] args)
    {
        string contractTerm = Console.ReadLine();
        string contractType = Console.ReadLine();
        bool hasDesert = Console.ReadLine() == "yes";
        int paymentMonts = int.Parse(Console.ReadLine());
        double price = 0;
        switch (contractTerm)
        {
            case "one":
                switch (contractType)
                {
                    case "Small": price = 9.98; break;
                    case "Middle": price = 18.99; break;
                    case "Large": price = 25.98; break;
                    case "ExtraLarge": price = 35.99; break;
                }
                break;
            case "two":
                switch (contractType)
                {
                    case "Small": price = 8.58; break;
                    case "Middle": price = 17.09; break;
                    case "Large": price = price = 23.59; break;
                    case "ExtraLarge": price = 31.79; break;
                }
                break;
        }

        if (hasDesert)
        {
            price += price <= 10 ? 5.50 : price <= 30 ? 4.35 : 3.85;
        }
        price *= paymentMonts;

        if (contractTerm == "two")
        {
            price *= 0.9625;
        }
        Console.WriteLine($"{price:F2} lv.");
    }
}

