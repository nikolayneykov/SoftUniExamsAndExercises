using System;

class EqualSumsEvenOddPosition
{
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        for (int i = start; i <= end; i++)
        {
            string currentNumber = i.ToString();
            int evenSum = (currentNumber[0] - '0') + (currentNumber[2] - '0') + (currentNumber[4] - '0');
            int oddSum = (currentNumber[1] - '0') + (currentNumber[3] - '0') + (currentNumber[5] - '0');
            if (oddSum == evenSum)
            {
                Console.Write(i + " ");
            }
        }
    }
}

