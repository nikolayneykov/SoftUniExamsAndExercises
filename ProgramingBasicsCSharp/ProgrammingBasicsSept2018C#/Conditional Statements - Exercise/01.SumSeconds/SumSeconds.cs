using System;

class SumSeconds
{
    static void Main(string[] args)
    {
        int firstTime = int.Parse(Console.ReadLine());
        int secondTime = int.Parse(Console.ReadLine());
        int thirdTime = int.Parse(Console.ReadLine());

        int totalTimeSeconds = firstTime + secondTime + thirdTime;
        int minutes = totalTimeSeconds / 60;
        int seconds = totalTimeSeconds % 60;
        Console.WriteLine($"{minutes}:{seconds:D2}");
    }
}

