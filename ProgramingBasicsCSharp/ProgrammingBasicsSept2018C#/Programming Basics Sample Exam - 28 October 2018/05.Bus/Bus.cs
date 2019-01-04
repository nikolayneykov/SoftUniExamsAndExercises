using System;

class Bus
{
    static void Main(string[] args)
    {
        int passengersCount = int.Parse(Console.ReadLine());
        int stops = int.Parse(Console.ReadLine());

        for (int i = 0; i < stops; i++)
        {
            int passengersOut = int.Parse(Console.ReadLine());
            int passengersIn = int.Parse(Console.ReadLine());
            passengersCount -= passengersOut;
            passengersCount += passengersIn;
        }
        passengersCount += stops % 2 == 1 ? 2 : 0;

        Console.WriteLine($"The final number of passengers is : {passengersCount}");
    }
}

