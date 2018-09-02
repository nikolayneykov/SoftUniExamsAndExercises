using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            bool holyday = Console.ReadLine() == "Y" ? true : false;
            int totalFlowers = chrysanthemums + roses + tulips;
            double price = 0;

            if (season== "Spring"|| season=="Summer")
            {
                price = chrysanthemums * 2 + roses * 4.1 + tulips * 2.5;
                price = holyday ? price + price * 0.15 : price;
                if (season=="Spring" && tulips>7)
                {
                    price -= price * 0.05;
                }
            }
            else
            {
                price = chrysanthemums * 3.75 + roses * 4.5 + tulips * 4.15;
                price = holyday ? price + price * 0.15 : price;
                if (season == "Winter" && roses >= 10)
                {
                    price -= price * 0.1;
                }
            }

            price = totalFlowers > 20 ? price - price * 0.2 : price;
            price += 2;
            Console.WriteLine("{0:F2}",price);
        }
    }
}
