using System;
using System.Linq;

namespace _06.Heists
{
    class Heists
    {
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int priceOfJewels = prices[0];
            int priceOfGold = prices[1];
            int totalExpenses = 0;
            int totalEarning = 0;
            string information = string.Empty;
            while ((information = Console.ReadLine()) != "Jail Time")
            {
                string[] heistsTokens = information.Split();
                string currentLoot = heistsTokens[0];
                int currentJewelsEarn = currentLoot.Count(x => x.Equals('%')) * priceOfJewels;
                int currentGoldEarn = currentLoot.Count(x => x.Equals('$')) * priceOfGold;
                totalEarning += currentJewelsEarn + currentGoldEarn;
                int currentExpenses = int.Parse(heistsTokens[1]);
                totalExpenses += currentExpenses;
            }
            Console.WriteLine(totalEarning >= totalExpenses ?
                $"Heists will continue. Total earnings: {totalEarning - totalExpenses}." :
                $"Have to find another job. Lost: {totalExpenses - totalEarning}.");
        }
    }
}
