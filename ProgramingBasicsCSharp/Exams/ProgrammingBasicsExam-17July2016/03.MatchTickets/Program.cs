using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double transportExpenses = 0;
            if (people >= 1 && people <= 4)
            {
                transportExpenses = budget * 0.75;
            }
            else if (people >= 5 && people <= 9)
            {
                transportExpenses = budget * 0.6;
            }
            else if (people >= 10 && people <= 24)
            {
                transportExpenses = budget * 0.5;
            }
            else if (people >= 25 && people <= 49)
            {
                transportExpenses = budget * 0.4;
            }
            else if (people >= 50)
            {
                transportExpenses = budget * 0.25;
            }
            double moneyLeft = budget - transportExpenses;
            double normalTicketExpenses = 249.99 * people;
            double vipTicketExpenses = 499.99 * people;
            if (category=="Normal")
            {
                if (moneyLeft>= normalTicketExpenses)
                {
                    Console.WriteLine("Yes! You have {0:F2} leva left.",
                        moneyLeft- normalTicketExpenses);
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:F2} leva.", 
                        normalTicketExpenses - moneyLeft);
                }
            }
            else if (category=="VIP")
            {
                if (moneyLeft >= vipTicketExpenses)
                {
                    Console.WriteLine("Yes! You have {0:F2} leva left.",
                        moneyLeft - vipTicketExpenses);
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:F2} leva.",
                        vipTicketExpenses - moneyLeft);
                }
            }
        }
    }
}
