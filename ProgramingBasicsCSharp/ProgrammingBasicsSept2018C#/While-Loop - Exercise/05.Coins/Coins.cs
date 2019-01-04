using System;

class Coins
{
    static void Main()
    {
        decimal change = decimal.Parse(Console.ReadLine());
        int count = 0;
        while (change > 0)
        {
            change -= change >= 2 ? 2 :
                      change >= 1 ? 1 :
                      change >= 0.50 ? 0.50 :
                      change >= 0.20 ? 0.20 :
                      change >= 0.10 ? 0.10 :
                      change >= 0.05 ? 0.05 :
                      change >= 0.02 ? 0.02 :
                      change == 0.01 ? 0.01 : 0;
            count++;
        }
        Console.WriteLine(count);
    }
}