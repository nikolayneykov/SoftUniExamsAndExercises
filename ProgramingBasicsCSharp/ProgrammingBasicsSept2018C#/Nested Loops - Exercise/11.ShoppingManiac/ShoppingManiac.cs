using System;

class ShoppingManiac
{
    static void Main(string[] args)
    {
        int moneyLeft = int.Parse(Console.ReadLine());
        int moneySpent = 0;
        int clothesCount = 0;
        string command = string.Empty;
        while (moneyLeft != 0 && (command = Console.ReadLine()) != "enough")
        {
            if (command == "enter")
            {
                while ((command = Console.ReadLine()) != "leave" && moneyLeft > 0)
                {
                    int currentPrice = int.Parse(command);
                    if (moneyLeft - currentPrice >= 0)
                    {
                        moneyLeft -= currentPrice;
                        moneySpent += currentPrice;
                        clothesCount++;
                    }
                    else
                    {
                        Console.WriteLine("Not enough money.");
                    }
                }
            }
        }
        Console.WriteLine($"For {clothesCount} clothes I spent {moneySpent} lv and have {moneyLeft} lv left.");
    }
}

