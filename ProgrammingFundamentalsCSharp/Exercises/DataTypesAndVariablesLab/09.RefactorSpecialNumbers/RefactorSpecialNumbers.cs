using System;

namespace _09.RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int currentNumber = i;
                int currentSum = 0;
                while (currentNumber > 0)
                {
                    currentSum += currentNumber % 10;
                    currentNumber /= 10;
                }
                bool isSpecial = currentSum == 5 || currentSum == 7 || currentSum == 11;
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
