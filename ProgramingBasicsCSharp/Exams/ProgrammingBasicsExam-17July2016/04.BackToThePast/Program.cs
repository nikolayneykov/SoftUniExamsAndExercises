using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int maxYear = int.Parse(Console.ReadLine());
            int ivanchoAge = 18;
            for (int year = 1800; year <= maxYear; year++)
            {
                if (year%2==0)
                {
                    money -= 12000;
                }
                else
                {
                    money -= 12000 + 50 * ivanchoAge;
                }
                ivanchoAge++;
            }
            if (money<0)
            {
                Console.WriteLine("He will need {0:F2} dollars to survive.",Math.Abs(money));
            }
            else
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.",
                    money);
            }
        }
    }
}
