using System;
class LeftAndRightSum
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int leftSum = 0;
        int rightSum = 0;
        for (int i = 0; i < 2 * n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (i < n)
            {
                leftSum += number;
            }
            else
            {
                rightSum += number;
            }
        }
        int difference = Math.Abs(leftSum - rightSum);
        Console.WriteLine(difference == 0 ? $"Yes, sum = {leftSum}" : $"No, diff = {difference}");
    }
}

