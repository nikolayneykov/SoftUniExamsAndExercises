using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SplinterTrip
{
    class SplinterTrip
    {
        static void Main(string[] args)
        {
            double tripDistance = double.Parse(Console.ReadLine());
            double fuelTankCapacity = double.Parse(Console.ReadLine());
            double milesSpentInHeavyWinds = double.Parse(Console.ReadLine());

            double milesInNonHeavyWinds = tripDistance - milesSpentInHeavyWinds;
            double nonHeavyWindsConsumption = milesInNonHeavyWinds * 25;
            double heavyWindsConsumption = milesSpentInHeavyWinds * (25 * 1.5);
            double fuelConsumption = nonHeavyWindsConsumption + heavyWindsConsumption;
            double tolerance = fuelConsumption * 0.05;
            double totalFuelConsumption = fuelConsumption + tolerance;

            Console.WriteLine($"Fuel needed: {totalFuelConsumption:F2}L");
            Console.WriteLine(fuelTankCapacity-totalFuelConsumption>=0?
                $"Enough with {fuelTankCapacity-totalFuelConsumption:F2}L to spare!":
                $"We need {totalFuelConsumption-fuelTankCapacity:F2}L more fuel.");
        }
    }
}
