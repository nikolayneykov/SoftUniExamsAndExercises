using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string routeType = Console.ReadLine();
            double tax = 0;
            if (routeType== "trail")
            {
                tax = juniors * 5.50 + seniors * 7;
            }
            else if (routeType == "cross-country")
            {
                tax = juniors * 8 + seniors * 9.5;
                if (juniors+seniors>=50)
                {
                    tax -= tax * 0.25;
                }
            }
            else if (routeType == "downhill")
            {
                tax = juniors * 12.25 + seniors * 13.75;
            }
            else if (routeType == "road")
            {
                tax = juniors * 20 + seniors * 21.50;
            }
            double expenses = tax * 0.05;
            tax -= expenses;
            Console.WriteLine("{0:F2}",tax);
        }
    }
}
