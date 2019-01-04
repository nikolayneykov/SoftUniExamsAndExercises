using System;

class HotelRoom
{
    static void Main(string[] args)
    {
        string month = Console.ReadLine();
        int nights = int.Parse(Console.ReadLine());

        double studioPrice = (month == "May" || month == "October") ? 50 * nights :
                             (month == "June" || month == "September") ? 75.2 * nights :
                             (month == "July" || month == "August") ? 76 * nights : 0;

        studioPrice *= ((month == "May" || month == "October") && nights > 14) ? 0.70 :
                       ((month == "May" || month == "October") && nights > 7) ? 0.95 :
                       ((month == "June" || month == "September") && nights > 14) ? 0.80 : 1;

        double apartmentPrice = (month == "May" || month == "October") ? 65 * nights :
                                (month == "June" || month == "September") ? 68.7 * nights :
                                (month == "July" || month == "August") ? 77 * nights : 0;

        apartmentPrice *= nights > 14 ? 0.9 : 1;

        Console.WriteLine("Apartment: {0:F2} lv.", apartmentPrice);
        Console.WriteLine("Studio: {0:F2} lv.", studioPrice);
    }
}

