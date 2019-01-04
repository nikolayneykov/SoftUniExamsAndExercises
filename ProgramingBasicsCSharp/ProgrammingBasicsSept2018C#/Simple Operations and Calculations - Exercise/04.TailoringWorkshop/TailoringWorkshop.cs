using System;

namespace _04.TailoringWorkshop
{
    class TailoringWorkshop
    {
        static void Main(string[] args)
        {
            int numberOfTable = int.Parse(Console.ReadLine());
            double lengthOFTable = double.Parse(Console.ReadLine());
            double widthOfTable = double.Parse(Console.ReadLine());

            double squareTableclothSide = lengthOFTable / 2;
            double rectnagleTableclothLength = lengthOFTable + 0.6;
            double rectangleTableclothWidth = widthOfTable + 0.6;

            double squareTableclothArea = squareTableclothSide * squareTableclothSide * numberOfTable;
            double rectangleTableclothArea = rectnagleTableclothLength * rectangleTableclothWidth * numberOfTable;

            double priceUsd = (squareTableclothArea * 9 + rectangleTableclothArea * 7);
            double priceBgn = priceUsd * 1.85;

            Console.WriteLine("{0:F2} USD", priceUsd);
            Console.WriteLine("{0:F2} BGN", priceBgn);
        }
    }
}
