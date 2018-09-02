using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class HotelPrices
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double DoublePrice = 0;
            double SuitePrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = nightCount > 7 ?
                    (nightCount * 50) - (nightCount * 50 * 0.05) :
                    (nightCount * 50);
                DoublePrice = nightCount * 65;
                SuitePrice = nightCount * 75;
            }

            else if (month == "June" || month == "September")
            {
                studioPrice = nightCount * 60;
                DoublePrice = (nightCount > 14) ?
                    (nightCount * 72 * 0.10) : (nightCount * 72);
                SuitePrice = nightCount * 82;
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = nightCount * 68;
                DoublePrice = nightCount * 77;
                SuitePrice = (nightCount > 14) ?
                    (nightCount * 89) - (nightCount * 89 * 0.15) : (nightCount * 89);
            }
            //discount free night
            studioPrice = ((nightCount > 7) && (month == "September" || month == "October")) ?
                studioPrice - studioPrice / nightCount : studioPrice;

            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
            Console.WriteLine($"Double: {DoublePrice:F2} lv.");
            Console.WriteLine($"Suite: {SuitePrice:F2} lv.");
        }
    }
}
