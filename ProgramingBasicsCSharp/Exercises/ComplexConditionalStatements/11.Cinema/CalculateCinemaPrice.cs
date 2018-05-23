using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class CalculateCinemaPrice
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            int places = rows * columns;
            double placePrice = 0;
            switch (projectionType)
            {
                case "Premiere":placePrice = 12.00;break;
                case "Normal": placePrice = 7.50;break;
                case "Discount": placePrice = 5.00;break;
            }
            double totalPrice = placePrice * places;
            Console.WriteLine($"{totalPrice:F2} leva");
        }
    }
}
