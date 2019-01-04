using System;

namespace _08.CelsiusToFahrenheit
{
    class CelsiusToFahrenheit
    {
        static void Main(string[] args)
        {
            double temperatureCelsius = double.Parse(Console.ReadLine());
            double temperatureFahrenheit = temperatureCelsius * 9 / 5.0 + 32;
            Console.WriteLine(temperatureFahrenheit);
        }
    }
}
