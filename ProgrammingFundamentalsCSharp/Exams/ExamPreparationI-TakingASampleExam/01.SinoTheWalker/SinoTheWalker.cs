using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.SinoTheWalker
{
    class SinoTheWalker
    {
        static void Main(string[] args)
        {
            string[] startTimeTokens = Console.ReadLine().Split(':');
            int startHour = int.Parse(startTimeTokens[0]);
            int startMinute = int.Parse(startTimeTokens[1]);
            int startSecond = int.Parse(startTimeTokens[2]);

            BigInteger numberOfSteps = BigInteger.Parse(Console.ReadLine());
            BigInteger secondsPerStep = BigInteger.Parse(Console.ReadLine());
            BigInteger neededSeconds = numberOfSteps * secondsPerStep;
            BigInteger neededMinutes = neededSeconds / 60;
            BigInteger neededHours = neededMinutes / 60;
            neededMinutes %= 60;
            neededSeconds %= 60;

            BigInteger arriveSecond = startSecond + neededSeconds;
            if (arriveSecond >= 60)
            {
                arriveSecond %= 60;
                startMinute++;
            }
            BigInteger arriveMinute = startMinute + neededMinutes;
            if (arriveMinute >= 60)
            {
                arriveMinute %= 60;
                startHour++;
            }
            BigInteger arriveHour = startHour + neededHours;
            if (arriveHour >= 24)
            {
                arriveHour %= 24;
            }
            Console.WriteLine($"Time Arrival: {arriveHour:D2}:{arriveMinute:D2}:{arriveSecond:D2}");
        }
    }
}
