using System;

namespace _10.CheckPrime
{
    class CheckPrime
    {
        static void Main(string[] args)
        {
            bool prime = true;
            int number = int.Parse(Console.ReadLine());
            int index = 2;
            do
            {
                if (number < 2 || number % index == 0)
                {
                    prime = false;
                    break;
                }
                index++;
            } while (index <= Math.Sqrt(number));
            Console.WriteLine(prime ? "Prime" : "Not Prime");
        }
    }
}
