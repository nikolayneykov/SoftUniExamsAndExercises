using System;

class AccountBalance
{
    static void Main(string[] args)
    {
        decimal total = 0;
        int paymentsCount = int.Parse(Console.ReadLine());
        while (paymentsCount > 0)
        {
            decimal payment = decimal.Parse(Console.ReadLine());
            if (payment >= 0)
            {
                Console.WriteLine($"Increase: {payment:F2}");
                total += payment;
            }
            else
            {
                Console.WriteLine("Invalid operation!");
                break;
            }
            paymentsCount--;
        }
        Console.WriteLine($"Total: {total:F2}");
    }
}

