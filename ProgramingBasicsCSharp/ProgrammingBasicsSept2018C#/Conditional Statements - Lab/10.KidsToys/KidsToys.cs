using System;

class KidsToys
{
    static void Main(string[] args)
    {
        double excursionPrice = double.Parse(Console.ReadLine());
        int puzzles = int.Parse(Console.ReadLine());
        int talkingDolls = int.Parse(Console.ReadLine());
        int teddyBears = int.Parse(Console.ReadLine());
        int minions = int.Parse(Console.ReadLine());
        int trucks = int.Parse(Console.ReadLine());

        double proffit =
            puzzles * 2.6 + talkingDolls * 3 + teddyBears * 4.1 + minions * 8.2 + trucks * 2;
        int toysCount = puzzles + talkingDolls + teddyBears + minions + trucks;
        if (toysCount >= 50)
        {
            proffit *= 0.75;
        }
        proffit *= 0.9;
        Console.WriteLine(excursionPrice <= proffit ?
            $"Yes! {proffit - excursionPrice:F2} lv left." :
            $"Not enough money! {excursionPrice - proffit:F2} lv needed.");
    }
}

