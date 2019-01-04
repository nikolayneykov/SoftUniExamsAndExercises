using System;

class MetricConverter
{
    static void Main(string[] args)
    {
        double distance = double.Parse(Console.ReadLine());
        string inputUnit = Console.ReadLine();
        string outputUnit = Console.ReadLine();

        switch (inputUnit)
        {
            case "mm": distance /= 1000; break;
            case "cm": distance /= 100; break;
            case "mi": distance /= 0.000621371192; break;
            case "in": distance /= 39.3700787; break;
            case "km": distance /= 0.001; break;
            case "ft": distance /= 3.2808399; break;
            case "yd": distance /= 1.0936133; break;
        }
        switch (outputUnit)
        {
            case "mm": distance*= 1000; break;
            case "cm": distance*= 100; break;
            case "mi": distance*= 0.000621371192; break;
            case "in": distance*= 39.3700787; break;
            case "km": distance*= 0.001; break;
            case "ft": distance*= 3.2808399; break;
            case "yd": distance*= 1.0936133; break;
        }
        Console.WriteLine($"{distance:F8}");
    }
}

