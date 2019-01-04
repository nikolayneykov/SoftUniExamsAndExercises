using System;

class WeddingTime
{
    static void Main(string[] args)
    {
        double whiskeyPricePerLiter = double.Parse(Console.ReadLine());
        double waterQuantity = double.Parse(Console.ReadLine());
        double wineQuantity = double.Parse(Console.ReadLine());
        double champaignQuantity = double.Parse(Console.ReadLine());
        double whiskeyQuantity = double.Parse(Console.ReadLine());

        double champaignPricePerLiter = whiskeyPricePerLiter * 0.5;
        double winePricePerLiter = champaignPricePerLiter * 0.4;
        double waterPricePerLiter = champaignPricePerLiter * 0.1;

        double totalPrice = (whiskeyPricePerLiter * whiskeyQuantity) +
                            (champaignPricePerLiter * champaignQuantity) +
                            (winePricePerLiter * wineQuantity) +
                            (waterPricePerLiter * waterQuantity);

        Console.WriteLine($"{totalPrice:F2}");
    }
}

