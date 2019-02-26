using System;

class StartUp
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        decimal price = decimal.Parse(input[0]);
        int numberOfDays = int.Parse(input[1]);
        Season season = (Season)Enum.Parse(typeof(Season), input[2]);
        Discount discount = Discount.None;

        if (input.Length == 4)
        {
            discount = (Discount)Enum.Parse(typeof(Discount), input[3]);
        }

        PriceCalculator calculator = new PriceCalculator();
        Console.WriteLine($"{calculator.CalculatePrice(price, numberOfDays, season, discount):F2}");

    }
}

