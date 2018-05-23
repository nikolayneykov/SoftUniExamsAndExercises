using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FlowerShop
{
    class FlowerShop
    {
        static void Main(string[] args)
        {
            int magnolias = int.Parse(Console.ReadLine());
            int hyacinths = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double profit = magnolias * 3.25 +
                            hyacinths * 4 +
                            roses * 3.5 +
                            cactuses * 8;
            profit -= profit * 0.05;
            if (profit < giftPrice)
            {
                Console.WriteLine("She will have to borrow {0} leva.",
                    Math.Ceiling(giftPrice - profit));
            }
            else
            {
                Console.WriteLine("She is left with {0} leva.",
                    Math.Floor(profit-giftPrice));
            }
        }
    }
}
