using System;

class SumPrimeNonPrime
{
    static void Main(string[] args)
    {
        int primeSum = 0;
        int nonPrimeSum = 0;
        string input = string.Empty;
        while ((input = Console.ReadLine()) != "stop")
        {
            int number = int.Parse(input);
            if (number < 0)
            {
                Console.WriteLine("Number is negative.");
            }
            else
            {
                bool isPrime = CheckPrime(number);
                if (isPrime)
                {
                    primeSum += number;
                }
                else
                {
                    nonPrimeSum += number;
                }
            }
        }

        Console.WriteLine($"Sum of all prime numbers is: {primeSum}" +
                          $"\nSum of all non prime numbers is: {nonPrimeSum}");
    }
    static bool CheckPrime(int number)
    {
        bool isPrime = true;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        return number > 1 && isPrime;
    }
}

