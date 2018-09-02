using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string place = string.Empty;
            string location = string.Empty;
            double price = 0;

            if (budget<=1000)
            {
                place = "Camp";
                if (season=="Summer")
                {
                    location = "Alaska";
                    price = budget * 0.65;
                }
                else
                {
                    location = "Morocco";
                    price = budget * 0.45;
                }
            }
            else if (budget>1000 && budget<=3000)
            {
                place = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.8;
                }
                else
                {
                    location = "Morocco";
                    price = budget * 0.6;
                }
            }
            else
            {
                place = "Hotel";
                price = budget * 0.9;
                if (season == "Summer")
                {
                    location = "Alaska";
                }
                else
                {
                    location = "Morocco";                   
                }
            }
            Console.WriteLine("{0} - {1} - {2:F2}",location,place,price);
        }
    }
}
