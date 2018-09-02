using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string packageType = Console.ReadLine();

            string hallName = string.Empty;
            double price = 0;

            if (groupSize >= 1 && groupSize <= 50)
            {
                hallName = "Small Hall";
                price = 2500;
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hallName = "Terrace";
                price = 5000;
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hallName = "Great Hall";
                price = 7500;
            }

            Console.WriteLine(hallName == string.Empty ?
                "We do not have an appropriate hall." :
                $"We can offer you the {hallName}");

            if (hallName!=string.Empty)
            {
                switch (packageType)
                {
                    case "Normal": price = (price + 500) - (price + 500) * 0.05; break;
                    case "Gold": price = (price + 750) - (price + 750) * 0.10; break;
                    case "Platinum": price = (price + 1000) - (price + 1000) * 0.15; break;
                }
                double pricePerPerson = price / groupSize;
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }           
        }
    }
}
