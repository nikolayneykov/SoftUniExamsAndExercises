using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Logistics
    {
        static void Main(string[] args)
        {
            int numberOfLoads = int.Parse(Console.ReadLine());
            int busLoad = 0;
            int truckLoad = 0;
            int trainLoad = 0;
            int totalLoad = 0;
            for (int i = 0; i < numberOfLoads; i++)
            {
                int weightOLoad = int.Parse(Console.ReadLine());
                if (weightOLoad <= 3)
                {
                    busLoad += weightOLoad;
                }
                else if (weightOLoad >= 4 && weightOLoad <= 11)
                {
                    truckLoad += weightOLoad;
                }
                else
                {
                    trainLoad += weightOLoad;
                }
                totalLoad += weightOLoad;
            }
            double avaragePricePerTon =
                (busLoad * 200 + truckLoad * 175 + trainLoad * 120) / (double)totalLoad;
            Console.WriteLine("{0:F2}", avaragePricePerTon);
            Console.WriteLine("{0:F2}%", busLoad / (double)totalLoad * 100);
            Console.WriteLine("{0:F2}%", truckLoad / (double)totalLoad * 100);
            Console.WriteLine("{0:F2}%", trainLoad / (double)totalLoad * 100);
        }
    }
}
