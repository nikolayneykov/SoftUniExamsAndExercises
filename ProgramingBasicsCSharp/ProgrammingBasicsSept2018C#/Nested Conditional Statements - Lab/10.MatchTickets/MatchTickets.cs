using System;


class MatchTickets
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        string category = Console.ReadLine();
        int groupCount = int.Parse(Console.ReadLine());
        double totalExpenses = category == "VIP" ? 499.99 * groupCount : 249.99 * groupCount;

        double transportExpenses = 0;
        if (groupCount >= 1 && groupCount <= 4)
        {
            transportExpenses = budget * 0.75;
        }
        else if (groupCount >= 5 && groupCount <= 9)
        {
            transportExpenses = budget * 0.6;
        }
        else if (groupCount >= 10 && groupCount <= 24)
        {
            transportExpenses = budget * 0.5;
        }
        else if (groupCount >= 25 && groupCount <= 49)
        {
            transportExpenses = budget * 0.4;
        }
        else if (groupCount >= 50)
        {
            transportExpenses = budget * 0.25;
        }
        totalExpenses += transportExpenses;

        Console.WriteLine(budget>=totalExpenses?
            $"Yes! You have {budget-totalExpenses:F2} leva left." :
            $"Not enough money! You need {totalExpenses-budget:F2} leva.");
    }
}

