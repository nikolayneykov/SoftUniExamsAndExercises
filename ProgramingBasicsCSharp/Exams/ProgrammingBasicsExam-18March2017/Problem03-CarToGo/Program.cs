using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string classType = string.Empty;
            string carType = string.Empty;
            double price = 0;

            if (budget <= 100)
            {
                classType = "Economy class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    price = budget * 0.35;
                }
                else
                {
                    carType = "Jeep";
                    price = budget * 0.65;
                }
            }
            else if (budget > 100 & budget <= 500)
            {
                classType = "Compact class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    price = budget * 0.45;
                }
                else
                {
                    carType = "Jeep";
                    price = budget * 0.80;
                }
            }
            else
            {
                classType = "Luxury class";
                carType = "Jeep";
                price = budget * 0.9;
            }

            Console.WriteLine(classType);
            Console.WriteLine("{0} - {1:F2}", carType, price);
        }
    }
}
