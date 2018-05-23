using System;

namespace _01.ProgrammingBook
{
    class ProgrammingBook
    {
        static void Main(string[] args)
        {
            decimal pricePerPage = decimal.Parse(Console.ReadLine());
            decimal pricePerCover = decimal.Parse(Console.ReadLine());
            decimal reductionPaper = 1 - decimal.Parse(Console.ReadLine()) / 100;
            decimal priceForDesigner = decimal.Parse(Console.ReadLine());
            decimal reductionTeam = 1 - decimal.Parse(Console.ReadLine()) / 100;

            decimal totalPrice = pricePerPage * 899 + pricePerCover * 2;
            totalPrice *= reductionPaper;
            totalPrice += priceForDesigner;
            totalPrice *= reductionTeam;
            Console.WriteLine($"Avtonom should pay {totalPrice:F2} BGN.");
        }
    }
}
