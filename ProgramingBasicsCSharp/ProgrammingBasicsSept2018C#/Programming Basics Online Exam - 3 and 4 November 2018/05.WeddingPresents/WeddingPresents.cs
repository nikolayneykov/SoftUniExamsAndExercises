using System;

class WeddingPresents
{
    static void Main(string[] args)
    {
        int guestsCount = int.Parse(Console.ReadLine());
        double giftsCount = double.Parse(Console.ReadLine());

        double money = 0;
        double electricalDevices = 0;
        double vouchers = 0;
        double others = 0;

        for (int i = 0; i < giftsCount; i++)
        {
            string giftCategory = Console.ReadLine();
            switch (giftCategory)
            {
                case "A": money++; break;
                case "B": electricalDevices++; break;
                case "V": vouchers++; break;
                case "G": others++; break;
            }
        }

        double moneyPercent = money / giftsCount * 100;
        double electricalDevicesPercent = electricalDevices / giftsCount * 100;
        double vouchersPercent = vouchers / giftsCount * 100;
        double othersPercent = others / giftsCount * 100;
        double giftsFromGuestPercent = giftsCount / guestsCount * 100;

        Console.WriteLine($"{moneyPercent:F2}%\n{electricalDevicesPercent:F2}%\n" +
                          $"{vouchersPercent:F2}%\n{othersPercent:F2}%\n" +
                          $"{giftsFromGuestPercent:F2}%");
    }
}

