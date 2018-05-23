using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CelsiusToFahrenheit
{
    class ConvertCelsiusToFahrenheit
    {
        static void Main(string[] args)
        {
            double temperatureCelsius = double.Parse(Console.ReadLine());
            double temperatureFahrenheit = temperatureCelsius * 9 / 5.0 + 32;
            Console.WriteLine(temperatureFahrenheit);
        }
    }
}
