using System;

class MinNumber
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int smallestNumber = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (smallestNumber > number)
            {
                smallestNumber = number;
            }
        }
        Console.WriteLine(smallestNumber);
    }
}

