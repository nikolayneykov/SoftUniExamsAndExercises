using System;
using System.Linq;

class Fishing
{
    static void Main(string[] args)
    {
        int quota = int.Parse(Console.ReadLine());
        double profit = 0;

        for (int i = 1; i <= quota; i++)
        {
            string fishName = Console.ReadLine();
            if (fishName == "Stop")
            {
                break;
            }
            double fishWeight = double.Parse(Console.ReadLine());
            double fishPrice = fishName.Sum(x => x) / fishWeight;
            profit += i % 3 == 0 ? fishPrice : -fishPrice;

            if (i == quota - 1)
            {
                Console.WriteLine("Lyubo fulfilled the quota!");
            }
        }
        Console.WriteLine(profit >= 0 ?
            $"Lyubo's profit from 4 fishes is {profit:F2} leva." :
            $"Lyubo lost {Math.Abs(profit):F2} leva today.");
    }
}

