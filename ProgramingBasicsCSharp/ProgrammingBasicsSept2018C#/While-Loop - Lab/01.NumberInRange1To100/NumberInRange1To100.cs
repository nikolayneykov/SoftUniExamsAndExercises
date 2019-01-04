using System;

class NumberInRange1To100
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number in the range [1...100]: ");
        int number = int.Parse(Console.ReadLine());
        while (number < 1 || number > 100)
        {
            Console.WriteLine("Invalid number!");
            Console.Write("Enter a number in the range [1...100]: ");
            number = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"The number is: {number}");
    }
}

