using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Bachelor_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());

            string command = String.Empty;
            double couvert = 0;
            double sum = 0;
            int guests = 0;

            while ((command = Console.ReadLine()) != "The restaurant is full")
            {
                int group = int.Parse(command);
                if (group < 5)
                {
                    couvert = group * 100;
                }
                else
                {
                    couvert = group * 70;
                }
                guests += group;
                sum += couvert;
            }

            if (sum >= money)
            {
                Console.WriteLine($"You have {guests} guests and {sum - money} leva left.");
            }
            else if (sum < money)
            {
                Console.WriteLine($"You have {guests} guests and {sum} leva income, but no singer.");
            }
        }
    }
}