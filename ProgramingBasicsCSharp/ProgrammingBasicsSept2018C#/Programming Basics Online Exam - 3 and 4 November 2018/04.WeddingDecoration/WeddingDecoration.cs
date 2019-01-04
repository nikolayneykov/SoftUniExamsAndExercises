using System;

class WeddingDecoration
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        double balloons = 0;
        double flowers = 0;
        double candles = 0;
        double ribbon = 0;
        string product = string.Empty;
        double spendMoney = 0;
        while (budget > spendMoney && (product = Console.ReadLine()) != "stop")
        {
            double quantity = double.Parse(Console.ReadLine());
            double currentPrice = 0;
            switch (product)
            {
                case "balloons": currentPrice = quantity * 0.1; balloons += quantity; break;
                case "flowers": currentPrice = quantity * 1.5; flowers += quantity; break;
                case "candles": currentPrice = quantity * 0.5; candles += quantity; break;
                case "ribbon": currentPrice = quantity * 2; ribbon += quantity; break;
            }
            spendMoney += currentPrice;
        }
        Console.WriteLine(budget <= spendMoney ?
            "All money is spent!" :
            $"Spend money: {spendMoney:F2}\nMoney left: {budget - spendMoney:F2}");
        Console.WriteLine("Purchased decoration is " +
            $"{balloons} balloons, {ribbon} m ribbon, {flowers} flowers and {candles} candles.");
    }
}

