using System;

class SeaTrip
{
    static void Main(string[] args)
    {
        double moneyForFood = double.Parse(Console.ReadLine());
        double moneyForSouvenirs = double.Parse(Console.ReadLine());
        double moneyForHotel = double.Parse(Console.ReadLine());

        double totalPrice = (moneyForFood * 3 + moneyForSouvenirs * 3) +
                            (moneyForHotel * 0.9 + moneyForHotel * 0.85 + moneyForHotel * 0.8) +
                            54.39;
        Console.WriteLine($"Money needed: {totalPrice:F2}");
    }
}

