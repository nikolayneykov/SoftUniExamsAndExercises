using System;

class BeerAndChips
{
    static void Main(string[] args)
    {
        string fanName = Console.ReadLine();
        decimal budget = decimal.Parse(Console.ReadLine());
        int beerCount = int.Parse(Console.ReadLine());
        int chipsCount = int.Parse(Console.ReadLine());

        decimal beerPrice = beerCount * 1.20m;
        decimal chipsPrice = Math.Ceiling((beerPrice * 0.45m) * chipsCount);
        decimal totalPrice = beerPrice + chipsPrice;
        Console.WriteLine(budget >= totalPrice ?
            $"{fanName} bought a snack and has {budget - totalPrice} leva left." :
            $"{fanName} needs {totalPrice - budget} more leva!");
    }
}

