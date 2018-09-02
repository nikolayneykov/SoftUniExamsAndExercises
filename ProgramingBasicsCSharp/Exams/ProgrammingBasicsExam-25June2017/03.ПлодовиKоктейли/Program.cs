using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ПлодовиKоктейли
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int drinks = int.Parse(Console.ReadLine());
            double price = 0;

            switch (fruit)
            {
                case "Watermelon": price = size == "small" ? 56 * 2 : 28.7 * 5; break;
                case "Mango": price = size == "small" ? 36.66 * 2 : 19.6 * 5; break;
                case "Pineapple": price = size == "small" ? 42.1 * 2 : 24.8 * 5; break;
                case "Raspberry": price = size == "small" ? 20 * 2 : 15.2 * 5; break;
            }
            price *= drinks;
            if (price>1000)
            {
                price /= 2;
            }
            else if (price>=400 && price<=1000)
            {
                price -= price * 0.15;
            }
            Console.WriteLine("{0:F2} lv.",price);
        }
    }
}
