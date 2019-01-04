using System;

class Program
{
    static void Main(string[] args)
    {
        char lastSectorSymbol = char.Parse(Console.ReadLine());
        int rowsCount = int.Parse(Console.ReadLine());
        int oddRowPlacesCount = int.Parse(Console.ReadLine());
        int totalPlacesCount = 0;

        for (char sector = 'A'; sector <= lastSectorSymbol; sector++, rowsCount++)
        {
            for (int row = 1; row <= rowsCount; row++)
            {
                char places = row % 2 == 1 ?
                    (char)('a' + oddRowPlacesCount) :
                    (char)('a' + oddRowPlacesCount + 2);

                for (char place = 'a'; place < places; place++, totalPlacesCount++)
                {
                    Console.WriteLine($"{sector}{row}{place}");
                }
            }
        }
        Console.WriteLine(totalPlacesCount);
    }
}

