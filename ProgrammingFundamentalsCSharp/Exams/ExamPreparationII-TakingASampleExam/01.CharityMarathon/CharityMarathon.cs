using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CharityMarathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            int daysOfMarathon = int.Parse(Console.ReadLine());
            int runnersCount = int.Parse(Console.ReadLine());
            int averageNumberOfLaps = int.Parse(Console.ReadLine());
            int lapLength = int.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

            long maximumRunners = daysOfMarathon * trackCapacity;
            long totalRunners = maximumRunners - runnersCount > 0 ?
                runnersCount : maximumRunners;
            long totalKilometers = (totalRunners*averageNumberOfLaps*lapLength) / 1000;
            decimal totalMoneyRaised = moneyPerKilometer * totalKilometers;
            Console.WriteLine($"Money raised: {totalMoneyRaised:F2}");
        }
    }
}
