using System;
using System.Collections.Generic;

namespace _04.SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> primeNumbers = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                bool prime = true;
                int number = i;
                int index = 2;
                do
                {
                    if (number != 2 && (number < 2 || number % index == 0))
                    {
                        prime = false;
                        break;
                    }
                    index++;
                } while (index <= Math.Sqrt(number));
                if (prime)
                {
                    primeNumbers.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ", primeNumbers));
        }
    }
}
