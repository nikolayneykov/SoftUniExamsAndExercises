using System;

class NewHouse
{
    static void Main(string[] args)
    {
        string flourType = Console.ReadLine();
        int flourCount = int.Parse(Console.ReadLine());
        decimal budget = decimal.Parse(Console.ReadLine());
        decimal totalPrice = 0;

        switch (flourType)
        {
            case "Roses":
                totalPrice = flourCount > 80 ? 5.00m * flourCount * 0.90m : 5.0m * flourCount;
                break;
            case "Dahlias":
                totalPrice = flourCount > 90 ? 3.80m * flourCount * 0.85m : 3.80m * flourCount;
                break;
            case "Tulips":
                totalPrice = flourCount > 80 ? 2.80m * flourCount * 0.85m : 2.80m * flourCount;
                break;
            case "Narcissus":
                totalPrice = flourCount < 120 ? 3.00m * flourCount * 1.15m : 3.00m * flourCount;
                break;
            case "Gladiolus":
                totalPrice = flourCount < 80 ? 2.50m * flourCount * 1.20m : 2.50m * flourCount;
                break;
        }
        Console.WriteLine(budget >= totalPrice ?
            $"Hey, you have a great garden with {flourCount} {flourType} and {budget - totalPrice:F2} leva left." :
            $"Not enough money, you need {totalPrice - budget:F2} leva more.");
    }
}

