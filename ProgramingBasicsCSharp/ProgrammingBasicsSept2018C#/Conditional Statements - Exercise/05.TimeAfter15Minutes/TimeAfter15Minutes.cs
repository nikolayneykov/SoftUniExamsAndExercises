using System;

class TimeAfter15Minutes
{
    static void Main(string[] args)
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        TimeSpan time = new TimeSpan(hours, minutes + 15, 0);
        Console.WriteLine(time.ToString("h\\:mm"));
    }
}

