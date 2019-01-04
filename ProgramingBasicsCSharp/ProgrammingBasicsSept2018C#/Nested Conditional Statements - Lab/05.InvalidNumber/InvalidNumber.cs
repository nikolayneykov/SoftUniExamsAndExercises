using System;

class InvalidNumber
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        if (!((number >= 100 && number <= 200) || number == 0))
        {
            Console.WriteLine("invalid");
        }
    }
}

