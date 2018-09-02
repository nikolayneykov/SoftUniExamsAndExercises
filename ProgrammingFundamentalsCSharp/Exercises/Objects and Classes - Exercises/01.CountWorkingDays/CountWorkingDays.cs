using System;
using System.Globalization;
using System.Linq;

namespace _01.CountWorkingDays
{
    class CountWorkingDays
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);
            
            int workingDays = 0;

            while (startDate <= endDate)
            {
                DateTime[] holiDays =
                {
                    new DateTime(startDate.Year,1,1),
                    new DateTime(startDate.Year,3,3),
                    new DateTime(startDate.Year,5,1),
                    new DateTime(startDate.Year,5,6),
                    new DateTime(startDate.Year,5,24),
                    new DateTime(startDate.Year,9,6),
                    new DateTime(startDate.Year,9,22),
                    new DateTime(startDate.Year,11,1),
                    new DateTime(startDate.Year,12,24),
                    new DateTime(startDate.Year,12,25),
                    new DateTime(startDate.Year,12,26),
                };
                if (startDate.DayOfWeek.ToString() != "Saturday" &&
                    startDate.DayOfWeek.ToString() != "Sunday" &&
                    !holiDays.Contains(startDate))
                {
                    workingDays++;
                }
                startDate = startDate.AddDays(1);
            }
            Console.WriteLine(workingDays);
        }
    }
}
