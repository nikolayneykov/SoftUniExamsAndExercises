using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FruitShop
{
    class CalculateFruitPrice
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            bool workDay = false;
            bool holyDay = false;
            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday": workDay = true; break;
                case "Saturday":
                case "Sunday": holyDay = true; break;
                default: Console.WriteLine("error"); break;
            }

            double fruitPrice = 0;
            if (workDay)
            {
                switch (fruit)
                {
                    case "banana":fruitPrice = 2.50; break;
                    case "apple": fruitPrice = 1.20;break;
                    case "orange": fruitPrice = 0.85;break;
                    case "grapefruit": fruitPrice = 1.45;break;
                    case "kiwi": fruitPrice = 2.70;break;
                    case "pineapple": fruitPrice = 5.50;break;
                    case "grapes": fruitPrice = 3.85;break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else if (holyDay)
            {
                switch (fruit)
                {
                    case "banana": fruitPrice = 2.70; break;
                    case "apple": fruitPrice = 1.25; break;
                    case "orange": fruitPrice = 0.90; break;
                    case "grapefruit": fruitPrice = 1.60; break;
                    case "kiwi": fruitPrice = 3.00; break;
                    case "pineapple": fruitPrice = 5.60; break;
                    case "grapes": fruitPrice = 4.20; break;
                    default: Console.WriteLine("error"); break;
                }
            }
            double result = fruitPrice * quantity;
            if (result!=0)
            {
                Console.WriteLine($"{result:F2}");
            }
        }
    }
}
