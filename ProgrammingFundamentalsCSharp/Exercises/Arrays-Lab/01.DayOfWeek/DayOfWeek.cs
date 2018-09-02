using System;

namespace _01.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday",
                         "Thursday", "Friday", "Saturday", "Sunday" };
            int dayNumber = int.Parse(Console.ReadLine()) - 1;
            if (dayNumber > daysOfWeek.Length - 1 || dayNumber < 0)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(daysOfWeek[dayNumber]);
            }
        }
    }
}
