using System;

class CleverLily
{
    static void Main(string[] args)
    {
        int lilyAge = int.Parse(Console.ReadLine());
        double washmachinePrice = double.Parse(Console.ReadLine());
        double toyPrice = double.Parse(Console.ReadLine());
        double moneyGift = 10;
        double totalSavings = 0;
        for (int i = 1; i <= lilyAge; i++)
        {
            if (i % 2 == 1)
            {
                totalSavings += toyPrice;
            }
            else
            {
                totalSavings += moneyGift - 1;
                moneyGift += 10;
            }
        }
        Console.WriteLine(totalSavings >= washmachinePrice ?
            $"Yes! {totalSavings - washmachinePrice:F2}" :
            $"No! {washmachinePrice - totalSavings:F2}");
    }
}

