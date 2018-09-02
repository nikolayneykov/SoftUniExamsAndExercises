using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.БлаготворителнаКампания
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            decimal profitCakes = days * confectioners * cakes * 45m;
            decimal profitWaffles = days * confectioners * waffles * 5.8m;
            decimal profitPancakes = days * confectioners * pancakes * 3.2m;

            decimal totalSum = (profitCakes + profitWaffles + profitPancakes) -
                (profitCakes + profitWaffles + profitPancakes) / 8;
            Console.WriteLine("{0:F2}", totalSum);
        }
    }
}
