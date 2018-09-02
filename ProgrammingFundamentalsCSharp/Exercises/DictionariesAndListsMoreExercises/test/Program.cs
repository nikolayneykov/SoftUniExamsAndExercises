using System;

class CalculateTimeAfter15Minutes
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        string result = (a / b).ToString($"F{n}");
        Console.WriteLine(result);
    }
}

