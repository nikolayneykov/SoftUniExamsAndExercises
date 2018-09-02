using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.СветовенРекордПоПлуване
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double ivanchoSpeedSecPerM = double.Parse(Console.ReadLine());

            double ivanchoAttempt = distanceInMeters * ivanchoSpeedSecPerM;
            ivanchoAttempt +=Math.Floor(distanceInMeters / 15) * 12.5;
            if (ivanchoAttempt>=recordInSeconds)
            {
                Console.WriteLine("No, he failed! He was {0:F2} seconds slower.",
                    ivanchoAttempt-recordInSeconds);
            }
            else
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:F2} seconds.",
                    ivanchoAttempt);
            }
        }
    }
}
