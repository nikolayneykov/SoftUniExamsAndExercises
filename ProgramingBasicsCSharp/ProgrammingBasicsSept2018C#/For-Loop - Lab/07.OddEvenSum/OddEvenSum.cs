using System;

    class OddEvenSum
    {
        static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine());
        int evenSum = 0;
        int oddSum = 0;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                evenSum += number;
            }
            else
            {
                oddSum += number;
            }
        }
        int difference = Math.Abs(evenSum - oddSum);
        Console.WriteLine(difference == 0 ? $"Yes\nSum = {evenSum}" : $"No\nDiff = {difference}");
    }
    }

