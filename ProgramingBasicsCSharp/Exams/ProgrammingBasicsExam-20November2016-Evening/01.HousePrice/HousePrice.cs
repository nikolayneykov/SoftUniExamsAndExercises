using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HousePrice
{
    class HousePrice
    {
        static void Main(string[] args)
        {
            double smallestRoom = double.Parse(Console.ReadLine());
            double kitchen = double.Parse(Console.ReadLine());
            double pricePerSqrtM = double.Parse(Console.ReadLine());

            double bathroom = smallestRoom / 2;
            double secondRoom = smallestRoom + smallestRoom * 0.1;
            double thirdRoom = secondRoom + secondRoom * 0.1;

            double totalArea = smallestRoom + secondRoom + thirdRoom + kitchen + bathroom;
            totalArea += totalArea * 0.05;

            double result = totalArea * pricePerSqrtM;
            Console.WriteLine("{0:F2}",result);
        }
    }
}
