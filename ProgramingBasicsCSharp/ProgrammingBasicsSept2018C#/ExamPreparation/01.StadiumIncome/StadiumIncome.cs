using System;

class StadiumIncome
{
    static void Main(string[] args)
    {
        int stadiumSectors = int.Parse(Console.ReadLine());
        int stadiumCapacity = int.Parse(Console.ReadLine());
        double pricePerTicket = double.Parse(Console.ReadLine());

        double totalIncome = stadiumCapacity * pricePerTicket;
        double incomePerSector = totalIncome / stadiumSectors;
        double moneyForCharity = (totalIncome - (incomePerSector * 0.75)) / 8;
        Console.WriteLine($"Total income - {totalIncome:F2} BGN\nMoney for charity - {moneyForCharity:F2} BGN");
    }
}

