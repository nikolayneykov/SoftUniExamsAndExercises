using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            string sport = string.Empty;
            double price = 0;

            if (season == "Winter")
            {
                if (groupType == "girls")
                {
                    price = students * nights * 9.6;
                    sport = "Gymnastics";
                }
                else if (groupType == "boys")
                {
                    price = students * nights * 9.6;
                    sport = "Judo";
                }
                else
                {
                    price = students * nights * 10;
                    sport = "Ski";
                }
            }
            else if (season == "Spring")
            {
                if (groupType == "girls")
                {
                    price = students * nights * 7.2;
                    sport = "Athletics";
                }
                else if (groupType == "boys")
                {
                    price = students * nights * 7.2;
                    sport = "Tennis";
                }
                else
                {
                    price = students * nights * 9.5;
                    sport = "Cycling";
                }
            }
            else
            {
                if (groupType == "girls")
                {
                    price = students * nights * 15;
                    sport = "Volleyball";
                }
                else if (groupType == "boys")
                {
                    price = students * nights * 15;
                    sport = "Football";
                }
                else
                {
                    price = students * nights * 20;
                    sport = "Swimming";
                }
            }

            if (students >= 50)
            {
                price /= 2;
            }
            else if (students >= 20 && students < 50)
            {
                price -= price * 0.15;
            }
            else if (students>=10 && students<20)
            {
                price -= price * 0.05;
            }

            Console.WriteLine("{0} {1:F2} lv.",sport,price);
        }
    }
}
