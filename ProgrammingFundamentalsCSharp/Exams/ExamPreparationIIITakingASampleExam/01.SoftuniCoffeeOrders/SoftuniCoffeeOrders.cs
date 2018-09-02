using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

namespace _01.SoftuniCoffeeOrders
{
    class SoftuniCoffeeOrders
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            for (int i = 0; i < ordersCount; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                string date = Console.ReadLine();
                Regex datePattern =
                    new Regex(@"(\d{1,2})\/(?<month>\d{1,2})\/(?<year>\d{4})");
                int month = int.Parse(datePattern
                    .Match(date)
                    .Groups["month"].Value);
                int year = int.Parse(datePattern
                    .Match(date)
                    .Groups["year"].Value);
                int capsulesCount = int.Parse(Console.ReadLine());
                decimal currentOrderPrice = pricePerCapsule *
                    DateTime.DaysInMonth(year, month) * capsulesCount;
                Console.WriteLine($"The price for the coffee is: ${currentOrderPrice:F2}");
                totalPrice += currentOrderPrice;
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
