using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            double grapesPerSqrtM = double.Parse(Console.ReadLine());
            int wineNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double totalGrapes = fieldSize * grapesPerSqrtM;
            double totalWine = (totalGrapes * 0.4) / 2.5;
            if (totalWine<wineNeeded)
            {
                double missingWine =Math.Floor( wineNeeded - totalWine);
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",missingWine);
            }
            else
            {
                double wineLeft = Math.Ceiling(totalWine-wineNeeded);
                double winePerWorker = Math.Ceiling(wineLeft / workers);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.",Math.Floor( totalWine));
                Console.WriteLine("{0} liters left -> {1} liters per person.",wineLeft,winePerWorker);
            }
        }
    }
}
