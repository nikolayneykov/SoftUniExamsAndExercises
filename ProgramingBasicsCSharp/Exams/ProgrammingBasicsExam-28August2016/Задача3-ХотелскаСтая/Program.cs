using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача3_ХотелскаСтая
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double apartmentPrice = 0;
            double studioPrice = 0;

            if (month== "May"|| month=="October")
            {
                apartmentPrice = nights * 65;
                studioPrice = nights * 50;
                if (nights>7 && nights<=14)
                {
                    studioPrice -= studioPrice * 0.05;
                }
                else if (nights>14)
                {
                    studioPrice -= studioPrice * 0.3;
                    apartmentPrice -= apartmentPrice * 0.1;
                }
            }
            else if (month == "June" || month == "September")
            {
                apartmentPrice = nights * 68.7;
                studioPrice = nights * 75.2;
                if (nights > 14)
                {
                    studioPrice -= studioPrice * 0.2;
                    apartmentPrice -= apartmentPrice * 0.1;
                }
            }
            else if (month == "July" || month == "August")
            {
                apartmentPrice = nights * 77;
                studioPrice = nights * 76;
                if (nights > 14)
                {
                    apartmentPrice -= apartmentPrice * 0.1;
                }
            }
            Console.WriteLine("Apartment: {0:F2} lv.",apartmentPrice);
            Console.WriteLine("Studio: {0:F2} lv.", studioPrice);
        }
    }
}
