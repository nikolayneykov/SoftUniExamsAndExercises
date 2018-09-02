using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            int productVolume = int.Parse(Console.ReadLine());
            int productEnergyPer100ml = int.Parse(Console.ReadLine());
            int productSugarPer100ml = int.Parse(Console.ReadLine());

            double totalProductEnergy = productEnergyPer100ml * (productVolume / 100.0);
            double totalProductSugar = productSugarPer100ml * (productVolume / 100.0);

            Console.WriteLine($"{productVolume}ml {productName}: ");
            Console.WriteLine($"{totalProductEnergy}kcal, {totalProductSugar}g sugars");
        }
    }
}
