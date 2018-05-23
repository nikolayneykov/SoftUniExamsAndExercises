using System;

namespace _11.EnterEvenNumber
{
    class EnterEvenNumber
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"Even number entered: {number}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The number is not even.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}
