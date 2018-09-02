using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TheatrePromotion
{
    class CalculateTicketPrise
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine();
            int personAge = int.Parse(Console.ReadLine());
            bool underage = personAge >= 0 && personAge <= 18;
            bool adult = personAge > 18 && personAge <= 64;
            bool senior = personAge > 64 && personAge <= 122;
            int price = 0;
            if (underage)
            {
                switch (dayType)
                {
                    case "Weekday": price = 12; break;
                    case "Weekend": price = 15; break;
                    case "Holiday": price = 5; break;
                }
            }
            else if (adult)
            {
                switch (dayType)
                {
                    case "Weekday": price = 18; break;
                    case "Weekend": price = 20; break;
                    case "Holiday": price = 12; break;
                }
            }
            else if (senior)
            {
                switch (dayType)
                {
                    case "Weekday": price = 12; break;
                    case "Weekend": price = 15; break;
                    case "Holiday": price = 10; break;
                }
            }
            Console.WriteLine(underage || adult || senior ? $"{price}$" : "Error!");
        }
    }
}
