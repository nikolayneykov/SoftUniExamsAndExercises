using System;

namespace _01.SeaTrip
{
    class SeaTrip
    {
        static void Main(string[] args)
        {
            decimal moneyForFood = decimal.Parse(Console.ReadLine()) * 3;
            decimal moneyForTrinkets = decimal.Parse(Console.ReadLine()) * 3;
            decimal moneyForHotel = (decimal.Parse(Console.ReadLine()));
            decimal moneyForFuel = 54.39m;
            decimal totalMoney = moneyForFood + moneyForTrinkets + moneyForFuel;
            totalMoney += moneyForHotel * 0.9m;
            totalMoney += moneyForHotel * 0.85m;
            totalMoney += moneyForHotel * 0.8m;
            Console.WriteLine($"Money needed: {totalMoney:F2}");
        }
    }
}
