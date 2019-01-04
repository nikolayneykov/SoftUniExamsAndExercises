using System;

class NumberSequence
{
    static void Main(string[] args)
    {
        int maxNumber = int.MinValue;
        int minNumber = int.MaxValue;
        string input = string.Empty;
        while ((input = Console.ReadLine()) != "END")
        {
            int number = int.Parse(input);
            maxNumber = number > maxNumber ? number : maxNumber;
            minNumber = number < minNumber ? number : minNumber;
        }
        Console.WriteLine($"Max number: {maxNumber}\nMin number: {minNumber}");
    }
}

