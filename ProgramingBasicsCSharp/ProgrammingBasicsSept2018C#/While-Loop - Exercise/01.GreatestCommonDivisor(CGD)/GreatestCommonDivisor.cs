using System;

class GreatestCommonDivisor
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        while (a != b)
        {
            if (a > b)
            {
                a = a - b;
            }
            else
            {
                b= b - a;
            }
        }
        Console.WriteLine(b);
    }
}

