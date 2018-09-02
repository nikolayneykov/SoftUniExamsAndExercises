using System;
using System.Globalization;
namespace _01._Day_of_Week
{
    class StartUp
    {
        static void Main(string[] args)
        {
            DateTime day = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(day.DayOfWeek);
        }
    }
}
