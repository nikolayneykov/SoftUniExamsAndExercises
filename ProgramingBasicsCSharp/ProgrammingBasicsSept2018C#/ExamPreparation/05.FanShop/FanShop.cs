using System;

class FanShop
{
    static void Main(string[] args)
    {
        int budget = int.Parse(Console.ReadLine());
        int itemCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < itemCount; i++)
        {
            string item = Console.ReadLine();
            budget -= item == "hoodie" ? 30 :
                      item == "keychain" ? 4 :
                      item == "T-shirt" ? 20 :
                      item == "flag" ? 15 :
                      item == "sticker" ? 1 : 0;
        }
        Console.WriteLine(budget >= 0 ?
            $"You bought {itemCount} items and left with {budget} lv." :
            $"Not enough money, you need {Math.Abs(budget)} more lv.");
    }
}

