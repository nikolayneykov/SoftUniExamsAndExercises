using System;

class Travelling
{
    static void Main(string[] args)
    {
        string destination = string.Empty;
        while ((destination = Console.ReadLine()) != "End")
        {
            double neededSum = double.Parse(Console.ReadLine());
            double savedSum = 0;
            while (neededSum > savedSum)
            {
                savedSum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Going to {destination}!");
        }
    }
}

