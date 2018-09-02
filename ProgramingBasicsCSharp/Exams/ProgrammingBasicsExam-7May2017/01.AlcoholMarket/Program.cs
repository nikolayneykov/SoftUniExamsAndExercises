using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerLiters = double.Parse(Console.ReadLine());
            double wineLiters = double.Parse(Console.ReadLine());
            double rakiaLiters = double.Parse(Console.ReadLine());
            double whiskeyLiters = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice / 2;
            double winePrice = rakiaPrice - rakiaPrice * 0.4;
            double beerPrice = rakiaPrice - rakiaPrice * 0.8;

            double totalSum = 0;
            double beerSum = beerLiters * beerPrice;
            double wineSum = wineLiters * winePrice;
            double rakiaSum = rakiaLiters * rakiaPrice;
            double whiskeySum = whiskeyLiters * whiskeyPrice;
            totalSum = beerSum + wineSum + rakiaSum + whiskeySum;
            Console.WriteLine("{0:F2}",totalSum);


        }
    }
}
