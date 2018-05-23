using System;

namespace _03.FitnessCard
{
    class FitnessCard
    {
        static void Main(string[] args)
        {
            decimal availableMoney = decimal.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            decimal price = 0m;
            switch (sport)
            {
                case "Gym": price = gender == 'm' ? 42 : 35; break;
                case "Boxing": price = gender == 'm' ? 41 : 37; break;
                case "Yoga": price = gender == 'm' ? 45 : 42; break;
                case "Zumba": price = gender == 'm' ? 34 : 31; break;
                case "Dances": price = gender == 'm' ? 51 : 53; break;
                case "Pilates": price = gender == 'm' ? 39 : 37; break;
            }
            price = age <= 19 ? price * 0.8m : price;
            Console.WriteLine(price<= availableMoney? 
                $"You purchased a 1 month pass for {sport}." : 
                $"You don't have enough money! You need ${price-availableMoney:F2} more.");
        }
    }
}
