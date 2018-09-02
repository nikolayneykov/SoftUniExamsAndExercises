using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int numberOfGuests = int.Parse(Console.ReadLine());
            decimal pricePerBanana = decimal.Parse(Console.ReadLine());
            decimal pricePerEgg = decimal.Parse(Console.ReadLine());
            decimal pricePerKgBerries = decimal.Parse(Console.ReadLine());

            int numberOfSets = (int)Math.Ceiling(numberOfGuests / 6.0);
            decimal price = numberOfSets *
                (2m * pricePerBanana + 4m * pricePerEgg + 0.2m * pricePerKgBerries);
            decimal diff = Math.Abs(budget - price);
            Console.WriteLine(budget >= price ?
                $"Ivancho has enough money - it would cost {price:F2}lv.":
                $"Ivancho will have to withdraw money - he will need {diff:F2}lv more.");
        }
    }
}
