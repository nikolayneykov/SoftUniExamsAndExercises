using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TravelingAtLightSpeed
{
    class TravelingAtLightSpeed
    {
        static void Main(string[] args)
        {
            decimal lightYears = decimal.Parse(Console.ReadLine());
            decimal kmPerLightYear = 9450000000000m;
            decimal kmPerLightSecond = 300000m;
            decimal totalSeconds = (lightYears * kmPerLightYear) / kmPerLightSecond;
            long seconds = (long)totalSeconds % 60;
            long minutes = (long)totalSeconds / 60;
            long hours = minutes / 60;
            minutes %= 60;
            long days = hours / 24;
            hours %= 24;
            long weeks = days / 7;
            days %= 7;
            Console.WriteLine($"{weeks} weeks");
            Console.WriteLine($"{days} days");
            Console.WriteLine($"{hours} hours");
            Console.WriteLine($"{minutes} minutes");
            Console.WriteLine($"{seconds} seconds");
        }
    }
}
