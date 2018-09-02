using System;

namespace _01.RageExpenses
{
    class RageExpenses
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;
            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCount++;
                }
                if (i % 3 == 0)
                {
                    mouseCount++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardCount++;
                    if (keyboardCount % 2 == 0)
                    {
                        displayCount++;
                    }
                }
            }
            decimal totalPrice = (headsetPrice * headsetCount) +
                                     (mousePrice * mouseCount) +
                               (keyboardPrice * keyboardCount) +
                                 (displayPrice * displayCount);
            Console.WriteLine($"Rage expenses: {totalPrice:F2} lv.");
        }
    }
}
