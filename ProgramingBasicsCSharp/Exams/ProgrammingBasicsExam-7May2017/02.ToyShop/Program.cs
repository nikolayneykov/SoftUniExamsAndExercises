using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int talkingDolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int totalToys = puzzles + talkingDolls + teddyBears + minions + trucks;
            double totalProfit = puzzles * 2.6 +
                                 talkingDolls * 3 +
                                 teddyBears * 4.1 +
                                 minions * 8.2 +
                                 trucks * 2;
            totalProfit = totalToys >= 50 ? totalProfit - totalProfit * 0.25 : totalProfit;
            totalProfit -= totalProfit * 0.1;

            if (totalProfit<excursionPrice)
            {
                Console.WriteLine("Not enough money! {0:F2} lv needed.",excursionPrice-totalProfit);
            }
            else
            {
                Console.WriteLine("Yes! {0:F2} lv left.",totalProfit-excursionPrice);
            }

        }
    }
}
