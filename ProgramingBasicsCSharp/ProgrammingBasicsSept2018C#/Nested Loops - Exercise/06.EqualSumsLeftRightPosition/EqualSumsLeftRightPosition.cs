using System;

class EqualSumsLeftRightPosition
{
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        for (int i = start; i <= end; i++)
        {
            int currentNumber = i;
            int leftSum = currentNumber / 10000 + ((currentNumber / 1000) % 10);
            int rightSum = currentNumber % 10 + ((currentNumber / 10) % 10);
            int midDigit = currentNumber / 100 % 10;
            int smallerSum = Math.Min(leftSum, rightSum);
            int greaterSum = Math.Max(leftSum, rightSum);
            if (leftSum == rightSum)
            {
                Console.WriteLine(i);
            }
            else if (smallerSum + midDigit == greaterSum)
            {
                Console.WriteLine(i);
            }
        }
    }
}
