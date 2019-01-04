using System;

class WeddingParty
{
    static void Main(string[] args)
    {
        int guestsCount = int.Parse(Console.ReadLine());
        double budget = double.Parse(Console.ReadLine());

        double guestPrice = guestsCount * 20;
        if (guestPrice >= budget)
        {
            Console.WriteLine($"They won't have enough money to pay the covert. They will need {guestPrice - budget} lv more.");
        }
        else
        {
            budget -= guestPrice;
            double fireworksMoney = Math.Round(budget * 0.4);
            double donationMoney = Math.Round(budget - fireworksMoney);
            Console.WriteLine($"Yes! {fireworksMoney} lv are for fireworks and {donationMoney} lv are for donation. ");
        }
    }
}

