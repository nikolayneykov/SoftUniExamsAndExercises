using System;

namespace _02.BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double bonusScore = 0;
            if (number <= 100)
            {
                bonusScore = 5;
            }
            else if (number > 100 && number <= 1000)
            {
                bonusScore = number * 0.2;
            }
            else if (number > 1000)
            {
                bonusScore = number * 0.1;
            }
            bonusScore += number % 2 == 0 ? 1 : 0;
            bonusScore += number % 10 == 5 ? 2 : 0;
            Console.WriteLine(bonusScore);
            Console.WriteLine(number + bonusScore);
        }
    }
}
