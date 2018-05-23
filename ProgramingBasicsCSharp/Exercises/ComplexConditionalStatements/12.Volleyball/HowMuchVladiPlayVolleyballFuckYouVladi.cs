using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class HowMuchVladiPlayVolleyballFuckYouVladi
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int holydays = int.Parse(Console.ReadLine());
            int weekendsAtHome = int.Parse(Console.ReadLine());
            int weekendsAtSofia = 48 - weekendsAtHome;

            double playTimesAtSofia = weekendsAtSofia * (3.0 / 4.0);
            double playTimesAtHome = weekendsAtHome;
            double playTimesAtHolydays = holydays * (2.0 / 3.0);
            double totalPlayTimes = (yearType == "leap") ?
               Math.Floor((playTimesAtSofia + playTimesAtHome + playTimesAtHolydays) * 1.15) :
               Math.Floor((playTimesAtSofia + playTimesAtHome + playTimesAtHolydays));
            Console.WriteLine(totalPlayTimes);
        }
    }
}
