using System;

class FruitShop
{
    static void Main(string[] args)
    {
        string fruit = Console.ReadLine();
        string dayOfWeek = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());
        bool isWeekend = false;
        bool isValidDay = false;
        double fruitPrice = 0;
        switch (dayOfWeek)
        {
            case "Monday":
            case "Tuesday":
            case "Wednesday":
            case "Thursday":
            case "Friday": isValidDay = true; break;
            case "Saturday":
            case "Sunday": isValidDay = true; isWeekend = true; ; break;
        }

        switch (fruit)
        {
            case "banana": fruitPrice = isWeekend ? 2.70 : 2.50; break;
            case "apple": fruitPrice = isWeekend ? 1.25 : 1.20; break;
            case "orange": fruitPrice = isWeekend ? 0.90 : 0.85; break;
            case "grapefruit": fruitPrice = isWeekend ? 1.60 : 1.45; break;
            case "kiwi": fruitPrice = isWeekend ? 3.00 : 2.70; break;
            case "pineapple": fruitPrice = isWeekend ? 5.60 : 5.50; break;
            case "grapes": fruitPrice = isWeekend ? 4.20 : 3.85; break;
        }
        Console.WriteLine((fruitPrice != 0 && isValidDay) ?
            (fruitPrice * quantity).ToString("F2") : "error");
    }
}

