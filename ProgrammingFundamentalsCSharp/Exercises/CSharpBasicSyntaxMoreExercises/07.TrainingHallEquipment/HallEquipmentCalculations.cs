using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TrainingHallEquipment
{
    class HallEquipmentCalculations
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());
            double subtotal = 0;

            for (int i = 0; i < numberOfItems; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());

                Console.WriteLine(itemCount>1?$"Adding {itemCount} {itemName}s to cart.":
                                              $"Adding {itemCount} {itemName} to cart.");
                subtotal += itemPrice * itemCount;
            }
            Console.WriteLine($"Subtotal: ${subtotal:F2}");
            Console.WriteLine(subtotal>budget?
                $"Not enough. We need ${(subtotal-budget):F2} more.":
                $"Money left: ${(budget-subtotal):F2}");
        }
    }
}
