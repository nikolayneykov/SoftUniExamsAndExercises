using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Snowballs
{
    class Snowballs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            BigInteger bestSnowballValue = 0;
            for (int i = 0; i < n; i++)
            {
                int currentSnowballSnow = int.Parse(Console.ReadLine());
                int currentSnowballTime = int.Parse(Console.ReadLine());
                int currentSnowballQuality = int.Parse(Console.ReadLine());

                BigInteger currentSnowballValue = 1;
                int multiplier = currentSnowballSnow / currentSnowballTime;
                for (int j = 0; j < currentSnowballQuality; j++)
                {
                    currentSnowballValue *= multiplier;
                }

                if (currentSnowballValue >= bestSnowballValue)
                {
                    bestSnowballValue = currentSnowballValue;
                    snowballSnow = currentSnowballSnow;
                    snowballTime = currentSnowballTime;
                    snowballQuality = currentSnowballQuality;
                }
            }
            Console.WriteLine($"{snowballSnow} : {snowballTime} = {bestSnowballValue} ({snowballQuality})");
        }
    }
}
