using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VaporStore
{
    class VaporStoreCalculations
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double spent = 0;
            string game = string.Empty;

            while ((game = Console.ReadLine()) != "Game Time" && budget != 0)
            {
                double gamePrice = 0;
                switch (game)
                {
                    case "OutFall 4": gamePrice = 39.99; break;
                    case "CS: OG": gamePrice = 15.99; break;
                    case "Zplinter Zell": gamePrice = 19.99; break;
                    case "Honored 2": gamePrice = 59.99; break;
                    case "RoverWatch": gamePrice = 29.99; break;
                    case "RoverWatch Origins Edition": gamePrice = 39.99; break;
                }
                if (gamePrice == 0)
                {
                    Console.WriteLine("Not Found");
                }
                else if (gamePrice > budget)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    budget -= gamePrice;
                    spent += gamePrice;
                    Console.WriteLine($"Bought {game}");
                }
            }
            Console.WriteLine(budget == 0 ? "Out of money!" :
                $"Total spent: ${spent:F2}. Remaining: ${budget:F2}");
        }
    }
}
